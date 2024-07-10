
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 velocity= new Vector2(-1f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;

    }

    // Update is called once per frame
    void Update()
    {
        moveEnemy();
    }

    private void moveEnemy()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

    }
}
