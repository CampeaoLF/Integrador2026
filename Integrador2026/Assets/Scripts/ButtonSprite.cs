using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSprite : MonoBehaviour
{
    public Button[] buttons;
    public Sprite[] sprites;
    public GameObject Player;

    void Start()
    {

    }

    void Update()
    {

    }

    public void Apertar()
    {
        var sprite = Player.GetComponent<SpriteRenderer>();
        sprite.sprite = sprites[1];
        
        if(Input.touchCount == 1 && buttons[0])
        {
            var sprite1 = Player.GetComponent<SpriteRenderer>();
            sprite1.sprite = sprites[1];
           

        }
        while(Input.touchCount == 1 && buttons[1])
        {
            var sprite2 = Player.GetComponent<SpriteRenderer>();
            sprite2.sprite = sprites[0];
        }
    }


   
    
        
   
    
        
    
}