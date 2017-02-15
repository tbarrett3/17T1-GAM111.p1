using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin = -29, xMax = 29;
    public float yMin = -14, yMax = 14;
}

[System.Serializable]
public class DeadZone
{
    public float posZone = 0.2f;
    public float negZone = -0.2f;
}


public class PlayerController : MonoBehaviour
{

    public Boundary boundary;

    public DeadZone deadZone;

    public Rigidbody2D rb;

    public float speed = 30f;

    public Transform playerBullet;
    public float fireRate;

    // Use this for initialization
    void Start()
    {
        //Assign rigidbody
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("xMove");
        float moveY = Input.GetAxis("yMove");

        //Move the player
        Vector2 movement = new Vector2(moveX, moveY);
        rb.velocity = movement * speed;

        float shootX = Input.GetAxis("xShoot");
        float shootY = Input.GetAxis("yShoot");

        if (shootX > deadZone.posZone || shootX < deadZone.negZone)
        {
            Instantiate(playerBullet, transform.position, playerBullet.rotation);
        }

        if (shootY > deadZone.posZone || shootY < deadZone.negZone)
        {
            Instantiate(playerBullet, transform.position, playerBullet.rotation);
        }
    }
}