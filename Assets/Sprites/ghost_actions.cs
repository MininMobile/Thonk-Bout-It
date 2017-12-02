using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost_actions : MonoBehaviour
{
    public GameObject bullet;
    public float speed = -0.1f;

    void Start()
    {
        StartCoroutine(shoot());
    }

    private IEnumerator shoot()
    {
        yield return new WaitForSeconds(Random.Range(0.2f, 0.5f));
        Instantiate(bullet, transform.position, transform.rotation);
    }

    void Update() {
        transform.Translate(speed, 0f, 0f);
        if (transform.position.x <= -9f)
        {
            Die();
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "player_bullet")
        {
            print(c.gameObject.tag);
            c.SendMessage("shot");
            Die();
        }
    }

    void Die() { Object.Destroy(this.gameObject); }
}