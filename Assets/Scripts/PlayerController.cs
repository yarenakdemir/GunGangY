using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
   
    public GameObject bulletprefab;
    public Transform bulletPosition;
    



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletprefab, bulletPosition.position, bulletprefab.transform.rotation);
        }
    }




   
}
public static class Layers
{
    public const int Player = 7;
    public const int Cube = 9;
    public const int Bullet = 6;
    public const int FinishLine = 10;
    
    

}