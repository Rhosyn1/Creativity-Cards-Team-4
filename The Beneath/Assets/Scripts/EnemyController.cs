using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    public float LookRadius = 10f;

    Transform Target;
    NavMeshAgent Agent;

    // Start is called before the first frame update
    void Start()
    {
        Target = PlayerManager.instance.Player.transform;
        Agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Target.position, transform.position);

        if (distance <= LookRadius)
        {
            Agent.SetDestination(Target.position);


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
