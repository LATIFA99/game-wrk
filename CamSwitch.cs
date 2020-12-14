using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamSwitch : MonoBehaviour
{
    public Camera Aerial;
    public Camera Observer;

    public float secondsCount;



    // Start is called before the first frame update
    void Start()
    {
        Aerial.enabled = true;
        Observer.enabled = false;
    }

    // Update is called once per frame
    public void Update()
    {
        secondsCount += Time.deltaTime;
        if (secondsCount > 5f)
        {
            Aerial.enabled = false;
            Observer.enabled = true;
        }

    }
}
