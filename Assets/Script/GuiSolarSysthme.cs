using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiSolarSysthme : MonoBehaviour
{
    [SerializeField] private GameObject[] planets;


   
     [SerializeField] private GameObject comet;
    // Start is called before the first frame update

    private bool isCometActive = false; // Indique si la comete est active ou non

    private bool siVitesseFromSlider = false ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    { 
        //slider pour modifer la vitesse de toute les planete en une seulle fois
        float speed = GUI.HorizontalSlider(new Rect(10, 10, 200, 50), planets[0].GetComponent<MoveAroundSun>().speed, 0.0f, 100.0f);
       if(siVitesseFromSlider){
        for (int i = 0; i < planets.Length; i++)
        {
            planets[i].GetComponent<MoveAroundSun>().speed = speed;
        }
        //boutton pour reset la vitesse de toute les planete en une seulle fois
        if (GUI.Button(new Rect(10, 50, 200, 50), "Reset vitesse"))
        {
            for (int i = 0; i < planets.Length; i++)
            {
                planets[i].GetComponent<MoveAroundSun>().speed = planets[i].GetComponent<MoveAroundSun>().baseSpeed ;
            }
        }
       }

        //boutton pour activer la comet 
        if (GUI.Button(new Rect(10, 120, 200, 50), "Comète"))
        {
            if (isCometActive)
            {
                isCometActive = false;
                comet.GetComponent<CometTraveling>().enabled = false;
            }
            else
            {
                isCometActive = true;
                comet.GetComponent<CometTraveling>().enabled = true;
            }
        }

        //button pour activer le changement de vitesse du slider
        if (GUI.Button(new Rect(10, 180, 200, 50), "Changer vitesse"))
        {
            siVitesseFromSlider = !siVitesseFromSlider;
        }
        

        

    }
}
