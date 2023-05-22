using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject SpawnPrefab;

    private void Start()
    {
        StartCoroutine(Spawn2());
    }

    void repeat()
    {
        StartCoroutine(Spawn2());
    }

    public IEnumerator Spawn2()
    {
        yield return new WaitForSeconds(20);
        Instantiate(SpawnPrefab, SpawnPos.position, Quaternion.identity);
        repeat();
    }
}
