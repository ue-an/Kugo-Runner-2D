using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource sceneMusic;
    public AudioSource deathsMusic;

    public bool sceneSong;
    public bool deathsSong;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneMusic()
    {
        sceneSong = true;
        deathsSong = false;
        sceneMusic.Play();
    }

    public void DeathSound()
    {
        if (sceneMusic.isPlaying)
            sceneSong = false;
        {
            sceneMusic.Stop();
        }

        if(!deathsMusic.isPlaying && deathsSong == false)
        {
            deathsMusic.Play();
            deathsSong = true;
        }
    }
}
