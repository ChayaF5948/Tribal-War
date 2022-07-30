using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesplayData : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    [SerializeField]
    private Text whoWin;

    // Start is called before the first frame update
    void Start()
    {
        if(gameManager.FlagGro1Num >= 8)
        {
            whoWin.text = "Group 1 win".ToString();
        }
         else if (gameManager.FlagGro2Num >= 8)
        {
            whoWin.text = "Group 2 win".ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
