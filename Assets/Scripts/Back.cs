using UnityEngine.SceneManagement;
using UnityEngine;

public class Back : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
}
