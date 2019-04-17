using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsScript : MonoBehaviour
{
    AudioSource[] audioSources;

    void Start()
    {
        audioSources = GetComponents<AudioSource>();
    }

    void Update()
    {
        AudioSource winner = null;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            float winnerRatio = 0;
            for (int i = 0; i < audioSources.Length; i++)
            {
                if (audioSources[i].isPlaying == false)
                {
                    winner = audioSources[i];
                    break;
                }
                else
                {
                    float currentSoundCompletionRatio = audioSources[i].time / audioSources[i].clip.length;
                    if (currentSoundCompletionRatio > winnerRatio)
                    {
                        winner = audioSources[i];
                        winnerRatio = currentSoundCompletionRatio;
                    }
                }
            }
            if (winner)
            {
                winner.Play();
            }
        }
    }
}
