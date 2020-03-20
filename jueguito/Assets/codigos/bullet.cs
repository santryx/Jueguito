using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody bala;
    void Start()
    {

        bala = GetComponent<Rigidbody>();
        bala.AddForce(transform.forward * 2000);
    }

}
