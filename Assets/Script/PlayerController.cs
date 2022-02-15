using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //ball object prefab
    public GameObject projectilePrefab;

    //movemeant input variable
    public float horizontalInput;

    //movemeant speed
    public float speed = 10.0f;
    //Player boundars variabe
    public float xRange = 13; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //keep player to bounds
        if(transform.position.x <-xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Player movemeant controls
        horizontalInput =  Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Player shot input
        if (Input.GetKeyDown(KeyCode.Space))
        {
        // Launch a projectile from the player
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
