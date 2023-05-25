using UnityEngine;
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
    [SerializeField] private Spawner1 sp1;
    [SerializeField] private Spawner2 sp2;
    public static int score;
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag=="Target")
        {
            Destroy(collider.gameObject);
            score++;
            _score.Print(score.ToString());
            StartCoroutine(sp1.Spawn1());
        }

        if (collider.gameObject.tag == "MovingTarget")
        {
            Destroy(collider.gameObject);
            score++;
            _score.Print(score.ToString());
            StartCoroutine(sp2.Spawn2());
        }
    }

    private void Start()
    {
        _score = FindObjectOfType<Scorik1>();
    }
    /*
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
    }*/
}