using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyEnemy : MonoBehaviour
{


    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {

            Destroy(collision.gameObject);


        }

    }



    


}
