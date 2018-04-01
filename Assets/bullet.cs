using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    private float timer = 0.0f;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > 4.0f)
        {
            Destroy(gameObject);
        }
    }
}
