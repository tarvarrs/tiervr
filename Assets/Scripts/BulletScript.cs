using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Target")
        {
            Destroy(collider.gameObject);
        }
    }
    
    public float force = 1000f;
    public float destroyDelay = 2f;
    
    public void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "MovingTarget") {
            Rigidbody targetRb = collision.gameObject.GetComponent<Rigidbody>();
            targetRb.AddForce(Vector3.forward * force);
            StartCoroutine(DestroyTarget(collision.gameObject));
        }
    }

    IEnumerator DestroyTarget(GameObject target) {
        yield return new WaitForSeconds(destroyDelay);
        Destroy(target);
    }

}
