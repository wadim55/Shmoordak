using UnityEngine;
public class Shooter : MonoBehaviour
{
 [SerializeField] private GameObject boolet;
  
 private void OnEnable()  //подписываемся на событие при включенном объекте
 {
     EVENT.number += Shoot;
 }

 private void OnDisable() //отписываемся от событие при отключенном объекте
 {
     EVENT.number -= Shoot;
 }
 private void Shoot(int number)
    {
        if(number != 1) return;
        Instantiate(boolet, transform.position, Quaternion.identity);
    }

   
}
