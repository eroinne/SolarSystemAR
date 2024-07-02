using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometTraveling : MonoBehaviour
{    public Vector3 startLocation = new Vector3(6878f, 3993f, -741f); // Position de départ
    public Vector3 endLocation = new Vector3(-7019f, -695f, 2924f); // Position d'arrivée
    public float speed = 1.0f; // Vitesse de déplacement

    private float journeyLength;
    private float startTime;
    private bool isMoving = false;

    void OnEnable()
    {
        // Calculer la distance totale du trajet
        journeyLength = Vector3.Distance(startLocation, endLocation);
        startTime = Time.time; // Enregistrez le temps au début
        isMoving = true;
    }

    void OnDisable()
    {
        isMoving = false;
    }

    void Update()
    {
        // Vérifier si l'objet est actif avant de mettre à jour la position
        if (isMoving)
        {
            // Calculez combien de temps s'est écoulé depuis le début du mouvement
            float distCovered = (Time.time - startTime) * speed;

            // Calculez le ratio du trajet complété
            float fractionOfJourney = distCovered / journeyLength;

            // Interpolation linéaire entre les points de départ et d'arrivée
            transform.position = Vector3.Lerp(startLocation, endLocation, fractionOfJourney);

            // Si le trajet est terminé, réinitialisez le temps de début pour un nouveau mouvement
            if (fractionOfJourney >= 1.0f)
            {
                startTime = Time.time;
                Vector3 temp = startLocation;
                startLocation = endLocation;
                endLocation = temp;
            }
        }
    }
}



     
