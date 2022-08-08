using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    [SerializeField]
    private Groups myFlag;
    [SerializeField]
    private GameObject flag;

    
    private void OnCollisionEnter(Collision other)
    {
            if (other.gameObject.CompareTag("Player"))
            {
            Groups whichGroup = other.gameObject.GetComponentInChildren<PlayerMovement>().myGroup;
           
            if (whichGroup == Groups.Groupe1 && myFlag == Groups.Groupe2)
                {
                    Debug.Log("the flag is conquerded");
                    ChangeArea(myFlag);
                    ChangeFlag(myFlag);
            }
            else if (whichGroup == Groups.Groupe2 && myFlag == Groups.Groupe1)
            {
                ChangeArea(myFlag);
                ChangeFlag(myFlag);
            }
        }  
    }
    

    private void ChangeFlag(Groups groups)
    {
        gameObject.SetActive(false);
        flag.SetActive(true);
        switch (groups)
        {
            case Groups.Groupe1:
                groups = Groups.Groupe2;
                    break;
            case Groups.Groupe2:
                groups = Groups.Groupe1;
                break;

        }
        GameManager.Instance.OnFlagConquered(groups);


    }

    private void ChangeArea(Groups groups)
    {
        switch (groups)
        {

            case Groups.Groupe2:
                transform.parent.gameObject.layer = 8;
                break;
            case Groups.Groupe1:
                transform.parent.gameObject.layer = 9;
                break;
        }
    }
}
