using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScPlayerController : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public Animator animator;

    private float movementSpeed = 5.0f;
    public GameObject RedPotion;
    public GameObject RedMagic;
    public GameObject PurplePotion;
    public GameObject PurpleMagic;
    public GameObject FirePotion;
    public GameObject FireMagic;


    private float h_Input;
    private float v_Input;
    
    
    
    
    void Awake()
    {
        playerRB = this.GetComponent<Rigidbody2D>();
    }

    void Start()
    {
    
  
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update time: " + Time.deltaTime);
        CheckInput();
        animator.SetFloat("Horizontal", h_Input);
        animator.SetFloat("Vertical", v_Input);
        animator.SetFloat("Speed", playerRB.velocity.sqrMagnitude);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided with " + collision.gameObject.name);

        if (collision.gameObject.name == "RedPotion(Clone)") {
            RedMagic.SetActive(true);
            PurpleMagic.SetActive(false);
            FireMagic.SetActive(false);
        }

        if (collision.gameObject.name == "PurplePotion(Clone)") {
            PurpleMagic.SetActive(true);
            RedMagic.SetActive(false);
            FireMagic.SetActive(false);
        }
         if (collision.gameObject.name == "FirePotion(Clone)") {
            FireMagic.SetActive(true);
            RedMagic.SetActive(false);
            PurpleMagic.SetActive(false);
        }
        
    }

    void FixedUpdate()
    {
        //Debug.Log("Fixed Update time: " + Time.deltaTime);
        ApplyMovement();
    }
    void ApplyMovement()
    {
        playerRB.velocity = new Vector2( h_Input * movementSpeed , v_Input * movementSpeed );

    }
    void CheckInput()
    {
        h_Input = Input.GetAxis("Horizontal");
        v_Input = Input.GetAxis("Vertical");
    }
}
