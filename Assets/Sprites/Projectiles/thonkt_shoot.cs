using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thonkt_shoot : MonoBehaviour {

    public float speed = 1f;

    void Update() {
        transform.Translate(speed, 0f, 0f);
        if (transform.position.x >= 9f && gameObject.tag == "player_bullet") {
            Object.Destroy(this.gameObject);
        }
        else if (transform.position.x <= -9f && gameObject.tag == "enemy_bullet")
        {
            Object.Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag.EndsWith("bullet"))
        {
            c.SendMessage("shot");
            shot();
        }
    }

    void shot() { Object.Destroy(this.gameObject); }
}
