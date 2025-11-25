using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip backgroundMusic;

    void Start()
    {
        audioSource.clip = backgroundMusic;
        audioSource.loop = true;
        audioSource.Play();
    }
}