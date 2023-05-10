using UnityEngine;

public class GameManager : MonoBehaviour
{
  
public GameObject completeLevelUI;
public GameObject TopScreen;
public GameObject Tutor;


 public void CompleteLevel ()
 {
     completeLevelUI.SetActive(true);
      TopScreen.SetActive(false);
 }
    

 void Update()
    {    
      
    if(Input.GetKeyDown("space"))
         {
              Tutor.SetActive(false);
              TopScreen.SetActive(true);
         }
    
 

}
}