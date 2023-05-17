using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class FireBulletOnActivate : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float fireSpeed = 20;
    public AudioClip fireClip;
    public AudioSource audioSource;
    
    
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
        
    }

   
    
    
    public void FireBullet(ActivateEventArgs arg)
    {
        audioSource.PlayOneShot(fireClip);
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(spawnedBullet, 5);
        
    }


    
}
