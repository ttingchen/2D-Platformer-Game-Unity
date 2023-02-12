using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Edit>>Preference>>external tool>>check the first two boxed of VS
        // and then regenerate project to enable auto complete
        Debug.Log("Hello, world!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) // Jump
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 15, 0);
        }
    }
}
