using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance;
    public static AudioManager Instance
    {
        get { return _instance; }
        set
        {
            _instance = value;
        }
    }
    public AudioClip[] backGrounds;
    public AudioClip _soundFx;
    public AudioSource backgroundMusic;
    public AudioSource soundFx;
    private void Start()
    {
        if(_instance== null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }      
    }
    public void PlayBackGroundMusic(AudioClip clip)
    {
        backgroundMusic.clip = clip;
        backgroundMusic.Play();
    }
    public void PlaySoundEffectMusic(AudioClip clip)
    {
        soundFx.PlayOneShot(clip);
    }
    public void BackGroundMusic()
    {
        PlayBackGroundMusic(backGrounds[Random.Range(0,backGrounds.Length)]);
    }
    public void SoundEffectMusic()
    {
        PlaySoundEffectMusic(_soundFx);
    }
}
