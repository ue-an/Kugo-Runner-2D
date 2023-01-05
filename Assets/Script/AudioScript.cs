using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioScript : MonoBehaviour
{
    private GameObject[] MusicObject;

   //public Slider volumemixer;
   // public AudioMixer audioMixer;

   // public void setVolume()
   // {
   //     audioMixer.SetFloat("Volume", volumemixer.value);
   // }

    private void Awake()
    {
        MusicObject = GameObject.FindGameObjectsWithTag("BGMusic");

        if(MusicObject .Length  >=2)
            {
            Destroy(MusicObject[1]);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
