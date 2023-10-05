using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Info : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] GUIStyle style;
   [SerializeField] GUIStyle style2;

    [SerializeField] string score_;
    [SerializeField] string time_;
    [SerializeField] GameObject Ball;

    
    private void Update()
    {
        score_ = Ball.GetComponent<Ball_Script>().score.ToString();
        time_= Ball.GetComponent<Ball_Script>().time.ToString();

    }
    private void OnGUI()
    {
       GUI.Label(new Rect(100, 100, 1000, 200), "Score: " + score_, style);
       GUI.Label(new Rect(100, 200, 1000, 200), "Time:  " + time_, style2);
    }
}
