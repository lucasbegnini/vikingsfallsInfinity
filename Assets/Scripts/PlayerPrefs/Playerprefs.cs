using UnityEngine;
using System.Collections;

public class Playerprefs : MonoBehaviour {

    int score;
    void getPlayerPrefs()
    {
        score = PlayerPrefs.GetInt("highscore");
    }



    void setPlayerPrefs (int score)
    {
        PlayerPrefs.SetInt("highscore", score);
	}






	
}
