using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
 
public Animator animator;
public GameObject completeLevelUI;
public GameObject TopScreen;
public GameObject Tutor;
public GameObject CheatMenu;

public void Reset ()
{
    SceneManager.LoadScene("Level_1");
}

 public void CompleteLevel ()
 {
     completeLevelUI.SetActive(true);
     TopScreen.SetActive(false);
       animator.Play("Camera_movement");
     
 }
    

 void Update()
    {
        // Input.GetKeyDown("space")
        if (Input.GetMouseButtonDown(0)) 
         {
              Tutor.SetActive(false);
              TopScreen.SetActive(true);
         }
    
     if (Input.GetMouseButtonDown(0))
         {
             CheatMenu.SetActive(true);
         }
 
        
}
}