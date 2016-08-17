using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Controller2D))]
public class Player : MonoBehaviour {

    public float maxJumpHeight = 4;
    public float minJumpHeight = 1;
    public float timeToJumpApex = 0.4f;
    float accelerationTimeAirborne = 0.2f;
    float accelerationTimeGrounded = 0.1f;
    public float moveSpeed = 6;

    public Vector2 wallJumpClimb;
    public Vector2 wallJumpOff;
    public Vector2 wallLeap;

    public float wallSlideSpeedMax = 3;
    public float wallStickTime = 0.25f;
    float timeTilWallUnStick;

    float gravity;
    float maxJumpVelocity;
    float minJumpVelocity;
    Vector3 velocity;
    float velocityXSmoothing;

    float X;

    private Animator anim;

    Controller2D controller;
    
    // Use this for initialization
	void Start ()
    {
        controller = GetComponent<Controller2D>();

        gravity = -(2 * maxJumpHeight / Mathf.Pow(timeToJumpApex, 2));
        maxJumpVelocity = Mathf.Abs(gravity) * timeToJumpApex;
        minJumpVelocity = Mathf.Sqrt(2 * Mathf.Abs(gravity * minJumpHeight));
        //print("Gravity: " + gravity + "Jump Velocity: " + maxJumpVelocity);

        X = transform.localScale.x;

        anim = GetComponent<Animator>();

        anim.SetBool("Shooting", false);

    }
	
    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        int wallDirX = (controller.collisions.left) ? -1 : 1;

        float targetVelocityX = input.x * moveSpeed;
        velocity.x = Mathf.SmoothDamp(velocity.x, targetVelocityX, ref velocityXSmoothing, (controller.collisions.below) ? accelerationTimeGrounded : accelerationTimeAirborne);

        // if the player press the key D, the character turns to the right
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 temp = transform.localScale;
            temp.x = X;
            transform.localScale = temp;
        }

        // if the player presses A the character turns to the left 
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 temp = transform.localScale;
            temp.x = -X;
            transform.localScale = temp;
        }

        // if the player presses the right arrow key the character turns to the right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 temp = transform.localScale;
            temp.x = X;
            transform.localScale = temp;
        }

        // if the player presses the left arrow key the character turns to the left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 temp = transform.localScale;
            temp.x = -X;
            transform.localScale = temp;
        }

        anim.SetFloat("Speed", velocity.magnitude);
        //Debug.Log("Velocity: " + velocity.magnitude);
        if(Input.GetMouseButtonDown(0))
        {
            anim.SetBool("Shooting", true);   
        }

        if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("Shooting", false);
        }

        bool wallSliding = false;

        anim.SetBool("Grounded", controller.collisions.below);

        if((controller.collisions.left || controller.collisions.right) && !controller.collisions.below && velocity.y <0)
        {
            wallSliding = true;

            if (velocity.y < - wallSlideSpeedMax)
            {
                velocity.y = - wallSlideSpeedMax;
            }

            if (timeTilWallUnStick > 0)
            {
                velocityXSmoothing = 0;
                velocity.x = 0;

                if (input.x != wallDirX && input.x !=0)
                {
                    timeTilWallUnStick -= Time.deltaTime;
                }  
                  
                else
                {
                    timeTilWallUnStick = wallStickTime;
                }         
            }

            else
            {
                timeTilWallUnStick = wallStickTime;
            }

        }

        if (controller.collisions.above || controller.collisions.below)
        {
            velocity.y = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            if(wallSliding)
            {

                if(wallDirX == input.x)
                {
                    velocity.x = -wallDirX * wallJumpClimb.x;
                    velocity.y = wallJumpClimb.y;
                }

                else if(input.x == 0)
                {
                    velocity.x = -wallDirX * wallJumpOff.x;
                    velocity.y = wallJumpOff.y;
                }

                else
                {
                    velocity.x = -wallDirX * wallLeap.x;
                    velocity.y = wallLeap.y;
                }
            }

            if(controller.collisions.below)
            {
                velocity.y = maxJumpVelocity;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {

            if(velocity.y > minJumpVelocity)
            {
                velocity.y = minJumpVelocity;
            }          
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move (velocity * Time.deltaTime, input);
    }

}
