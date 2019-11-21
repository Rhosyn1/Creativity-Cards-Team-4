using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    public float LookRadius = 10f;
    public float AttackRadius = 2.5f;
    private GameObject Player; 

    Transform Target;
    NavMeshAgent Agent;

    // Start is called before the first frame update
    void Start()
    {
        Target = PlayerManager.instance.Player.transform;
        Agent = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Target.position, transform.position);

        if (distance <= LookRadius)
        {
            Agent.SetDestination(Target.position);

            if(distance <= AttackRadius && !Player.GetComponent<TakingDamage>().invincible)
            {
                Player.GetComponent<TakingDamage>().health -= 1;
                Player.GetComponent<TakingDamage>().StartCoroutine("InvincibilityTime");
                Debug.Log("oww");
                Debug.Log(Player.GetComponent<TakingDamage>().health);
            }

            if (distance <= Agent.stoppingDistance)
            {
                FaceTarget();

            }
        }

    }

    void FaceTarget()
    {
        Vector3 direction = (Target.position - transform.position).normalized;
        Quaternion LookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, LookRotation, Time.deltaTime * 5);
    }


    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, LookRadius);
    }
}
