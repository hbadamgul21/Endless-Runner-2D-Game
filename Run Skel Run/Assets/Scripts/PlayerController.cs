using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;

	private Rigidbody2D rgb;

    public bool Isgrounded;
    public LayerMask whatIsGround;

    public GameManager GM;

    public AudioSource jumpSound, deadSound;

    private Collider2D myCollider;

    private Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Isgrounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

        rgb.velocity = new Vector2(moveSpeed, rgb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Isgrounded)
            {
                rgb.AddForce(new Vector2(0, 17), ForceMode2D.Impulse);
                jumpSound.Play();
            }
        }

        Anim.SetFloat("Speed", rgb.velocity.x);
        Anim.SetBool("Grounded", Isgrounded);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "KillBar")
        {
            GM.RestartGame();
            deadSound.Play();
        }

        if(collision.collider.tag == "EnemyAI")
        {
            GM.RestartGame();
            deadSound.Play();
        }
    }
}
