using System;
using UnityEngine;
using System.Collections;
using Cinemachine;
using UnityEngine.Animations;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(7, 5, 0);
    
 
    void Start()
    {
  
    }
    
    void Update ()
    {
        
        
    }

    private void LateUpdate()
    {
            transform.position = player.transform.position + offset;

    }
}