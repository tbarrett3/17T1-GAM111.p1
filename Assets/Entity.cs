using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {

    public Boundary boundary;

    public Rigidbody2D rb;

    public GameObject player;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        //Constrain to the boudary)
        rb.position = new Vector2
            (
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax)
            );
    }
}
