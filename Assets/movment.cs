using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movment : MonoBehaviour
{
    public Rigidbody2D rbody;
    public float force = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //AddForce
        //.velocety
        //( MovePosition() )

        //AddTorque
        //.angularVelocity
        //( MoveTotation() )
    }

    void FixedUpdate()
    {
        // startar spelet på Level0 om man trycker på R
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Level0");
        }
        // ger Movement till player
        if(Input.GetKeyDown(KeyCode.Space))
        {
        rbody.AddForce(new Vector2(force, 0f), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rbody.AddForce(new Vector2(-force, 0f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rbody.AddForce(new Vector2(force, 0f));
        }
        if (Input.GetKey(KeyCode.W))
        {
            rbody.AddForce(new Vector2(0f, force));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rbody.AddForce(new Vector2(0f, -force));
        }

    }
    // Enter
    // Exit
    // Stay
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Hit!");
        SceneManager.LoadScene("Level0");
    }
}