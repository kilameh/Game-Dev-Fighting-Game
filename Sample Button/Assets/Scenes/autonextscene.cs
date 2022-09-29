using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class autonextscene : MonoBehaviour
{
    public VideoPlayer videoplayer;

    public void Awake()
    {
        videoplayer=GetComponent<VideoPlayer>();
        videoplayer.loopPointReached += checkover;
    }

    public void checkover(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene(6);
    }
    
}
