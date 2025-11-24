using UnityEngine;
using UnityEngine.Video;

public class VideoTrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public void PlayIntroVideo()
    {
        if (videoPlayer == null) return;
        videoPlayer.Play();
    }

    public void StopVideo()
    {
        if (videoPlayer == null) return;
        videoPlayer.Stop();
    }
}
