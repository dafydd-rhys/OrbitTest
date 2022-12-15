using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeScript : MonoBehaviour
{

    public AudioSource Audio;
    public Sprite OnImage;
    public Sprite OffImage;

    public void Togglemute()
    {

        Audio.mute = !Audio.mute;

        if (Audio.mute)
            ((Image)this.GetComponent<Button>().targetGraphic).sprite = OffImage;

        else
            ((Image)this.GetComponent<Button>().targetGraphic).sprite = OnImage;
        
    }

}
