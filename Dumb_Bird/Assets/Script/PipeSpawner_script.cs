using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner_script : MonoBehaviour
{
    public GameObject pipe;

    private float spawnRate = 3;
    private float spawnDelay = 0;
    private float heightOffset = 3;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnDelay < spawnRate){
            spawnDelay = spawnDelay + Time.deltaTime;
        }else{
            spawnPipe();
            spawnDelay = 0;
        }

    }

    private void spawnPipe(){
        float lowP = transform.position.y - heightOffset;
        float highP = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowP,highP),0),transform.rotation);
    }
}
