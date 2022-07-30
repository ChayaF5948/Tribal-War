using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    
    [SerializeField]
    private GameObject[] objectForInstantiate;
    [SerializeField]
    private GameObject[] specialPicUp;

    private float STimer;

    private float S1Timer;

    private bool isInstantaite = true;
    private bool isInstantaite1 = true;

    private float minPosX =-5f;
    private float maxPosx = 5f;
    private float minPosZ = 3.5f;
    private float maxPosZ = 8.3f;


    // Start is called before the first frame update
    void Start()
    {
        STimer = Random.Range(10f, 15f);
        S1Timer = Random.Range(30f, 40f);
        StartCoroutine(Timer());
        StartCoroutine(Timer1());
    }

    // Update is called once per frame
    void Update()
    {
        CreatePerfab();
    }



    private void CreatePerfab()
    {
        if (isInstantaite)
        {
            var position = new Vector3(Random.Range(-7f, 13f), 1, Random.Range(84f, 126f));
            Instantiate(objectForInstantiate[0], position, Quaternion.identity);
            

            StartCoroutine(Timer());
        }

        if (isInstantaite1)
        {
            Vector3 newPos = new Vector3(Random.Range(minPosX, maxPosx), 0.01f, Random.Range(minPosZ, maxPosZ));
            GameObject special = Instantiate(specialPicUp[Random.Range(0, specialPicUp.Length)]);
            special.transform.position = newPos;
            //var position = new Vector3(Random.Range(-26f, 13f), 1, Random.Range(-15f, 60f));
            //Instantiate(objectForInstantiate[1], position, Quaternion.identity);
            StartCoroutine(Timer1());


        }

    }

    IEnumerator Timer()
    {
        isInstantaite = false;
        yield return new WaitForSeconds(STimer);
        isInstantaite = true;
    }

    IEnumerator Timer1()
    {
        isInstantaite1 = false;
        yield return new WaitForSeconds(S1Timer);
        isInstantaite1 = true;
    }
}

