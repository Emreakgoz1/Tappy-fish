using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour
{
    int score;
    public  TextMeshProUGUI score_Text;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        score_Text = GetComponent<TextMeshProUGUI>();
        score_Text.text = score.ToString();
        
    }
    public void Scored()
    {
        score++;
        score_Text.text = score.ToString();
    }
}
