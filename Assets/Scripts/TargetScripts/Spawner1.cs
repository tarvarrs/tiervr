using System.Collections;
using UnityEngine;
public class Spawner1 : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject SpawnPrefab;
    private void Start()
    {
        StartCoroutine(Spawn1());
    }
    void repeat()
    {
        StartCoroutine(Spawn1());
    }
    public IEnumerator Spawn1()
    {
        yield return new WaitForSeconds(25);
        Instantiate(SpawnPrefab, SpawnPos.position, Quaternion.identity);
        repeat();
    }
}