using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherManager : MonoBehaviour

{

    [Header("Snow")]

    [SerializeField] private GameObject Snow;
  
    public Vector3 boxSize = new Vector3( 5f, 5f , 1.0f); 


    [Header("Rain")]

    [SerializeField] private GameObject Rain;

    [Header("Clear")]

    [SerializeField] private GameObject Clear; 

    [Header("StarFall")]

    [SerializeField] private GameObject StarFall;
    
    [Header("NightSkyBox")]

    [SerializeField] private GameObject NightSkybox;
    
    [Header("Day")]

    [SerializeField] private GameObject DaySkyBox;

    
    
    private void Awake() 
    {
        Snow.SetActive(false);
        Rain.SetActive(false);
        StarFall.SetActive(false);
        NightSkybox.SetActive(false);
    
    }
    
    
    public void ActivateRain()

    {
        
        Snow.SetActive(false);
        Rain.SetActive(true);
           
    }

    public void ActivateSnow()

    {
        Snow.SetActive(true);
        Rain.SetActive(false);
    }

    public void ActivateClear()

    {
        Snow.SetActive(false);
        Rain.SetActive(false);
    }
    public void Night()

    {

        StarFall.SetActive(true);
        DaySkyBox.SetActive(false);
        NightSkybox.SetActive(true);


    }
    public void Day()
    {
        StarFall.SetActive(false);
        NightSkybox.SetActive(false);
        DaySkyBox.SetActive(true);
        
    }

    


}
