using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelManager : MonoBehaviour
{
    public GameObject level;
    private Camera _mainCamera;
    private Vector3 offset = new Vector3(0, 5, -7);
    public CameraManager cameraManager;
    

    private bool GameOn;

    private void Awake()
    {
        GameOn = false;
    }
  

    void Start()
    {
        Game game = Instantiate(level, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<Game>();
        GameOn = true;
        cameraManager.SetTarget(game._mainPlayer);

    }


    void Update()
    {
        

    }

    private void LateUpdate()
    {
        if (GameOn == true)
        {
             
           // _mainCamera.transform.position = player.transform.position + offset;
        }
    }



}
