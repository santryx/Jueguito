using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyBullet : MonoBehaviour
{

    public EnemyManager enemyManager;


    public void OnCollisionEnter(Collision collision)
    {



        if (collision.gameObject.tag == "Bullet")
        {

            
            Destroy(collision.gameObject);
            enemyManager.contar();
        }


    }



    

}
