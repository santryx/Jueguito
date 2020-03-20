using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public GameObject enemigo;
    float counter;
    public float MinR = -10;
    public float MaxR = 10;
    Vector3 rangoRango;
    
    Animator EnemyAni;


    void Start()
    {

        EnemyAni = GetComponent<Animator>();

    }

   

    void Update()
    {

        counter = counter + Time.deltaTime;

        if (counter > 1.0f)
        {

            counter = 0;
            rangoRango = new Vector3(Random.Range(MinR, MaxR), 0, Random.Range(MinR, MaxR));
            Instantiate(enemigo, rangoRango, transform.rotation);

        }
    }




}
