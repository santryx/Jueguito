using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatinPlayer : MonoBehaviour
{

    public float speedRotation = 200.0f;
    public float speedMoving = 4.0f;
    float yDir;
    float xDir;
    Animator PlayerAni;
   


    public Transform mira;
    public GameObject bala;

    

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

        if (Input.GetKeyDown("f"))
        {
            
            PlayerAni.SetTrigger("Fire");

        }

        if (Input.GetKeyDown("f"))
        {

            Instantiate(bala, mira.position, mira.rotation);
            
        }

        

       

        

    }


}
