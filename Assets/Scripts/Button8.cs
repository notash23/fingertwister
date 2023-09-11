using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class Button8 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler

{

    public bool buttonPressed;
    public Text txt;
    public Text playertext;
    public string player;
    private bool buttonhaspressed;
    public Image image;



    void Update()
    {
        if (txt.text == "Press the button 8")
        {
            image.color = Color.white;
            if (buttonPressed)
            {
                image.color = Color.yellow;
                txt.text = "Now for the next button...";
                buttonhaspressed = true;
            }
        }

        if (buttonhaspressed && !buttonPressed)

        {
            if (player == "Player 2")
            {
                txt.text = "Game Over Player One wins";
            }
            else
            {
                txt.text = "Game Over Player Two wins";
            }
        }
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }



    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }

}