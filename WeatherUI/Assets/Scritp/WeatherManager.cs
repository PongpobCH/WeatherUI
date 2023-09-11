using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class WeatherManager : MonoBehaviour
{
    public static WeatherManager Instance {get; private set;}

    public int Value; 
    


 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 private void Awake() 
 
    { 
        if (Instance == null)
        {

            Instance = this; 
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }

        
    }



 }

