using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Menu : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Button start_button;
    void Start()
    {
        Time.timeScale = 0;
        start_button.onClick.AddListener(start_game);
    }

    void start_game()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    
}
