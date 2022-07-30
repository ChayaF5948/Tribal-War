using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private int[] Types;
    [SerializeField]
    private int WhichTypeChoosed;

   

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ChooseType1()
    {
        WhichTypeChoosed = Types[0];
    }

    public void ChooseType2()
    {
        WhichTypeChoosed = Types[1];
    }

   
  
}
