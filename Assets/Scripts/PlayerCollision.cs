using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

    // Makes a playermovement script object that you drag in
    public PlayerMovement movement;

    public Transform player;

    public Transform[] roads;

    

    private int [] num = {0, 1, 2, 3, 4};

    private float random;

    private void Start()
    {
        
    }


    void Update()
    {
        random = (int)(Random.Range(1f, 2f));
    }


    // Once the player object collides with another object do this
    void OnControllerColliderHit(ControllerColliderHit collisionInfo)
    {
        // If the player collides with a GameObject possessing an OBSTACLE tag, do this
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("hit obstacle"); // log file stating the obstacle was hit

            movement.StopMoving();

            // Finds the GameManager script and calls its EndGame() function
            Invoke("End", 1);

            


        }

    }

    void End()
    {
        // FindObjectOfType<GameManager>().EndGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void OnTriggerEnter(Collider other)
    {

        // If player distance is sub 2000 do this
        if (other.tag == "Map")
        {
            Instantiate(roads[1], new Vector3(0f, 0f, other.transform.parent.position.z + 200f), roads[1].rotation);

        }
        if(other.tag == "Map2")
        {
            Instantiate(roads[0], new Vector3(0f, 0f, other.transform.parent.position.z + 200f), roads[0].rotation);


        }
        // If player distance is greater than 2000 but less than 4000 do this

        // If player distance is greater than 4000 but less than 6000 do this
    }
}
