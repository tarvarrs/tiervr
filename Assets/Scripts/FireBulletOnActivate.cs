using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class FireBulletOnActivate : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float fireSpeed = 20;
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }
    public void FireBullet(ActivateEventArgs arg)
    {
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(spawnedBullet, 5);
    }
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Target") {
            Destroy(collision.gameObject);
        }
    }
}
