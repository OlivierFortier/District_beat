using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControlleurEnnemi : MonoBehaviour
{

    //référence au agent AI
    public NavMeshAgent agent;


    //référence au tag qui sonts sur les personnages joueurs
    public string tagJoueur;

    //tableau dans lequel sera initialisé tous les joueus
    private GameObject[] lesJoueurs;

    //références au layers qui seront affectées par ce script uniquement
    public LayerMask coucheSol, coucheJoueur;


    //le point d'origine de la zone que le AI va patrouiller
    private Vector3 pointPatrouille;
    //si le point de patrouille est actif
    private bool pointPatrouilleActif;
    //la grandeur de la zone de patrouille
    public float zonePatrouille;

    //les grandeurs des zones de visions et d'attaque melee ou a distance de l'ennemi
    public float zoneVision, zoneAttaqueMelee, zoneAttaqueDistance;
    //si le joueur est en distance visible ou en distance attaquable mélée ou en distance d'attaque de loin
    private bool joueurVisible, joueurAttaquableMelee, joueurAttaquableDistance;

    //référence au script d'attaque mélée
    public CombatMelee refMelee;

    //référence au script d'attaque distance
    public MonoBehaviour refDistance;



    IEnumerator Start()
    {
        //on initialise par défaut le tag joueur, on peut le changer dans l'inspecteur plus tard
        tagJoueur = "joueur";

        // on va chercher tous les gameobjects de personnage joueurs
        lesJoueurs = GameObject.FindGameObjectsWithTag(tagJoueur);

        //on démare une coroutine qui activera le AI dans 1 seconde, 
        // le temps de laisser le navmesh se construire dans le niveau
        yield return StartCoroutine("ActiverAi");

    }

    //méthode pour attendre 1 seconde avant d'activer le AI
    IEnumerator ActiverAi()
    {
        yield return new WaitForSecondsRealtime(1f);
        agent.enabled = true;
    }

    void Update()
    {
        //si le AI est activé
        if (agent.enabled)
        {

            //pour chaque joueur
            foreach (GameObject joueur in lesJoueurs)
            {
                //calculer la distance entre le joueur et l'ennemi
                float distance = Vector3.Distance(transform.position, joueur.transform.position);

                //vérifier si le joueur est visible par l'ennemi, donc présent dans sa zone de vision
                joueurVisible = Physics.CheckSphere(transform.position, zoneVision, coucheJoueur);
                //vérifier si le joueur est attaquable par l'ennemi en mélée, donc présent dans sa zone de mélée
                joueurAttaquableMelee = Physics.CheckSphere(transform.position, zoneAttaqueMelee, coucheJoueur);
                //vérifier si le joueur est attaquable par l'ennemi a distance, donc présent dans sa zone de distance
                joueurAttaquableDistance = Physics.CheckSphere(transform.position, zoneAttaqueDistance, coucheJoueur);

                //si le joueur n'est pas visible et pas attaquable, patrouiller
                if (!joueurVisible && !joueurAttaquableMelee) Patrouiller();
                //si le joueur est visible mais pas assez proche pour attaquer en mélée, suivre le joueur
                if (joueurVisible && !joueurAttaquableMelee) SuivreJoueur(joueur.transform.position);

                if (refDistance != null)
                {//si le joueur est visible et assez près pour attaquer a distance, attaquer le joueur
                    
                    if (joueurVisible && !joueurAttaquableMelee && joueurAttaquableDistance) AttaquerJoueurDistance(joueur.transform.position);
                }

                if (refMelee != null)
                {  
                     //si le joueur est visible et assez près pour attaquer en mélée, attaquer le joueur
                    if (joueurVisible && joueurAttaquableMelee) AttaquerJoueurMelee(joueur.transform.position);
                }

            }
        }

    }


    void Patrouiller()
    {
        //si aucun point de patrouille n'est actif, chercher un point de patrouille
        if (!pointPatrouilleActif) ChercherPointPatrouille();

        //si le point de patrouille est actif, bouger vers le point
        if (pointPatrouilleActif)
            agent.SetDestination(pointPatrouille);

        // calculer la distance restante au point de patrouille
        Vector3 distanceAuPointPatrouille = transform.position - pointPatrouille;

        //si on atteint le point de patrouille, désactiver le point de patrouille pour en refaire un nouveau
        if (distanceAuPointPatrouille.magnitude < 1f)
            pointPatrouilleActif = false;
    }

    //chercher un point de patrouille aléatoire dans la zone de patrouille
    void ChercherPointPatrouille()
    {
        //obtnier une position x et z aléatoire dans la zone de patrouille
        float zAleatoire = Random.Range(-zonePatrouille, zonePatrouille);
        float xAleatoire = Random.Range(-zonePatrouille, zonePatrouille);

        //définir un nouveau point de patrouille dans la zone de patrouille selon les poisionts x et z obtenues
        pointPatrouille = new Vector3(transform.position.x + xAleatoire, transform.position.y, transform.position.z + zAleatoire);

        //si le point de patrouille est valide, activer le "flag" qui avertis qu'il est disponible a utiliser
        if (Physics.Raycast(pointPatrouille, -transform.up, 2f, coucheSol))
            pointPatrouilleActif = true;
    }

    //suivre le joueur
    void SuivreJoueur(Vector3 positionJoueur)
    {
        agent.SetDestination(positionJoueur);
    }


    //a modifier pour relier avec le systeme de combat melee
    void AttaquerJoueurMelee(Vector3 positionJoueur)
    {
        agent.SetDestination(transform.position);

        //intégrer le script d'attaque ici 
        refMelee.attaque();
    }

    //a modifier pour relier avec le systeme de combat a distance
    void AttaquerJoueurDistance(Vector3 positionJoueur)
    {
        agent.SetDestination(transform.position);

        //intégrer le script d'attaque ici 
        refMelee.attaque();

    }

    //permet de visualiser dans unity les zones qu'on a défini pour la vision et l'attaque
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, zoneAttaqueMelee);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, zoneAttaqueDistance);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, zoneVision);
    }
}
