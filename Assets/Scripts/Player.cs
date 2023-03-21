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
    private Rigidbody2D myBody;
    private SpriteRenderer sr;
    private Animator anim;
    private string WALK_ANIMATION = "Walk";

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

        // Platform dependent Mobile -> screen touch, PC -> Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}
