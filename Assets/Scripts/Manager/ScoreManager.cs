using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    private PlayerHPdata playerHPdata;

    [SerializeField]
    private int score;

    public UnityAction OnScore30;
    


    // Start is called before the first frame update
    void Start()
    {
        score = playerHPdata.Score;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
        if(score == 30)
        {
            OnScore30?.Invoke();
        }
    }
}
