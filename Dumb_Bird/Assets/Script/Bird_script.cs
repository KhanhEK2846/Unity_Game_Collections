using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_script : MonoBehaviour
{

    private Rigidbody2D rb;
    private float strenght = 5;
    private float yHeight = 0;
    private Logic_Script logic;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameObject.name = "Flappy";
        yHeight = transform.localPosition.y;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space)){
            rb.velocity =  Vector2.up * strenght;
        }

        if(yHeight < transform.localPosition.y){ //Fly

            transform.rotation = new Quaternion(transform.rotation.x,transform.rotation.y,(float)0.1305262,transform.rotation.w);

        }else if (yHeight > transform.localPosition.y){ //Fall
            transform.rotation = new Quaternion(transform.rotation.x,transform.rotation.y,(float)-0.1305262,transform.rotation.w);
        }
        yHeight = transform.localPosition.y;

    }

    private void OnCollisionEnter2D(Collision2D other) {
        logic.overGame();
    }
}
