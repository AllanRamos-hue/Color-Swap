using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public long highscore;
    

    public PlayerData(PlayerController player)
    {
        if (player.score >= player.best)
            highscore = player.score;
        else
            highscore = player.best;
       
    }
}
