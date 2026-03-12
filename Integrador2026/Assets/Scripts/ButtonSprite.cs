using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSprite : MonoBehaviour
{
    public Button[] Botoes;
    public Sprite[] sprites;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.touchCount == 1)
        {
            if (Botoes != null && Botoes.Length > 1 && sprites != null && sprites.Length > 0)
            {
                Image img = Botoes[0].GetComponent<Image>();
                if (img != null)
                {
                    img.sprite = sprites[0];
                }
            }

            if (Botoes != null && Botoes.Length > 2 && sprites != null && sprites.Length > 1)
            {
                Image img = Botoes[1].GetComponent<Image>();
                if (img != null)
                {
                    img.sprite = sprites[0];
                }
            }
        }
    }
}
