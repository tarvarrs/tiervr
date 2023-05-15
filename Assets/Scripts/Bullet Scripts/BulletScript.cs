using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class BulletScript : MonoBehaviour
{
    public float force = 1000f;
    public Scorik1 _score;

    public GameObject targetPrefab1;
    public Transform spawnPoint1;

    public GameObject targetPrefab2;
    public Transform spawnPoint2;

    public GameObject targetPrefab3;
    public Transform spawnPoint3;

    public static int score;
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Target")
        {
            Destroy(collider.gameObject);
            spawnPoint1 = gameObject.GetComponent<Transform>();
            score++;
            _score.Print(score.ToString());
            StartCoroutine(Spawn1());
        }

        if (collider.gameObject.tag == "MovingTarget")
        {
            Destroy(collider.gameObject);
            spawnPoint2 = gameObject.GetComponent<Transform>();
            score++;
            _score.Print(score.ToString());
            StartCoroutine(Spawn2());
        }
        if (collider.gameObject.tag == "Target3")
        {
            Destroy(collider.gameObject);
            spawnPoint3 = gameObject.GetComponent<Transform>();
            score++;
            _score.Print(score.ToString());
            StartCoroutine(Spawn3());
        }
    }

    private void Start()
    {
        _score = FindObjectOfType<Scorik1>();
    }

    IEnumerator Spawn1()
    {
        yield return new WaitForSeconds(5);
        Instantiate(targetPrefab1, spawnPoint1.position, Quaternion.identity);
        
    }

    IEnumerator Spawn2()
    {
        yield return new WaitForSeconds(5);
        Instantiate(targetPrefab2, spawnPoint2.position, Quaternion.identity);

    }

    IEnumerator Spawn3()
    {
        yield return new WaitForSeconds(5);
        Instantiate(targetPrefab3, spawnPoint3.position, Quaternion.identity);

    }
}