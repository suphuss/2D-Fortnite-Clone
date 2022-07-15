using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 8f;
    [SerializeField]
    private float jumpForce = 11f;

    private float movementX;

    private Rigidbody2D myBody;

    private SpriteRenderer sr;

    private Animator anim;
   // private string WALK_ANIMATION = "walk";

    private bool isGrounded = true;
    private string GROUND_TAG = "Ground";
    public bool resetToggled;
    public GameObject _toggleButton;
    public Animator anime;


    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        //anim = GetComponent<Animator>();
        myBody.freezeRotation = true;
    }

    void Start()
    {
        
    }

    void Update()
    {
           
        PlayerMoveKeyboard();
        FlipPlayer();
        PlayerJump();
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag(GROUND_TAG))
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (anime.enabled == false)
            {
                Application.LoadLevel(1);
            }
            else
            {
                isGrounded = true;
            }
        }
    }

    void PlayerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
        
    }

    void FlipPlayer()
    { 
        if (movementX > 0)
        {
            sr.flipX = false;
        } 
        else if ( movementX < 0)
        {
            sr.flipX = true;
        }
    }

    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }


} //class
