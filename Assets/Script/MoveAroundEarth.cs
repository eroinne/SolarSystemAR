using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAroundEarth : MonoBehaviour
{

    [SerializeField] private Transform earth;
    [SerializeField] private float speed = 10f;


    private Vector3 pivot; 

    void Start(){
        pivot = new Vector3(earth.position.x, earth.position.y+50, earth.position.z);
    }



    // Update is called once per frame
    void Update()
    {
        this.rotateAroundSun();
    }


     void rotateAroundSun(){
        this.transform.RotateAround(pivot, Vector3.up, speed * Time.deltaTime);
     }
}
