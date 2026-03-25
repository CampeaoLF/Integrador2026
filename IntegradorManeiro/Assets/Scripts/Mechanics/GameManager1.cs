using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int score = 0;
    [SerializeField] public GameObject background;
    [SerializeField] public TextMeshProUGUI scoreNumber;


    void Start()
    {
        
    }


    void Update()
    {
        scoreNumber.text = score.ToString();
    }

    public void GainPoints(int value)
    {
        score = score + value;
    }
}
