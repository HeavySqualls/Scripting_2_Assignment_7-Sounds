using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsScript : MonoBehaviour
{
    AudioSource[] AvailableAudioSources;
    AudioSource[] NowPlayingAudioSources;

    void Start()
    {
        AvailableAudioSources = GetComponents<AudioSource>();
        NowPlayingAudioSources = new AudioSource[AvailableAudioSources.Length];
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
        }
    }
}
