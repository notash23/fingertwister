using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    public Text txet;
    
    public void joke()
    {
        StartCoroutine(waiter());
    }

    
   IEnumerator waiter()
    {
        txet.enabled = true;
        txet.text = "Hmm...cannot access options";
        yield return new WaitForSeconds(2);
        txet.text = "Oh i see";
        yield return new WaitForSeconds(1);
        txet.text = "There is no other option";
        yield return new WaitForSeconds(2);
        txet.text = "One shall prevail";
        yield return new WaitForSeconds(1);
        txet.enabled = false;
    }

}
