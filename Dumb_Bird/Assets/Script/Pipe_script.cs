using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_script : MonoBehaviour
{
    // Start is called before the first frame update
    private float deadZone = 19;
    private float speed = (float)4;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed)*Time.deltaTime;

        if (transform.position.x < deadZone){
            Destroy(gameObject);
        }
    }
}
