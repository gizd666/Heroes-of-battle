using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour {

    float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            Destroy(gameObject);
        }
    }

}
