using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorChange : MonoBehaviour
{

    void OnCollisionEnter(Collision other) 
     {
         if(other.gameObject.tag=="Interactable")
         {
            Debug.Log ("Collision Happened");

            if (other.GetComponent<Renderer>().material.color == Color.red){
                other.GetComponent<Renderer>().material.color = Color.green;
            }

            if (other.GetComponent<Renderer>().material.color == Color.red){
                other.GetComponent<Renderer>().material.color = Color.green;
            }
            
            else
            {
                other.GetComponent<Renderer>().color = Color.red; //assigns color on first collision
            }
         }
     }
}
