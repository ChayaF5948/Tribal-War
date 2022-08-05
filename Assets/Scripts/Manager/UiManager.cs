
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField]
    private PlayerHPdata[] playerData;

    
    [SerializeField]
    private Text flagTextP1;
    [SerializeField]
    private Text flagTextP2;

    //[SerializeField]
    //private Image image1;
    //[SerializeField]
    //private Image image2;
    [SerializeField]
    private Text bulletTextP1;
    [SerializeField]
    private Text bulletTextP2;

    [SerializeField]
    private Text scoreTextP1;
    [SerializeField]
    private Text scoreTextP2;


    private void Start()
    {

        //image1.setActive = false;
        //image2.SetActive = false;
        //GameManager.Instance.OnFlagConquered += ChangeTheNumberFlagsText;


        playerData[0].OnAddOrDecreaseBullet += ChangeTheNumberBulletsP1Text;
        playerData[1].OnAddOrDecreaseBullet += ChangeTheNumberBulletsP2Text;

        playerData[0].OnAddScore += ChangeTheNumbeSrcoreP1Text;
        playerData[1].OnAddScore += ChangeTheNumbeSrcoreP2Text;
    }

    //private void ChangeTheNumberFlagsText(Groups groups,int flags )
    //{
    //    groups = GameManager.Instance.GetFlagsScoresGroup


    //        flagTextP1.text = $"{flagsP1.ToString()}";
    //        flagTextP2.text = $"{flagsP2.ToString()}";
         
    //}

    private void ChangeTheNumberBulletsP1Text(int bulletP1)
    {
        //image1.SetActive = true;
        bulletTextP1.text = $"{bulletP1.ToString()}";
    }

    private void ChangeTheNumberBulletsP2Text(int bulletP2)
    {
        //image2.SetActive = true;
        bulletTextP2.text = $"{bulletP2.ToString()}";
    }

    private void ChangeTheNumbeSrcoreP1Text(int scoreP1)
    {
        scoreTextP1.text = $"{scoreP1.ToString()}";
    }

    private void ChangeTheNumbeSrcoreP2Text(int scoreP2)
    {
        scoreTextP2.text = $"{scoreP2.ToString()}";
    }
}
