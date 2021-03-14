using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class buttonManager1 : MonoBehaviour
{
    public GameObject sphere;
    public VideoClip clip01;
    public VideoClip clip02;
    public GameObject button01;
    public GameObject button02;

    public void toVideoScene()
    {
        SceneManager.LoadScene("360Video");
    }
    
    public void goIn()
    {
        button01.SetActive(false);
        button02.SetActive(true);
        sphere.GetComponent<VideoPlayer>().clip = clip02;
    }
    public void goOut()
    {
        button01.SetActive(true);
        button02.SetActive(false);
        sphere.GetComponent<VideoPlayer>().clip = clip01;
    }
}
