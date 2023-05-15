using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject SpawnPrefab;

    private void Start()
    {
        StartCoroutine(SpawnCD());
    }

    void repeat()
    {
        StartCoroutine(SpawnCD());
    }

    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(5);
        Instantiate(SpawnPrefab,SpawnPos.position, Quaternion.identity);
        repeat();
    }
}
