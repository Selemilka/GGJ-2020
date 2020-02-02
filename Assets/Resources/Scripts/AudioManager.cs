using UnityEngine.Audio;
using System;
using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{
	public static AudioManager instance;

	public AudioMixerGroup mixerGroup;

	public Sound[] sounds;

	void Awake()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}

		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.loop = s.loop;

			s.source.outputAudioMixerGroup = mixerGroup;
		}

        Play(AudioNames.MusicB);
	}

	public void Play(string sound, bool restart = true, float fadeTime = 0)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}

        if (restart || !s.source.isPlaying)
        {
		    s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
		    s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));
            s.source.spatialBlend = s.spatialBlend;
            StartCoroutine(FadeIn(s.source, fadeTime));
            //s.source.Play();
        }

	}

    public void Stop(string sound, float fadeTime = 0)
    {
        Sound s = Array.Find(sounds, item => item.name == sound);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
        s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));
        s.source.spatialBlend = s.spatialBlend;

        StartCoroutine(FadeOut(s.source, 0.1f));
        //s.source.Stop();
    }

    public IEnumerator FadeIn(AudioSource audioSource, float fadeTime)
    {
        if (fadeTime <= 0)
        {
            audioSource.Play();
            yield return null;
        }
        else
        {
            float targetVolume = audioSource.volume;
            audioSource.volume = 0;
            audioSource.Play();
            while (audioSource.volume < targetVolume)
            {
                audioSource.volume += targetVolume * Time.deltaTime / fadeTime;
                yield return null;
            }
            audioSource.volume = targetVolume;
        }
    }

    public IEnumerator FadeOut(AudioSource audioSource, float fadeTime)
    {
        if (fadeTime <= 0)
        {
            audioSource.Stop();
            yield return null;
        }
        else
        {
            float startVolume = audioSource.volume;
            while (audioSource.volume > 0)
            {
                audioSource.volume -= startVolume * Time.deltaTime / fadeTime;
                yield return null;
            }
            audioSource.volume = startVolume;
        }
        audioSource.Stop();
    }
}
