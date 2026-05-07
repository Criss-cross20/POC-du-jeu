using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public MusicManager musicManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            musicManager.TriggerMusicTransition();
        }
    }
}
