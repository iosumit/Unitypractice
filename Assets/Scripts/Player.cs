using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 11f;
    private float movementX;
    private bool isGrounded = true;
    private bool isJumped = false;
    private Rigidbody2D myBody;
    private SpriteRenderer sr;
    private Animator anim;
    private string WALK_ANIMATION = "Walk";
    private string GROUND_TAG = "Ground";
    private string ENEMY_TAG = "Enemy";

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()   // Called every frame if monobehaviour enabled
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
    }
    private void FixedUpdate()  // Called every fixed frame rate 
    {
        PlayerJump();
    }
    void PlayerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;

        // Platform dependent Mobile -> screen touch, PC -> Space
        if (!isJumped && Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumped = true;
        }
    }
    void AnimatePlayer()
    {
        if (movementX > 0)
        {
            //  moving right
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }
        else if (movementX < 0)
        {
            //  moving left
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;
        }
        else
        {
            //  not moving 
            anim.SetBool(WALK_ANIMATION, false);
        }
    }
    void PlayerJump()
    {
        if (isJumped && isGrounded)
        {
            isJumped = false;
            isGrounded = false;
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG))
            isGrounded = true;
        if (collision.gameObject.CompareTag(ENEMY_TAG))
        {
            Destroy(gameObject);
        }
    }
    // private void OnTriggerEnter2D(Collider2D collider)
    // {
    //     if (collider.CompareTag(ENEMY_TAG))
    //     {
    //         Destroy(gameObject);
    //     }
    // }
}
