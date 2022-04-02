using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    AudioSource coinAudioSource;
    [SerializeField] AudioClip collect;
    public Animator anim;
    public float moveSpeed;
    float moveInput;
    Rigidbody2D rb2d;
    float scaleX;
    public float JumpForce = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        scaleX = transform.localScale.x;

        coinAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
          moveInput = Input.GetAxisRaw("Horizontal");
          anim.SetFloat("Speed", Mathf.Abs(moveInput));

          Jump();
          Move(); 

    }
    void Source()
    {
        if (!coinAudioSource.isPlaying)
        {
            coinAudioSource.PlayOneShot(collect);
        }

        else
        {
            coinAudioSource.Stop();
        }

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("Lv1");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
            Source();
        }
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
            transform.Translate(Vector3.up * JumpForce * Time.deltaTime);
            anim.SetBool("IsJumping",true);

        }
        else
        {
            anim.SetBool("IsJumping", false);
        }
        
       
       
       
        

    }

    


}
