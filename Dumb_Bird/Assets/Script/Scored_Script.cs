using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scored_Script : MonoBehaviour
{
    private Logic_Script logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_Script>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other) {
        logic.addScore();

    }
}
