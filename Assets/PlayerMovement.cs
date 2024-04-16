using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   private Rigidbody2D rigidBody;
   
    // Start is called before the first frame update
  private  void Start()
    {
        // Debug.Log("Hello World");
        rigidBody=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
   private void Update()
    {


        float directionX=Input.GetAxis("Horizontal");
        rigidBody.velocity=new Vector2(directionX*7f,rigidBody.velocity.y);


        // Debug.Log("Hello World per frame ");
        if (Input.GetButtonDown("Jump"))  //to check whether the space key was pressed
        {
            rigidBody.velocity=new Vector2(rigidBody.velocity.x,14f);
        }
    }
}
