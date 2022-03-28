using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 10;
    public Rigidbody2D rb;
    float moveInput;
    
    float scaleX;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
       
    }

    void OnTriggerEnter2D(Collider2D hitInfo)

    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);



    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
   
    
}

