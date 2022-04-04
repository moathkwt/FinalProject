using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinvalue : MonoBehaviour
{
    public static coinvalue instance;
    public TextMeshProUGUI text;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

   public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = score.ToString();
    }
}
