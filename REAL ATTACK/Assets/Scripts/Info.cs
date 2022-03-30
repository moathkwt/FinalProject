using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Info : MonoBehaviour
{

    public void NextScene()
    {
        SceneManager.LoadScene("Info");
    }

}