using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public PlayerMove movement;
    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        Debug.Log(collisionInfo.gameObject.name);
        if(collisionInfo.gameObject.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
    

}
