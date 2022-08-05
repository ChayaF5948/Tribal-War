using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour
{
    private PlayerHPdata playerHPdata;

    private float currentSpeed;

    private void onTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            currentSpeed = 180f;
        }
    }
}
