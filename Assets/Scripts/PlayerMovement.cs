using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    private float sidewaysVelocity;
    private float sideMove;

    private float forwardVelocity;

    public Camera cam;

    public Animator anim;

    private CharacterController controller;

    private float verticalVelocity;
    private float gravity = 17.0f;
    private float jumpForce = 11.0f;
    private bool gameOver = false;
    
    
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        anim.Play("Intro_Walk", -1, 0f);
        forwardVelocity = 0;
        sidewaysVelocity = 0;
        verticalVelocity = 0;

        Invoke(("SetSpeed"), 3.3f);
 
    }

    // Unity likes FixedUpdate more than Update with Physics based interactions
    void FixedUpdate ()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;

            if (Input.GetKey(KeyCode.Space) && !gameOver)
            {
                verticalVelocity = jumpForce;
                anim.Play("Jump", -1, 0f);
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        Vector3 moveVector = new Vector3(sideMove, verticalVelocity, forwardVelocity);

        if (cam.transform.rotation.z > .015)
        {
            sideMove = -sidewaysVelocity * (cam.transform.rotation.z);
        }
        if (cam.transform.rotation.z < -.015)
        {
            sideMove = sidewaysVelocity * -(cam.transform.rotation.z);
        }

        if (controller.transform.position.y < -1)
        {
            Invoke("End", 1);
            
        }
          
       
        controller.Move(moveVector * Time.deltaTime );
        //rb.AddForce(0f, 0f, forwardForce*Time.deltaTime);
    }

    public void StopMoving()
    {
        Debug.Log("Stop");

        anim.Play("Fall", -1, 0f);

        forwardVelocity = 0;
        sidewaysVelocity = 0;
        jumpForce = 0;
        gameOver = true;
    }

    public void SpeedUp()
    {
        Debug.Log("hit");
        forwardVelocity += 10;
        sidewaysVelocity += 10;
    }

    public void SetSpeed()
    {
        forwardVelocity = 30;
        sidewaysVelocity = 30;

        Invoke(("SpeedUp"), 1f);
    }

    public void End()
    {
        //FindObjectOfType<GameManager>().EndGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    }
