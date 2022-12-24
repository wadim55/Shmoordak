using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   private AudioSource audio;

   private void Start()
   {
      audio = GetComponent<AudioSource>();
   }
   
   private void OnEnable()  //подписываемся на событие при включенном объекте
   {
      EVENT.number += shootAudio;
   }

   private void OnDisable() //отписываемся от событие при отключенном объекте
   {
      EVENT.number -= shootAudio;
   }

  private void shootAudio(int number)
   {
      audio.Play();
   }
   
}
