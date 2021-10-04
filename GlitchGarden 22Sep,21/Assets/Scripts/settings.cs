using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settings : MonoBehaviour
{
    [SerializeField] Slider volSlider, diffSlider;
    [SerializeField] float defaultVol = .7f;
    [SerializeField] float defaultDiff = 2f;
    // Start is called before the first frame update
    void Start()
    {
        volSlider.value = PPC.GetMasterVolume();

        diffSlider.value = PPC.GetMasterDifficulty();
    }

    // Update is called once per frame
    void Update()
    {
        var musicManager = FindObjectOfType<MusicManager>();
        if(musicManager)
        {
            musicManager.SetVolume(volSlider.value);
        }
        else
        {
            Debug.Log("MusicManager not found... have you stated the gram from the splash screen");
        }
    }


    public void SaveAndExit()
    {
        PPC.SetMasterVolume(volSlider.value);
        PPC.SetMasterDifficulty(diffSlider.value);
        FindObjectOfType<LEvelLoader>().Back();
    }


    public void DefaultValues()
    {
        volSlider.value = defaultVol;
        diffSlider.value = defaultDiff;
    }


}
