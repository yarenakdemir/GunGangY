using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed=20;
    private float horizontalInput;
    private bool GameOver = false;
    public GameObject gameOverScreen;
    public GameObject finsihScreen;
    public Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen.SetActive(false);
        finsihScreen.SetActive(false);
        
        playerAnim.SetTrigger("Walk");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*horizontalInput*Time.deltaTime*speed);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == Layers.Cube)
        {
            CubeCollision();
        }

        if (other.gameObject.layer == Layers.FinishLine)
        {
            FinishLineCollision();
            
        }
    }
    private void CubeCollision()
    {
        Debug.Log("You Lost :(");
        gameOverScreen.SetActive(true);
        speed = 0;
        playerAnim.SetTrigger("Standing");
        
     
    }

    private void FinishLineCollision()
    {
        Destroy(gameObject);
        finsihScreen.SetActive(true);
        Debug.Log("You Win!");
    }
    
}
