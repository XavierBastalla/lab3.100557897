using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class EnemeyTypeChicken : EnemyBehaviour
{
    protected override void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "H")
        {
            Debug.Log(" Chicken hitting player");
        }

    }

        void Update()
    {
        
    }

}

