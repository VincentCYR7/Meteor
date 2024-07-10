using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float life = 3;
    public GameController con;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(collision.gameObject);
        con.IncreaseScore();
        Destroy(gameObject);
    }

}
