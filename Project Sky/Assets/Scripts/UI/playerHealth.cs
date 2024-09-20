using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class playerHealth : MonoBehaviour
{

   [SerializeField] private TMP_Text healthText; 
   private int health = 100;


     void OnEnable() {
            Messenger.AddListener(GameEvent.player_health_down, healthDown);  
    }

 void OnDisable() {
        Messenger.RemoveListener(GameEvent.player_health_down,healthDown);   
    }



    private void healthDown() {
        health -= 10; 

        healthText.text = health.ToString(); 
    }



 




}
