using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    [SerializeField]
    private Groups myFlag;
    [SerializeField]
    private GameObject flag;

   [SerializeField] private GameManager gameManager;
   

    //[SerializeField]
    //private Material[] area;

    private bool isChangeFlag = true;
    
    
    public bool IsChangeFlag
    {
        get
        {
            return isChangeFlag;
        }
        set
        {
            isChangeFlag = value;
        }
    }
     
    private bool canChangeFlagUI = false;
    public bool CanChangeFlagUI
    {
        get
        {
            return canChangeFlagUI;
        }
        set
        {
            canChangeFlagUI = value;
        }
    }



    private void OnCollisionEnter(Collision other)

    {
        if(isChangeFlag)
        {
            StartCoroutine(WhaitWhenConquered());
            if (other.gameObject.CompareTag("Player"))
            {
                PlayerMovement whichAGroup = other.gameObject.GetComponentInChildren<PlayerMovement>();
                Groups groupes = whichAGroup.myGroup;
                if (groupes == Groups.Groupe1 && myFlag == Groups.Groupe2)
                {
                    Debug.Log("the flag is conquerded");
                    ChangeArea();
                    ChangeFlag();
                }
                else if (groupes == Groups.Groupe2 && myFlag == Groups.Groupe1)
                {
                    Debug.Log("the flag is conquerded");
                    ChangeArea();
                    ChangeFlag();
                }
            }
        }
       
    }
    

    private void ChangeFlag()
    {
        Debug.Log("change flag");
        gameObject.SetActive(false);
        flag.SetActive(true);
       
       
            if (myFlag == Groups.Groupe2)
            {
                
                gameManager.FlagGro1Num++;
                gameManager.FlagGro2Num--;

                //if(gameManager.FlagGro1Num >= 8)
                //{
                //  SceneManager.LoadScene("WinScene");
                //}
                
            }
            else if (myFlag == Groups.Groupe1)
            {
                
                gameManager.FlagGro1Num--;
                gameManager.FlagGro2Num++;

            //if (gameManager.FlagGro2Num >= 8)
            //{
            //    SceneManager.LoadScene("WinScene");
            //}

            }
            gameManager.IsConquered = true;
          
       
        
    }

    private void ChangeArea()
    {
        if(myFlag == Groups.Groupe2)
        {
            transform.parent.gameObject.layer = 8;
            //transform.parent.GetComponent<Renderer>().material = area[0];
        }
        else if(myFlag == Groups.Groupe1)
        {
            transform.parent.gameObject.layer = 9;
            //transform.parent.GetComponent<Renderer>().material = area[1];
        }

    }

  private IEnumerator WhaitWhenConquered()
    {
        isChangeFlag = false;
        yield return new WaitForSeconds(2f);
        isChangeFlag = true;
    }
}
