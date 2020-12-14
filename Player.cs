
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour

{

    public float moveSp;
    public Rigidbody rb;
    public bool playerIsOnTheGround = true;





    // Start is called before the first frame update
    void Start()
    {
        moveSp = 9f;
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * moveSp;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * moveSp;

        transform.Translate(horizontal, 0, vertical);



        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector3(0, 4, 0), ForceMode.Impulse);
        }


    }


}




