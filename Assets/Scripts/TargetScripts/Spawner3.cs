using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner3 : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject SpawnPrefab;

    private void Start()
    {
        StartCoroutine(Spawn3());
    }

    void repeat()
    {
        StartCoroutine(Spawn3());
    }

    public IEnumerator Spawn3()
    {
        Instantiate(SpawnPrefab, SpawnPos.position, Quaternion.identity);
        yield return new WaitForSeconds(25);
        repeat();
    }
}
