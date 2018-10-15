using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingWall : MonoBehaviour
{
    public float xspeed;
    public float zspeed;
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0, 0, zspeed * Time.deltaTime);
        transform.Rotate(xspeed * Time.deltaTime, 0, 0);

    }
}
