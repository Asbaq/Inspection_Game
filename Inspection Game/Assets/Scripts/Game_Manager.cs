using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
       public GameObject Canvas;

     public void PlayGame()
    {
        Canvas.SetActive(false);
    }
    
    private void OnMouseDown()
    {
       Canvas.SetActive(true);
    }
 }