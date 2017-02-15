using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public DeadZone deadZone;

    public float speed = 50f;

    // Use this for initialization
    void Start ()
    {
        float shootX = Input.GetAxis("xShoot");
        float shootY = Input.GetAxis("yShoot");

        if (shootX > deadZone.posZone)
        {
            shootX = speed;
        }

        if (shootX < deadZone.negZone)
        {
            shootX = -speed;
        }

        if (shootY > deadZone.posZone)
        {
            shootY = speed;
        }

        if (shootY < deadZone.negZone)
        {
            shootY= -speed;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2 (shootX, shootY);

        StartCoroutine(despawnTime());
    }
	
	// Update is called once per frame
	void Update () {
       
    }

    IEnumerator despawnTime()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
