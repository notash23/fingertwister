using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class textchange : MonoBehaviour
{
    List<string> list = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    public Text number;
    public Text player;
    public int r;
    public int fingercount;
    public string fingernum;
    public Text finger;
    public bool tapped = true;
    public int count;
    void Start()
    {
        Invoke("Buttonpress", 2.0f);
    }

    void Update()
    {
        if (number.text == "Now for the next button...")
        { 
            if (fingercount != 9 && !tapped)
            {
                Invoke("Buttonpress", 1.0f);
                tapped = true;
            }

            if (fingercount >= 9)
            {
                Invoke("endbutton", 2.0f);
            }
        }
    }



    void endbutton()
    {
        number.text = "Now to finish the game...";
    }

    void Buttonpress()
    {
        count += 1;
        fingercount += 1;
        fingernum = fingercount.ToString();
        finger.text = "Finger On Screen: " + fingernum;
        r = Random.Range(0, list.Count);
        player.text = "Player " + (count % 2+1);
        number.text = "Press the button " + list[r];
        list.Remove(list[r]);
        tapped = false;
    }





}
