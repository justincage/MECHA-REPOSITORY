using System.Collections;
using UnityEngine;

public class Jump : MonoBehaviour {

    [Range(1, 20)]
    public float jumpVelocity;

	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("jump");
            GetComponent<Rigidbody>().velocity = Vector2.up * jumpVelocity;
        }
	}
}
