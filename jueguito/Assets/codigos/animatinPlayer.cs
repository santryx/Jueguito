using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatinPlayer : MonoBehaviour
{

    public float speedRotation = 200.0f;
    public float speedMoving = 4.0f;
    float yDir;
    float xDir;
    Animator PlayerAni;

    
    void Start()
    {
        PlayerAni = GetComponent<Animator>();  
    }

    
    void Update()

    {

        xDir = Input.GetAxis("Horizontal");
        yDir = Input.GetAxis("Vertical");

        transform.Rotate(0, xDir* Time.deltaTime * speedRotation, 0);
        transform.Translate(0,0,yDir* Time.deltaTime*speedMoving);

        PlayerAni.SetFloat("SpeedX", xDir);
        PlayerAni.SetFloat("SpeedY", yDir);

        if(Input.GetButtonDown("Jump"))
        {

            PlayerAni.SetTrigger("Fire");

        }

        


        

    }
}
