using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] public GameObject player;
    [SerializeField] public GameManager gameManager;


    [Header("Botão")]
    [SerializeField] public Button[] buttons;

    [Header("Sprite")]
    [SerializeField] public Sprite[] sprites;
    [SerializeField] public Sprite[] cenario;


    void Start()
    {
        
       

    }


    void Update()
    {

        if (gameManager.score >= 5 && cenario[0])
        {

            var scenarioAtual = gameManager.background.GetComponent<SpriteRenderer>();
            scenarioAtual.sprite = cenario[0];
        }
        if (gameManager.score >= 10 && cenario[1])
        {
            var scenarioAtual = gameManager.background.GetComponent<SpriteRenderer>();
            scenarioAtual.sprite = cenario[1];
        }



    }

    public void Apertar()
    {
        if (Input.touchCount == 1 && buttons[0])
        {
            
            var spriteAtual = player.GetComponent<SpriteRenderer>();
            spriteAtual.sprite = sprites[0];
            gameManager.GainPoints(1);

           

        }
        
    }

    public void Apertar2()
    {
        if (Input.touchCount == 1 && buttons[1])
        {
            
            var spriteAtual = player.GetComponent<SpriteRenderer>();
            spriteAtual.sprite = sprites[1];
            gameManager.GainPoints(1);

        }

    }

    public void Apertar3()
    {
        if (Input.touchCount == 1 && buttons[2])
        {
            
            var spriteAtual = player.GetComponent<SpriteRenderer>();
            spriteAtual.sprite = sprites[2];
            gameManager.GainPoints(1);

        }

    }
    
    public void ChangeScenario()
    {
       
    }
}
