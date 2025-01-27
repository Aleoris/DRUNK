﻿using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class PauseMenu : Menu
    {
        [SerializeField] private GameObject pausePanel;
        private GameObject drinkChoiceCanvas;

        private void Start()
        {
            drinkChoiceCanvas = GameObject.Find("DrinkChoiceCanvas");
        }
        
        private void Update()
        {
            UpdatePauseStatus();
        }

        private void UpdatePauseStatus()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = drinkChoiceCanvas.activeSelf ? 0 : 1;
                pausePanel.SetActive(!pausePanel.activeSelf);
                Cursor.visible = true;

                if (!pausePanel.activeSelf)
                {
                    UnpauseGame();
                }
            }
        }

        public void UnpauseGame()
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = false;
            
            Time.timeScale = 1;
            pausePanel.SetActive(false);
            
            if (drinkChoiceCanvas.GetComponent<DrinkChoice>().wasActive)
            {
                drinkChoiceCanvas.transform.Find("Menu").gameObject.SetActive(true);
            }
            
        }

        public void Quit2MainMenu()
        {
            Time.timeScale = 1;
            Cursor.visible = true;
            pausePanel.SetActive(false);
            SceneManager.LoadScene(0);
        }
    }
}
