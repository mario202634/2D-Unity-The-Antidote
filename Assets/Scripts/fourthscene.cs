using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class fourthscene : MonoBehaviour
{
    VideoPlayer video;

    void Awake()
    {
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;


    }


    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene(21);//the scene that you want to load after the video has ended.
    }
}