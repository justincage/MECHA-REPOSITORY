using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Punching : MonoBehaviour {
    public Collider attackHitboxes;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
    //        LaunchAttack();
            Debug.Log("Punch!");
        }
    }

    /* private void LaunchAttack(Collider col)
     {
         Collider[] cols = Physics.OverlapBox(col.bounds.center, col.bounds.extents, col.transform.rotation, LayerMask.GetMask("Hitbox"));
         foreach (Collider c in cols) {
             //if (c.transform.parent.parent == transform)
               //  continue;
             Debug.Log(c.name);
            // if(col..tag == "Obstacle")
            // {
             //    Destroy(gameObject);

             //}

         }

     }
 }
 */
    void LaunchAttack(Collision collisionInfo) {
        // If the player collides with a GameObject possessing an OBSTACLE tag, do this
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("punch obstacle"); // log file stating the obstacle was hit
                                         //movement.enabled = false; // turns off the PlayerMovement script, removing the force being added to it, and stopping the player
        }


    }
    }