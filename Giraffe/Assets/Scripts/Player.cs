using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Player : MonoBehaviour
{

Rigidbody rb;
Animator animator;
public TextMeshProUGUI scoreText;

private int score = 0;



    // Start is called before the first frame update
    void Start()
    {

    rb = this.GetComponent<Rigidbody>();
    animator = GetComponentInChildren<Animator>();
  
    }

    // Update is called once per frame
    void Update()
    {
             
      
    if(Input.GetMouseButtonDown(0))
         {
              animator.SetTrigger("HeadUp");
         }
    }
   private void OnTriggerEnter(Collider collider)
        {
        if(collider.gameObject.CompareTag("Coin")) {
            Destroy(collider.gameObject);
            score = score +50;
            scoreText.text = score.ToString();
        }



    }
}
