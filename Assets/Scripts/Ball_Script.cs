using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Script : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public int score = 0;
    [SerializeField] public int time;
        float time_delta;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time_delta += Time.deltaTime;
        time =(int)(time_delta % 60);
    }
}
