using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Audio Sources")]
    public AudioSource bgmSource;   // looped background music
    public AudioSource sfxSource;   // short sound effects

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void PlayBGM(AudioClip clip, float volume = 1f, bool loop = true)
    {
        if (bgmSource == null || clip == null) return;
        bgmSource.clip = clip;
        bgmSource.volume = volume;
        bgmSource.loop = loop;
        bgmSource.Play();
    }

    public void StopBGM()
    {
        if (bgmSource != null)
            bgmSource.Stop();
    }

    public void PlaySFX(AudioClip clip, float volume = 1f)
    {
        if (sfxSource == null || clip == null) return;
        sfxSource.PlayOneShot(clip, volume);
    }
}
