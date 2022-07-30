using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour
{
    private PlayerHPdata playerHPdata;

    private float currentSpeed;


    // Start is called before the first frame update
    void Start()
    {
        //currentSpeed = playerHPdata.CurrentSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            currentSpeed = 180f;
        }
    }
}
