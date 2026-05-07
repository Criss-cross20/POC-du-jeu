using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour
{
    public AudioSource introMusic;   // Premiere music
    public AudioSource loopMusic;    // Deuxieme
    public float fadeDuration = 3f;  // seconds

    private bool hasTransitioned = false;

    void Start()
    {
        // Intro starts automatically (Play On Awake on introMusic)
        // Ensure volumes are set correctly
        introMusic.volume = 1f;
        loopMusic.volume = 0f;
    }

    public void TriggerMusicTransition()
    {
        if (!hasTransitioned)
        {
            StartCoroutine(FadeToLoop());
            hasTransitioned = true;
        }
    }

    private IEnumerator FadeToLoop()
    {
        loopMusic.Play();

        float elapsed = 0f;
        float startIntroVol = introMusic.volume;
        float startLoopVol = loopMusic.volume;

        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / fadeDuration;

            introMusic.volume = Mathf.Lerp(startIntroVol, 0f, t);
            loopMusic.volume = Mathf.Lerp(startLoopVol, 1f, t);

            yield return null;
        }

        introMusic.volume = 0f;
        loopMusic.volume = 1f;
        introMusic.Stop();
    }
}
