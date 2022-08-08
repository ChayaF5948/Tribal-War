using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PicUpType
{
  shoots,
  speed,
  dubleSpeed  
}

public class AddAbility : MonoBehaviour
{
    [SerializeField] PicUpType type;

    private bool isCaughtShoot = true;
    private bool isCaughtSpead = true;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerMovement datas = other.gameObject.GetComponentInChildren<PlayerMovement>();
            if (type == PicUpType.shoots)
            {
                if (isCaughtShoot)
                {
                    StartCoroutine(WhaitWhenAddShoot());
                    datas.playerData.Bullets = datas.playerData.Bullets + 15;
                    if (datas.playerData.Bullets >= 15)
                    {
                        datas.playerData.Bullets = 15;
                    }

                }
            }

            if (type == PicUpType.speed)
            {

                if (isCaughtSpead)
                {
                    datas.playerData.Score = datas.playerData.Score + 1;
                    if (datas.playerData.Score >= 7)
                    {
                        datas.IncreaseSpeed = true;
                    }

                }
                Destroy(gameObject);

            }

        }
       
    }

    private IEnumerator WhaitWhenAddShoot()
    {
        isCaughtShoot = false;
        yield return new WaitForSeconds(2f);
        isCaughtShoot = true;
    }

    private IEnumerator WhaitWhenAddScore()
    {
        isCaughtSpead = false;
        yield return new WaitForSeconds(2f);
        isCaughtSpead = true;
    }
}
   

