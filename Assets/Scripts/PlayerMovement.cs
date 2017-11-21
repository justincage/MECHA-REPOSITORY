using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float sidewaysVelocity;
    private float sideMove;

    public float forwardVelocity;

    public Camera cam;

    public Animator anim;

    private CharacterController controller;

    private float verticalVelocity;
    private float gravity = 17.0f;
    private float jumpForce = 11.0f;
    
    
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Unity likes FixedUpdate more than Update with Physics based interactions
    void FixedUpdate ()
    {

        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;

            if (Input.GetKey(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
                anim.Play("JumpAnim", -1, 0f);
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        Vector3 moveVector = new Vector3(sideMove, verticalVelocity, 60);

        if (cam.transform.rotation.z > .015)
        {
            sideMove = -sidewaysVelocity * (cam.transform.rotation.z);
        }
        if (cam.transform.rotation.z < -.015)
        {
            sideMove = sidewaysVelocity * -(cam.transform.rotation.z);
        }
        
        

        
       
        controller.Move(moveVector * Time.deltaTime );
        //rb.AddForce(0f, 0f, forwardForce*Time.deltaTime);

        

        
       
    }
}
