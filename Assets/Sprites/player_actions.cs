using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_actions : MonoBehaviour
{

    public KeyCode fireBtn;
    public GameObject bullet;
    public float speed = 0.5f;
    public float shotDelay = 0.3333f;

    private float timestamp;

    void FixedUpdate () {
        transform.Translate(
                Input.GetAxis("Horizontal")*speed,
                Input.GetAxis("Vertical") * speed,
                0f
            );

        // Block X Movement
        if (transform.position.x <= -8f)
        {
            transform.Translate(speed, 0f, 0f);
        }
        else if (transform.position.x >= 8f)
        {
            transform.Translate(-speed, 0f, 0f);
        }

        // Y axis
        if (transform.position.y <= -4.3f)
        {
            transform.Translate(0f, speed, 0f);
        }
        else if (transform.position.y >= 4.3f)
        {
            transform.Translate(0f, -speed, 0f);
        }

        if (Time.time >= timestamp && Input.GetKeyDown(fireBtn))
        {
            Instantiate(bullet, transform.position, transform.rotation);
            timestamp = Time.time + shotDelay;
        }
    }
}
