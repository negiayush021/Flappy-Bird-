using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_spawner : MonoBehaviour
{
    public GameObject _pipe;
    private float maxTime = 2f;
    private float heightRange = 1f;
    private float timer;


    private void Start()
    {
        spawnPipe();
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            spawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }


    public void spawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0,Random.Range(-heightRange, heightRange),0);
        GameObject pipe = Instantiate(_pipe , spawnPos , Quaternion.identity);

        Destroy(pipe, 10);
    }
}
