using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;

    private AudioSource audioSource;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        audioSource = GetComponent<AudioSource>();
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;   // volume entre 0 e 1
    }

    public void ToggleMusic(bool isOn)
    {
        audioSource.mute = !isOn;      // mute se isOn = false
    }

    public float GetVolume()
    {
        return audioSource.volume;
    }

    public bool IsMusicOn()
    {
        return !audioSource.mute;
    }
}