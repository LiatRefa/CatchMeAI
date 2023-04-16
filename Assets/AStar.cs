//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
////using UnityStandardAssets.Characters.ThirdPerson;

//public class Chaser : MonoBehaviour
//{
//    public Transform goal;
//    [SerializeField] public float speed = 0.01f;
//    public float rotationSpeed = 0.03f;
//    public float distance = 1.5f;


//    // Update is called once per frame
//    void Update()
//    {
//        Vector3 theGoal = new Vector3(goal.position.x, transform.position.y, goal.position.z);
//        Vector3 direction = theGoal - transform.position;
//        Debug.Log(direction.y);

//        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotationSpeed);

//        Debug.DrawRay(transform.position, direction, Color.red);
//        if (direction.magnitude >= distance)
//        {
//            Vector3 pushVector = direction.normalized * speed;
//            Debug.Log(pushVector);
//            transform.Translate(pushVector, Space.World);

//        }
//    }
//}
