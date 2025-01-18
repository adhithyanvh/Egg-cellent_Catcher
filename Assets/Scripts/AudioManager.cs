using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource musicSource2;

    [SerializeField] AudioSource SFXSource;

    public AudioClip home;
    public AudioClip background;
    public AudioClip farmbg;
    public AudioClip miss;
    public AudioClip collect;
    public AudioClip wrongEgg;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();

        musicSource2.clip = farmbg;
        musicSource2.Play();

    }

    public void PlaySfx(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
