using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cheat_menu : MonoBehaviour
{
    [SerializeField] Button openCheat_menu;
    [SerializeField] GameObject Music_Off;

     int Music_OffClickCount = 0;


     void Start()
    {
               openCheat_menu.onClick.AddListener(OpenClicked);
    }
       
    
     void OpenClicked()
    {
             
        Music_OffClickCount++;
        if (Music_OffClickCount >= 2)
        {
            Time.timeScale = 0;
            Music_OffClickCount = 0;
            Music_Off.SetActive(true);
        }
    }

    
}
