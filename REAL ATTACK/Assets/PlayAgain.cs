using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public GameObject Youwin;
    // Start is called before the first frame update
    void Start()
    {
        Youwin.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Youwin.SetActive(true);
        }


    }
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start");
    }
    public void GoToLevels()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Levels");
    }
    public void playagain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Lv1");
    }
}
