using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class mix_levels : MonoBehaviour {

    public AudioMixer masterMixer;

    public void SetSfxLevel(float sfxlvl)
    {
        masterMixer.SetFloat("soundVol", sfxlvl);
    }
    public void SetMusicLevel(float musiclvl)
    {
        masterMixer.SetFloat("musicVol", musiclvl);
    }
}
