using UnityEngine;
public class SelectedGun : MonoBehaviour
{
    private int i;
    public GameObject[] AllGuns;
    private void Start()
    {
        i = PlayerPrefs.GetInt("CurrentGun");
        AllGuns[i].SetActive(true);
    }
}