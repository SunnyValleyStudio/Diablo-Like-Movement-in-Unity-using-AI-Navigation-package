using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeAudioSource : MonoBehaviour
{
    public AudioSource _source;

    void Start()
    {
        _source.time = Random.Range(0f, _source.clip.length);
        _source.loop = true;
        _source.Play();
    }
}
