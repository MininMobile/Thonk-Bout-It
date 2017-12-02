using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawner : MonoBehaviour
{
    public GameObject ghost;

    private float delay = 0.2f;

    void Start()
    {
        StartCoroutine(spawnEnemies(delay));
    }

    private IEnumerator spawnEnemies(float d)
    {
        Vector2 pos;

        while (true)
        {
            yield return new WaitForSeconds(1);
            pos = new Vector2(9f, -4f);
            for (int i = 1; i < 6; i++)
            {
                pos.y += i / 2f;
                Instantiate(ghost, pos, transform.rotation);
                yield return new WaitForSeconds(d);
            }

            yield return new WaitForSeconds(1);
            pos = new Vector2(9f, 4f);
            for (int i = 1; i < 6; i++)
            {
                pos.y -= i / 2f;
                Instantiate(ghost, pos, transform.rotation);
                yield return new WaitForSeconds(d);
            }
        }
    }
}