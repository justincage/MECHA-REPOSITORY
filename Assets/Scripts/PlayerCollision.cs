using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    // Makes a playermovement script object that you drag in
    public PlayerMovement movement;

    public Transform road1;

    public Transform road2;

   

    // Once the player object collides with another object do this
    void OnControllerColliderHit(ControllerColliderHit collisionInfo)
    {
        // If the player collides with a GameObject possessing an OBSTACLE tag, do this
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("hit obstacle"); // log file stating the obstacle was hit

            // Finds the GameManager script and calls its EndGame() function
            FindObjectOfType<GameManager>().EndGame();
            
            
        }

    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Map")
        {
            Instantiate(road1, new Vector3(0f, 0f, other.transform.parent.position.z+200f),road2.rotation);
            road1.transform.gameObject.AddComponent<DestroyTimer>();
        }

        if (other.tag == "Map2")
        {
            Instantiate(road2, new Vector3(0f, 0f, other.transform.parent.position.z+200f), road1.rotation);
            

        }
        
    }
}
