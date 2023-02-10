using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class EnemyBehaviour : MonoBehaviour

    
{
    public float speed = 5f;

    public Transform target;

     protected Rigidbody Rig;

    void Start()
    {
        Rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
        Rig.MovePosition(pos);
        transform.LookAt(target);
    }


    protected virtual void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.name == "H")
        {
            Debug.Log("im hitting player");
        }
       
    }

  


}
