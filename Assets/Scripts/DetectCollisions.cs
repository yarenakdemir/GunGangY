using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class DetectCollisions : MonoBehaviour
{
    private int _boxHealth=5;
    public GameObject playerPrefab;
    public GameObject parentGameObject;
    public TextMeshPro displayNumber;
    private float RandomZ=0.5f;


    // Start is called before the first frame update
    void Start()
    {
        _boxHealth = Random.Range(2, 6);
        displayNumber.text = _boxHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer==Layers.Bullet) {
            BulletCollision();
            Destroy(other.gameObject); 
        }
        
    }

    private void BulletCollision()
    {
        _boxHealth -= 1;
        if (_boxHealth == 0)
        {

            if (transform.childCount > 1)
            {

                var newGameObject = Instantiate(playerPrefab, new Vector3(parentGameObject.transform.position.x,parentGameObject.transform.position.y,Random.Range(-RandomZ,RandomZ)), playerPrefab.transform.rotation);
                newGameObject.transform.parent = parentGameObject.transform;

            }
            Destroy(gameObject);
        }
        else
        {
            displayNumber.text = _boxHealth.ToString();
        }
    }


}


