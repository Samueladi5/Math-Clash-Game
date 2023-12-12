using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Controls : MonoBehaviour
{
    public Slider Slider;
    public AudioMixer mixer;
    private float value;

    public void Start()
    {
        mixer.GetFloat("volume", out value);
        Slider.value = value;
    }

    public void SetVolume()
    {
        mixer.SetFloat("volume", Slider.value);
    }
}
