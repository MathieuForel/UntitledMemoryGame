using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public AudioMixer Music;
    public AudioMixer Sound;

    public void SetMusicVolume(float SliderMusicValue)
    {
        Music.SetFloat("MusicVolume", Mathf.Log10(SliderMusicValue) * 20);
    }

    public void SetSoundVolume(float SliderSoundValue)
    {
        Sound.SetFloat("SoundVolume", Mathf.Log10(SliderSoundValue) * 20);
    }
}
