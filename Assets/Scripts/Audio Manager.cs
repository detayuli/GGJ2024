using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace team13
{
    public class AudioManager : MonoBehaviour
    {
        [Header("- - - - - - - Audio Source - - - - - - - ")]
        [SerializeField] AudioSource musicSource;
        [SerializeField] AudioSource SFXSource;

        [Header("- - - - - - - Audio Clip - - - - - - - ")]
        public AudioClip Gameplay;
        public AudioClip ClickButton;
        public AudioClip StoneBroken;
        public AudioClip StoneDuar;


        // Singleton pattern to make AudioManager accessible from other scripts
        private static AudioManager _instance;

        public static AudioManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    // If there is no AudioManager instance, try to find one in the scene
                    _instance = FindObjectOfType<AudioManager>();

                    // If there is still no AudioManager instance, log a warning
                    if (_instance == null)
                    {
                        Debug.LogWarning("AudioManager not found in the scene. Make sure it's added to a GameObject.");
                    }
                }

                return _instance;
            }
        }

        private void Awake()
        {
            // Ensure there is only one instance of AudioManager in the scene
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
                return;
            }

            _instance = this;

            // Don't destroy AudioManager when loading new scenes
            DontDestroyOnLoad(gameObject);
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void PlaySFX(AudioClip clip)
        {
            SFXSource.PlayOneShot(clip);
        }

        public void PlayBGM(AudioClip backgroundmusic)
        {
            musicSource.Stop();
            musicSource.clip = backgroundmusic;
            musicSource.Play();
        }
    }
}
