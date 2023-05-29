using UnityEngine;
public class BulletScript : MonoBehaviour
{
    public Scorik1 _score;
    public static int score;
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag=="Target")
        {
            Destroy(collider.gameObject);
            score++;
            _score.Print(score.ToString());
        }
        if (collider.gameObject.tag == "MovingTarget")
        {
            Destroy(collider.gameObject);
            score++;
            _score.Print(score.ToString());
        }
        if (collider.gameObject.tag == "Target3")
        {
            Destroy(collider.gameObject);
            score++;
            _score.Print(score.ToString());
        }
    }
    private void Start()
    {
        _score = FindObjectOfType<Scorik1>();
    }
}