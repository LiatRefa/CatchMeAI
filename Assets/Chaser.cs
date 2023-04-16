using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chaser : MonoBehaviour
{
    public Transform goal;
    [SerializeField] Animator anime;
    public float rotationSpeed = 0.03f;
    public float distance = 1.5f;
    public bool isWalk = true;
    public bool isRun = false;
    public int walkSpeed = 1;
    public int runSpeed = 30;
    public bool isChasing = true;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(goal.position);
        run();
    }

    void walk()
    {
        isRun = false;
        isWalk = true;
        agent.speed = walkSpeed;
    }

    void run()
    {
        isWalk = false;
        isRun = true;
        agent.speed = runSpeed;
    }

    void Update()
    {
        if(isChasing)
        {
            anime.SetBool("near", false);
            Vector3 theGoal = new Vector3(goal.position.x, transform.position.y, goal.position.z);
            Vector3 direction = theGoal - transform.position;

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotationSpeed);

            Debug.DrawRay(transform.position, direction, Color.red);

            if (agent.remainingDistance >= agent.stoppingDistance)
            {
                agent.SetDestination(goal.position);
                return;
            }
            else
            {
                agent.isStopped = true;
                anime.SetBool("near", true);
                isChasing = false;
            }

        }
        
    }
}