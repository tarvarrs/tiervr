using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _power;
    private void OnTriggerEnter(Collider collider)
    {
        if (!collider.CompareTag(WEAPON_tag))
        {
            return;
        }
        _rigidbody.isKinematic
    }
}
