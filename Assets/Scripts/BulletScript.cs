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
        Debug.Log("�����");

        if (collider.gameObject.tag == "Target")
        {
            Destroy(collider.gameObject);
        }
    }
}
