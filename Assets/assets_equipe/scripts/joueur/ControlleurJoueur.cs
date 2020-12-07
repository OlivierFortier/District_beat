using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Olivier Fortier pour la basse
//Thomas Lorenzo pour les modifications des inputs
// script de controle de base du joueur. Mouvement, boutons pour effectuer des actions, esquive, etc
public class ControlleurJoueur : MonoBehaviour
{

     [SerializeField]
    private int IndexJoueur =0;


    public MenuControle obj_MenuControle;

    //référence au controlleur de personnage jouables
    public CharacterController controller;

    //référence au transform qu'on utilise pour vérifier si le personnage touche le sol
    public Transform toucheSol;
    public float distanceSol = 0.8f;

    //pour assurer que le "check" se fasse seulement sur le sol et non autre chose comme le body du joueur
    public LayerMask masqueSol;

    //booléen pour valider si le personnage touche au sol
    bool estAuSol;

    //variable pour controler le délai entre les esquives
    public float delaiEsquive = 1f;

    //variable pour calculer le temps écoulé entre chaque esquive
    private float timerEsquive = 0;

    public float dureeEsquive = 0.5f;

    private float timerDureeEsquive = 0;

    //variable pour controler la vitesse de base du personnage
    public float vitesseDeBase = 10f;

    //référence à la vitesse actuellement expériencée par le personnage
    public float vitesseActuelle;

    //variable pour controler la gravité du personnage. par défaut égale à la terre.
    public float gravite = -9.81f;

    //référence à la vélocité du personnage
    Vector3 velocite;

    // input vecteur 2
    Vector2 InputVector = Vector2.zero;

    //temps pour adoucir quand le personnage tourne
    public float tempsTournerSmooth = 0.1f;
    //variable pour calcul de la vélocité du "tour" du personnage
    float turnSmoothVelocity;

    //référence à l'animator pour controller les animations du personnage
    private Animator animateur = null;

    // référence au systeme de combat melee
    public CombatMelee refMelee;
    // référence au systeme de combat distance
    public CombatDistance refDistance;


    //aller chercher le composant animator du personnage au départ.
    void Start()
    {
        // activer l'animator si on en possède un
        if (GetComponentInChildren<Animator>() != null) animateur = GetComponentInChildren<Animator>();




        // configuration de la vitesse de base
        vitesseActuelle = vitesseDeBase;

    }

    void Update()
    {
        bool estMort = GetComponent<healthBarController>().estMort;
        if (!estMort)
        { //faire écouler le temps pour l'esquive
            if (timerEsquive > 0)
            {
                timerEsquive -= Time.deltaTime;
            }

            //faire écouler le temps pour la durée d'une esquive
            if (timerDureeEsquive > 0)
            {
                timerDureeEsquive -= Time.deltaTime;
            }


            
                // selon si le systeme de distance ou de mélée est activée, attaque de cette facon
                

            
            Bouger();
           
        }
    }

    /// <summary>
    /// Méthode pour faire bouger le personnage joueur selon les touches activées
    /// </summary>

       public int GetPlayerIndex(){
        return IndexJoueur;
    }

    public void SetInputVector(Vector2 LesDirections){

        InputVector=LesDirections;

    }

    public void AttaqueDistance(){
        refDistance.Attaque();

    }

     public void AttaqueMelee(){
        refMelee.Attaque();

    }

    private void Bouger()
    {

        //on prends la vitesse de base pour faire bouger le joueur
        float vitesse = vitesseActuelle;

        //vérifier si le personnage touche au sol
        estAuSol = Physics.CheckSphere(toucheSol.position, distanceSol, masqueSol);

        //si il est au sol, et que la gravité l'affecte, réajuster sa vélocité à une valeur qui ne dérange pas le mouvement
        if (estAuSol && velocite.y < 0)
        {
            velocite.y = -2f;
        }


        //calcul de la direction du personnage selon le input horizontal et vertical
        Vector3 direction = new Vector3(InputVector.x, 0f, InputVector.y).normalized;

        //activer l'animation de marche si on bouge
        if (animateur != null) animateur.SetFloat("vitesse", direction.magnitude);

        //si on détecte une touche
        if (direction.magnitude >= 0.1f)
        {
            //calculer l'angle pour tourner dans la bonne direction
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;

            //appliquer une "douceur" lorsque le personnage tourne
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, tempsTournerSmooth);
            //changer la direction
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            //faire bouger le personnage
            controller.Move(direction * vitesse * Time.deltaTime);


        }
        //calculer la vélocité
        velocite.y += gravite * Time.deltaTime;
        //faire bouger 
        controller.Move(velocite * Time.deltaTime);
    }

    /// <summary>
    /// Méthode pour faire esquiver le joueur lorsqu'il appuie sur un bouton
    /// 
    /// Retourne la vitesse 
    /// </summary>
    public void Esquiver(float vitesseEsquive, float tempsEsquive)
    {

        // déclenche l'animation d'esquive
        animateur.SetTrigger("roulade");
        //augmenter la vitesse du joueur
        vitesseActuelle = vitesseEsquive;

        //commencer le cooldown entre la prochaine esquive
        timerEsquive = delaiEsquive;

        Invoke("RemettreVitesseDeBase", tempsEsquive);

    }

    public void roulade(){
      //si on appuie sur la touche d'esquive

            //si le cooldown de l'esquive est prêt
            if (timerEsquive <= 0)
            {
                Esquiver(25f, 0.5f);
            }
    }
  
        

    public void AugmenterVitesseDeBase(float vitesse, float temps)
    {
        vitesseActuelle += vitesse;
        Invoke("RemettreVitesseDeBase", temps);
    }

    public void RemettreVitesseDeBase()
    {
        vitesseActuelle = vitesseDeBase;
    }

    // permet de changer de mélée à distance et vice versa
    public void ChangerArme()
    {

        if (refDistance.enabled)
        {
            refDistance.enabled = false;
            refMelee.enabled = true;
        }
        else if (refMelee.enabled)
        {
            refMelee.enabled = false;
            refDistance.enabled = true;
        }

    }
      private void OnEnable(){
         obj_MenuControle.Enable();
    }

   
    private void OnDisable(){
        obj_MenuControle.Disable();
         
    }        

}
