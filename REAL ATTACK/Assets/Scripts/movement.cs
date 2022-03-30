using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Animator anim;
    public float moveSpeed;
    float moveInput;
    Rigidbody2D rb2d;
    float scaleX;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        scaleX = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        
          moveInput = Input.GetAxisRaw("Horizontal");
          anim.SetFloat("Speed", Mathf.Abs(moveInput));

          Jump();
          Move(); 

    }

    private void FixedUpdate()
    {
       
        
    }

    public void Move()
    {
        Flip();
        rb2d.velocity = new Vector2(moveInput * moveSpeed, rb2d.velocity.y);
    }

    public void Flip()
    {
        if (moveInput > 0)
        {
            transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
        }
        if (moveInput < 0)
        {
            transform.localScale = new Vector3((-1) * scaleX, transform.localScale.y, transform.localScale.z);
        }
        
        
    }

     void Jump()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * 260 * Time.deltaTime);
            anim.SetBool("IsJumping",true);

        }
        else
        {
            anim.SetBool("IsJumping", false);
        }
       
       
        

    }

    


}
