using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipe;

    public Birdy birdy;
    void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    void Update()
    {
        
    }

    IEnumerator SpawnPipe()
    {
        while (!birdy.isDead)
        {
            Instantiate(pipe, new Vector3(3, Random.Range(-0.35f, 0.35f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.75f);
        }

    }
}
