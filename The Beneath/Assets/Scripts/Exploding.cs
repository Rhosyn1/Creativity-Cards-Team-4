using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploding : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            StartCoroutine(Countdown());
        }
    }
    IEnumerator Countdown()
    {
        
        yield return new WaitForSeconds(2);
        GetComponentInChildren<ParticleSystem>().Play();
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}


