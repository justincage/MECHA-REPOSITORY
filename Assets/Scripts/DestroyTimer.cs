using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour {

    private float currentTime;
    public float destroyTime = 6f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        currentTime += Time.deltaTime;

        if (currentTime > destroyTime)
        {
            Destroy(gameObject);
            
        }

	}
}
