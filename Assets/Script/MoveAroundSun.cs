using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAroundSun : MonoBehaviour
{

    [SerializeField] private Transform sun;
    public float speed ;
    public float baseSpeed ;


    private Vector3 pivot; 

    void Start(){
        pivot = new Vector3(sun.position.x, sun.position.y, sun.position.z);
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
