using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class Collider : MonoBehaviour
{
    private int score = 0;
    private int life = 0;
    public Text scoreTexta;
    public Text scoreTextb;




    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Booster" || col.gameObject.name == "Booster1" 
            || col.gameObject.name == "Booster2" || col.gameObject.name == "Enemy"
            || col.gameObject.name == "Enemy1" || col.gameObject.name == "Enemy2" )
        {

            Destroy(col.gameObject);
        }

        if (col.gameObject.name == "Booster" || col.gameObject.name == "Booster1" || col.gameObject.name == "Booster2")
        {
            life += 1;
            UnityEngine.Debug.Log("Life!");
            scoreTexta.text = "Life:" + life;
        }


        if (col.gameObject.name == "Enemy" || col.gameObject.name == "Enemy1" || col.gameObject.name == "Enemy2" )
        {
            score += 1;
            UnityEngine.Debug.Log("Points!");
            scoreTextb.text = "Points:-" + score;

        }





    }
}
