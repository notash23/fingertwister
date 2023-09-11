using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class end : MonoBehaviour, IPointerDownHandler, IPointerUpHandler

{
    public bool buttonPressed;
    public Text txt;
    private bool buttonhaspressed;



    void Update()
    {
        if (txt.text == "Now to finish the game...")
        {
            if (buttonPressed)
            {
                txt.text = "Congratulation! No one is a loser today!";
                Invoke("quit",2.0f);
            }
        }
        if (buttonhaspressed && !buttonPressed)
        {
            txt.text = "Game Over";
        }
    }

    public void quit()
    {
        Application.Quit();
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
