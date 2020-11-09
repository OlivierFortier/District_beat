using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlleurJoueur : MonoBehaviour
{
    //vitesse de deplacement du joueur
    // private float laVitesse;
    //public statistiqueJoueur referenceStats;  

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

    //temps pour adoucir quand le personnage tourne
    public float tempsTournerSmooth = 0.1f;
    //variable pour calcul de la vélocité du "tour" du personnage
    float turnSmoothVelocity;

    //référence à l'animator pour controller les animations du personnage
    private Animator animateur = null;

    public CombatMelee refMelee;
    public CombatDistance refDistance;


    //détermine les types de touches/contrôles (2 pour l'instant)
    public enum enumTypeTouches
    {
        WASD,
        IJKL
    };

    //liste des touches verticales et horizontales
    private string[] axeTouches = new string[3];

    //faire afficher la liste des touches dans l'inspecteur
    public enumTypeTouches typeTouches;


    //aller chercher le composant animator du personnage au départ.
    void Start()
    {


        // laVitesse = GetComponent<statistiqueJoueur>().vitesseJoueur;
        //laVitesse = referenceStats.vitesseJoueur;


        if (GetComponentInChildren<Animator>() != null) animateur = GetComponentInChildren<Animator>();


        //on détermine le type de touches dans le input manager selon le choix dans l'inspecteur
        switch (typeTouches)
        {
            case enumTypeTouches.WASD:
                axeTouches[0] = "Horizontal";
                axeTouches[1] = "Vertical";
                axeTouches[2] = "Esquive";
                break;

            case enumTypeTouches.IJKL:
                axeTouches[0] = "2_Horizontal";
                axeTouches[1] = "2_Vertical";
                axeTouches[2] = "2_Esquive";
                break;
        }

        vitesseActuelle = vitesseDeBase;

    }

    void Update()
    {
        //faire écouler le temps pour l'esquive
        if (timerEsquive > 0)
        {
            timerEsquive -= Time.deltaTime;
        }

        //faire écouler le temps
        if (timerDureeEsquive > 0)
        {
            timerDureeEsquive -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // refMelee.attaque();
                refDistance.attaque();

        }

        Bouger();
    }

    /// <summary>
    /// Méthode pour faire bouger le personnage joueur selon les touches activées
    /// </summary>
    private void Bouger()
    {
        //si on appuie sur la touche d'esquive
        if (Input.GetAxis(axeTouches[2]) >= 0.1f)
        {
            //si le cooldown de l'esquive est prêt
            if (timerEsquive <= 0)
            {
                Esquiver(25f, 0.5f);
            }
        }
        //on prends la vitesse de base pour faire bouger le joueur
        float vitesse = vitesseActuelle;

        //vérifier si le personnage touche au sol
        estAuSol = Physics.CheckSphere(toucheSol.position, distanceSol, masqueSol);

        //si il est au sol, et que la gravité l'affecte, réajuster sa vélocité à une valeur qui ne dérange pas le mouvement
        if (estAuSol && velocite.y < 0)
        {
            velocite.y = -2f;
        }

        //on assigne les touches et on les détectes
        float horizontal = Input.GetAxis(axeTouches[0]);
        float vertical = Input.GetAxis(axeTouches[1]);

        //calcul de la direction du personnage selon le input horizontal et vertical
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

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
    private void Esquiver(float vitesseEsquive, float tempsEsquive)
    {
        //déclencher l'animation de dodge
        //TODO
        animateur.SetTrigger("roulade");
        //augmenter la vitesse du joueur
        vitesseActuelle = vitesseEsquive;

        //commencer le cooldown entre la prochaine esquive
        timerEsquive = delaiEsquive;

        Invoke("RemettreVitesseDeBase", tempsEsquive);

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

}
