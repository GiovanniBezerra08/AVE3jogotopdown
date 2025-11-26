using UnityEngine;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour
{
    public Toggle toggle;

    private void Start()
    {
        // Pega o estado inicial baseado no mute atual
        toggle.isOn = !MusicManager.instance.GetComponent<AudioSource>().mute;

        toggle.onValueChanged.AddListener(OnToggleChanged);
    }

    void OnToggleChanged(bool isOn)
    {
        MusicManager.instance.ToggleMusic(isOn);
    }
}