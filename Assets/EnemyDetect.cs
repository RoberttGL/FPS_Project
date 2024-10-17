using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("trigger enter" + other.transform.tag);
        if (other.transform.tag == "Enemy")
        {

        }
    }
    private void OnTriggerExit(Collider other)
    {
        print("trigger enter" + other.transform.tag);
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("collision enter" + collision.transform.tag);
    }

    private void OnCollisionExit(Collision collision)
    {
        print("collision exit" + collision.transform.tag);
    }
    //private void OnTriggerExit(Collider other)
    //{
    //    other.transform.gameObject.GetComponent<EnemyScript>().detectedPlayer = false;
    //}
}
