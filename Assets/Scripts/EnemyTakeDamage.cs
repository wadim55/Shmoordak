using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTakeDamage : MonoBehaviour
{
  
   [SerializeField] private GameObject BlueLelik;
   [SerializeField] private GameObject hips;
   [SerializeField] private GameObject boom;
   private void OnMouseDown()
   {
      gameObject.tag = "target";
      EVENT.ZvonokSobitie(1);
      gameObject.tag = "no";
      BlueLelik.GetComponent<NavMeshAgent>().enabled = false;
      BlueLelik.GetComponent<Robot>().enabled = false;
      BlueLelik.GetComponent<Animator>().enabled = false;
      hips.SetActive(true);
      Destroy(BlueLelik,3);
    var particle =  Instantiate(boom, transform.position, Quaternion.identity);
    Destroy(particle,3);
   }
}
