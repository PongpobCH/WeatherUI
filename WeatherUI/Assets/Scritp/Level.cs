using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;





public class Level : MonoBehaviour 
    

{

    public Text ValueTxt; 

    private void Start()
    {
        ValueTxt.text = WeatherManager.Instance.Value.ToString();
    }

    public void GotoFirstScene()
    {
        SceneManager.LoadScene("first");
        WeatherManager.Instance.Value++;
    }

    public void GotoSecondScene()
    {
        SceneManager.LoadScene("second");
        WeatherManager.Instance.Value++;
    }

}
