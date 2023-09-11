using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class changescene : MonoBehaviour
{
    public Animator transition;
    public void StartGame()
    {
        StartCoroutine(transitioner());
    }
    IEnumerator transitioner()
    {
        transition.SetTrigger("start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }

}