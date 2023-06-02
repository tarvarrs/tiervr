using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowGunName : MonoBehaviour
{
    public TextMeshProUGUI gunText;
    public void Print(string text)
    {
        gunText.text = text;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
