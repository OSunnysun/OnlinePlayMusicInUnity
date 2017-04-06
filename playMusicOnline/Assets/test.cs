using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    public string url;
    public AudioSource source;
    void Start()
    {
        WWW www = new WWW(url);
        source = GetComponent<AudioSource>();
        source.clip = www.audioClip;
    }
    void Update()
    {
        Debug.Log(source.clip);
        Debug.Log(source.isPlaying);
        Debug.Log(source.clip.isReadyToPlay);
        if (!source.isPlaying && source.clip.isReadyToPlay)
        {
            source.Play();
          
        }
    }
}
