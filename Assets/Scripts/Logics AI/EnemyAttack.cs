using System;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float _attackRange;
    [SerializeField] private int _damage;

    [SerializeField] private float _coolDown; 

    private float _timer;

    public bool CanAttack { get; private set;}

    
    private Player _player;



    public float AttackRange => _attackRange;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        UpdateCoolDOwn();

    }

    private void UpdateCoolDOwn()
    {
        //Debug.Log(_timer);
        if (CanAttack)
        {
            return;
        }
        _timer += Time.deltaTime;

        if (_timer < _coolDown)
        {
            return;
        }
        CanAttack = true;

        _timer = 0;
    }

    //private void UpdateCoolDOwn()
    //{
    //    Debug.Log(_timer);
    //    if (!CanAttack)
    //    {
    //        return;
    //    }
    //    _timer += Time.deltaTime;

    //    if (_timer < _coolDown)
    //    {
    //        return;
    //    }
    //    CanAttack = true;

    //    _timer = 0;
    //}

    public void TryAttackPlayer()
    {
        _player.TakeDamage(_damage);


        CanAttack = false;
    }
}