﻿using System.Collections;

using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;



public class Enemy : MonoBehaviour
{



    public GameObject player;



    // Use this for initialization

    void Start()
    {



    }



    // Update is called once per frame

    void Update()
    {
        transform.LookAt(player.transform);
        transform.position += transform.forward * 2f * Time.deltaTime;


    }

}
