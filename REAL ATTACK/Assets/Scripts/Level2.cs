using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene("Lv2");
    }
}
