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
    [SerializeField] GameManager gameManager;
    //[SerializeField] PlayerHPdata playerData;
    private bool isCaughtShoot = true;
    private bool isCaughtSpead = true;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            //if(isCaughtShoot)
            //{
                //StartCoroutine(Wait1());
                PlayerMovement datas = other.gameObject.GetComponentInChildren<PlayerMovement>();
               if (type == PicUpType.shoots)
               {
                if (isCaughtShoot)
                {
                    StartCoroutine(WhaitWhenAddShoot());
                    datas.playerData.Bullets = datas.playerData.Bullets +15;
                   //playerData.
                  //Debug.Log("Add bullets");
                  if(datas.playerData.Bullets >= 15)
                  {
                    datas.playerData.Bullets = 15;
                  }

                }
                

               //}
            }
           
            
            //PlayerHPdata playerHP = datas.playerHPdata;

            //else if(isCaughtSpead)
            //{
                //StartCoroutine(Wait2());
                //PlayerMovement datas = other.gameObject.GetComponentInChildren<PlayerMovement>();
                if (type == PicUpType.speed)
                {
                 
                if (isCaughtSpead)
                {
                    datas.playerData.Score = datas.playerData.Score + 1;
                    if (datas.playerData.Score >= 7)
                    {


                        datas.IncreaseSpeed = true;
                        
                        //Debug.Log("Add speed");

                    }
                    //isAddScore = true;
                    //Debug.Log("Score:" + datas.playerData.Score);

                }
                    

                }
            //}

          

            //else if(type == PicUpType.dubleSpeed)
            //{
            //    datas.playerData.DoubleSpeed = datas.playerData.DoubleSpeed +=0.5f;
            //}
            Destroy(gameObject);

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
    //private IEnumerator Wait1()
    //{
    //    isCaughtShoot = false;
    //    yield return new WaitForSeconds(2f);
    //    isCaughtShoot = true;
    //}
    //private IEnumerator Wait2()
    //{
    //    isCaughtSpead= false;
    //    yield return new WaitForSeconds(2f);
    //    isCaughtSpead = true;
    //}
}
