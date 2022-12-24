using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerWave : MonoBehaviour
{
    [SerializeField] private int _wave;
    [SerializeField] private int _waveEnd;
    public GameObject enemyClone;

    private void Start()
    {
      InvokeRepeating("Spawn", 2,1);
       
    }

    private void Update()
    {
        
    }

    void Spawn()
    {

        if (_wave < 10)
        {
            Instantiate(enemyClone, enemyClone.transform.position, enemyClone.transform.rotation);
            _wave++;
        }
    }
}
