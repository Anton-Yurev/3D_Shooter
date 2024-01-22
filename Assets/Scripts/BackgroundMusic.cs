using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    AudioSource music;
    private void Start()
    {
        music = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        Pause.OnPauseOn += MuteAudio;
        Pause.OnPauseOff += PlayAudio;
    }
    private void OnDisable()
    {
        Pause.OnPauseOn -= MuteAudio;
        Pause.OnPauseOff -= PlayAudio;
    }

    private void MuteAudio()
    {
        music.Pause();
    }
    private void PlayAudio()
    {
        music.Play();
    }

}
