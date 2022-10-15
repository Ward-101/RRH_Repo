using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleePC : MonoBehaviour
{
    [Header("Balancing")]
    [SerializeField] private float maxCritRange;
    [SerializeField] private float minCritRange;

    [Header("Requirements")]
    [SerializeField] private PlayerInputHandler inputHandler;

    private void Update()
    {
        if (inputHandler.MeleeInput)
        {
            print("Melee Initialised");
            inputHandler.UseMeleeInput();
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, maxCritRange);

        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, minCritRange);
    }
}
