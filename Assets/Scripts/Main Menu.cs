using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace team13
{
    public class MainMenu : MonoBehaviour
    {

        AudioManager audioManager;

        // Start is called before the first frame update
        void Start()
        {
            AudioManager.Instance.PlayBGM(AudioManager.Instance.Gameplay);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void PlayGame()
        {
            SceneManager.LoadSceneAsync("Game");
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
