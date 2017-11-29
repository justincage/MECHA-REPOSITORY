using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMovement : MonoBehaviour {

    public GameObject movement;
    public GameObject score;
    public GameObject reticle;

	// Use this for initialization
	void Start ()
    {
        
        movement.SetActive(false);
        score.SetActive(false);
        reticle.SetActive(true);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void StartMove()
    {
        movement.SetActive(true);
        score.SetActive(true);
        reticle.SetActive(false);
    }
}
