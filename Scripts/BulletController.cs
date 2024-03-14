using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody2D myrigidbody2D;
    public float bulletSpeed = 10f;
    public GameManager myGameManager;

    void Start()
    {
         myrigidbody2D = GetComponent<Rigidbody2D>();
       // myGameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        myrigidbody2D.velocity = new Vector2(bulletSpeed, myrigidbody2D.velocity.y);
    }
        void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ItemBad"))
        {
            Debug.Log("Si entra");
            myGameManager.AddScore();
            Destroy(this.gameObject); // Destruye la bala
            Destroy(collision.gameObject);
        }
    }
}