using System.Collections.Generic;
using PhEngine.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SuperGame
{
    public class LevelManager : Singleton<LevelManager>
    {
        [Header("Level")] 
        [SerializeField] int currentLevel = 1;
        public int CurrentLevel => currentLevel;
        
        [SerializeField] int currentScene = 0;
        [SerializeField] List<string> levelList = new List<string>();
        public List<string> LevelList => levelList;

        [SerializeField] HUD hud;
        [SerializeField] string lastPlayedScene;
        
        protected override void InitAfterAwake()
        {
            Reset();
        }

        void Reset()
        {
            currentLevel = 1;
            currentScene = 0;
        }

        public void SetLastPlayedLevel()
        {
            lastPlayedScene = levelList[currentScene];
        }
        
        public void MoveToNextLevel()
        {
            currentLevel++;
            currentScene++;
            if (currentScene >= levelList.Count)
                currentScene = 0;
            
            hud.SetLevel(currentLevel);
            LoadScene(levelList[currentScene]);
        }
        
        public void LoadScene(string sceneName)
        {
             LoadScene("WeatherClear");
            //var loadSceneAsync = SceneManager.LoadSceneAsync(sceneName);
            //loadSceneAsync.completed += (op) => GameManager.Instance.StartLevel();
        }
        public void LoadScene2(string sceneName)
        {
            LoadScene2("WeatherRain");
        }
        public void LoadScene3(string sceneName)
        {
            LoadScene3("WeatherSnow");
        }




        public void LoadFirstLevel()
        {
            //Reset();
            //LoadScene(sceneName: levelList[0]);
        }

        public void RestartCurrentLevel()
        {
            //LoadScene(levelList[currentScene]);
        }
    }
}