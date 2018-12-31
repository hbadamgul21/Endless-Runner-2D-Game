using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContorller : MonoBehaviour
{
    public float enemySpeed;

    public bool Isgrounded;
    public LayerMask enemyWhatIsGround;

    public GameManager GM;

    public AudioSource jumpS, deadS;

    private Collider2D enemyCollider;
    private Rigidbody2D enemyRGB;
    private Animator enemyAnim;

    // Start is called before the first frame update
    void Start()
    {
        enemyRGB = GetComponent<Rigidbody2D>();
        enemyAnim = GetComponent<Animator>();
        enemyCollider = GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Isgrounded = Physics2D.IsTouchingLayers(enemyCollider, enemyWhatIsGround);

        enemyRGB.velocity = new Vector2(enemySpeed, enemyRGB.velocity.y);


        enemyAnim.SetFloat("Speed", enemyRGB.velocity.x);
        enemyAnim.SetBool("Grounded", Isgrounded);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "platformTOP")
        {
            enemyRGB.AddForce(new Vector2(0, 17), ForceMode2D.Impulse);
            jumpS.Play();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "KillBar")
        {
            GM.RestartGame();
            deadS.Play();
        }
        
    }
}
