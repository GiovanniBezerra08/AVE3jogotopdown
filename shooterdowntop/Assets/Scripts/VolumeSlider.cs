using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        slider.onValueChanged.AddListener(value =>
        {
            MusicManager.instance.SetVolume(value);
        });
    }
}