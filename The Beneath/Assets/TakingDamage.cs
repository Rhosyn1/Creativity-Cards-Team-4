using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakingDamage : MonoBehaviour
{
    public int health = 10;
    public int DamageToPlayer = 1;
    public bool invincible = false;
    public GameObject Player;
    

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Terrain")
        {
            health -= 1;
            StartCoroutine("InvincibilityTime");
        }
    }
    IEnumerator InvincibilityTime()
    {
        invincible = true;
        yield return new WaitForSeconds(1);
        invincible = false;
    }
}
