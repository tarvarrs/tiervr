using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BulletScript : MonoBehaviour
{
    public float force = 1000f;
    //public float destroyDelay = 2f;
    private Scorik1 _score;
    //public float respawnDelay = 5f;
    public GameObject targetPrefab;
    public Transform spawnPoint;
     
    public static int score;
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Target")
        {
            Destroy(collider.gameObject);
            score++;
            _score.Print(score.ToString());
        }

        if (collider.gameObject.tag == "MovingTarget")
        {
            Rigidbody targetRb = collider.gameObject.GetComponent<Rigidbody>();
            targetRb.AddForce(Vector3.forward * force);
            StartCoroutine(DestroyTarget(collider.gameObject));
            StartCoroutine(RespawnTarget());
            collider.gameObject.SetActive(false);
            score++;
            _score.Print(score.ToString());
        }
    }

    /*void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "MovingTarget") {
            Rigidbody targetRb = collision.gameObject.GetComponent<Rigidbody>();
            targetRb.AddForce(Vector3.forward * force);
            StartCoroutine(DestroyTarget(collision.gameObject));
            StartCoroutine(RespawnTarget());
            collision.gameObject.SetActive(false);
        }
    }*/

    IEnumerator DestroyTarget(GameObject target) {
        //yield return new WaitForSeconds(destroyDelay);
        yield return new WaitForSeconds(2);
        Destroy(target);
    } 
    
     IEnumerator RespawnTarget() {
        yield return new WaitForSeconds(5);
        GameObject target = Instantiate(targetPrefab, spawnPoint.position, spawnPoint.rotation);
        target.SetActive(true);
    }

    private void Start()
    {
        _score = FindObjectOfType<Scorik1>();
    }


}
