using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance = null;

    public AudioSource playerSFX;
    public AudioSource backgroundMusic;
    public AudioSource enemySFX;
    public AudioSource otherSFX;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void PlayPlayerSFX(AudioClip sound)
    {
        playerSFX.clip = sound;
        playerSFX.Play();
    }

    public void PlayEnemySFX(AudioClip sound)
    {
        enemySFX.clip = sound;
        enemySFX.Play();
    }

    public void PlayOtherSFX(AudioClip sound)
    {
        otherSFX.clip = sound;
        otherSFX.Play();
    }

    public void PlayBackgroundMusic(AudioClip sound)
    {
        backgroundMusic.clip = sound;
        backgroundMusic.loop = true;
        backgroundMusic.Play();
    }
}
