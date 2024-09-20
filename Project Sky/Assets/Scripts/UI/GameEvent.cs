using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Defines Game Events for event system. Just a bunch of constant strings that make calling listeners and broadcasts easier. 
public static class GameEvent
{    

     public const string player_health_down = "player_health_down"; 

     public const string enemy_hit_score = "enemy_hit_score"; 

     public const string enemy_down_score = "enemy_down_score"; 

     public const string boss_hit_score = "boss_hit_score"; 



   
}
