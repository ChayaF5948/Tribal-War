using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinManager : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    private Text whoWin;

    private bool group1win = false;
    //public bool Group1win
    //{
    //    get { return group1win; }
    //    set
    //    {
    //        group1win = value;
    //    }
    //}
    private bool group2win = false;
    //public bool Group2win
    //{
    //    get { return group2win; }
    //    set
    //    {
    //        group2win = value;
    //    }
    //}

    //private bool isLoad = false;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        //gameManager.OnFlagConquered += TheGameEnd;
        gameManager.OnGro1Win += Gro1Win;
        gameManager.OnGro2Win += Gro2Win;
    }

    void TheGameEnd(int gro1, int gro2, bool isConquard)
    {
        if (gro1 >= 8)
        {
            group1win = true;
            StartCoroutine(Wait());

        }
        else if (gro2 >= 8)
        {
            group2win = true;
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {

        yield return new WaitForSeconds(3);
        Debug.Log("wait");
        SceneManager.LoadScene("WinScene");

        DesplayTextWhoWin();

    }

    private void DesplayTextWhoWin()
    {
        Debug.Log("jjjl");
        whoWin = GameObject.Find("DisplayUI").GetComponentInChildren<Text>();
        if (group1win)
        {
            whoWin.text ="Group 1 win".ToString();
           
        }
        else if (group2win)
        {
            whoWin.text = "Group 2 win".ToString();
        }
    }

    void Gro1Win(bool isGro1Win)
    {
        if (isGro1Win)
        {
            StartCoroutine(Wait());
            //Debug.Log("We2Win");

            SceneManager.LoadScene("WinScene");


        }
    }

    void Gro2Win(bool is2GroWin)
    {
        if (is2GroWin)
        {
            StartCoroutine(Wait());
            Debug.Log("We2Win");

            SceneManager.LoadScene("WinScene");
        }
    }

   

}
