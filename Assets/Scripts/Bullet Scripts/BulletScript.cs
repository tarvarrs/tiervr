using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float force = 1000f;
    public float destroyDelay = 2f;
    /*
    public float respawnDelay = 5f;
    public GameObject targetPrefab;
    public Transform spawnPoint;
     */
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Target")
        {
            Destroy(collider.gameObject);
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "MovingTarget") {
            Rigidbody targetRb = collision.gameObject.GetComponent<Rigidbody>();
            targetRb.AddForce(Vector3.forward * force);
            StartCoroutine(DestroyTarget(collision.gameObject)); //
            /*
            StartCoroutine(RespawnTarget());
            collision.gameObject.SetActive(false);
             */
        }
    }

    IEnumerator DestroyTarget(GameObject target) {
        yield return new WaitForSeconds(destroyDelay);
        Destroy(target);
    } //
    /*
     IEnumerator RespawnTarget() {
        yield return new WaitForSeconds(respawnDelay);
        GameObject target = Instantiate(targetPrefab, spawnPoint.position, spawnPoint.rotation);
        target.SetActive(true);
    }
     */
}
