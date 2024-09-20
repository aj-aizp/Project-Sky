using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Timer : MonoBehaviour
{
  [SerializeField] private TMP_Text timeText; 

 
  private int seconds; 

  private int mintues; 

  public static float deltaTime; 





  private void Update() {
    deltaTime += Time.deltaTime; 
    calcTime(); 
  }


  private void calcTime() {

    mintues = Mathf.FloorToInt(deltaTime/60.0f); 
    seconds = Mathf.FloorToInt(deltaTime-mintues*60); 
    string tText  = string.Format("{0:0}:{1:00}", mintues,seconds); 

    timeText.text = tText; 
    
  }
  


}
