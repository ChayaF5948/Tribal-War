using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    
    [SerializeField] 
    private AudioClip[] audioClips;

    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private PlayerHPdata[] playerHPdata;
    private AddAbility AddAbility;
    private SwitchPlayers switchPlayers;
    private PlayerAbility playerAbility;

    //[SerializeField] private AudioClip playerCaught;
    //[SerializeField] private AudioClip changeFields;
    
    //private bool IsChangeFlag;

    

    private void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        //GameManager.Instance.OnFlagConquered += PlaySound;
        playerHPdata[0].OnAddOrDecreaseBullet+= PlayBulletSound;
        playerHPdata[1].OnAddOrDecreaseBullet += PlayBulletSound;
        playerHPdata[0].OnAddScore += PlayAddScoreSound;
        playerHPdata[1].OnAddScore += PlayAddScoreSound;
        playerHPdata[0].OnShoot += PlayShootSound;
        playerHPdata[1].OnShoot += PlayShootSound;
    }

    //private void Update()
    //{
    //    if (IsChangeFlag)
    //    {
    //        Debug.Log("Play Audio");
    //    }
    //}

    private void PlaySound(int flagsP1, int flagsP2,bool conquered)
    {
        if (flagsP1 >= 1||flagsP2 >= 1)
        {
            audioSource.clip = audioClips[0];
            audioSource.Play();
            
        }
        else if(flagsP1 <= 0|| flagsP2 <= 0)
        {
            audioSource.clip = audioClips[1];
            audioSource.Play();
        }
  

    }
    private void PlayBulletSound(int bullet )
    {
        audioSource.clip = audioClips[2];
        audioSource.Play();
        //Debug.Log("Bullet sound play");
    }

    private void PlayAddScoreSound(int score)
    {
        audioSource.clip = audioClips[3];
        audioSource.Play();
        //Debug.Log("score sound play");
    }

    private void PlayShootSound()
    {
        audioSource.clip = audioClips[4];
        audioSource.Play();
        //Debug.Log("Shoot sound play");
    }

}
