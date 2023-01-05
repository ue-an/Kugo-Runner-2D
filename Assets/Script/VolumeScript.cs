using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeScript : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumemixer;
    public float value;
    public void setVolume ()
    {
        audioMixer .SetFloat ("Volume", volumemixer.value);
    }

    // Start is called before the first frame update
    void Start()
    {
        audioMixer.GetFloat("Volume", out value);
        volumemixer.value = value;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
