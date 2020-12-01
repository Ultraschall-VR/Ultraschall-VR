﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Audiocards : MonoBehaviour {
    AudioSource _audioSource;

    void Start() {
        _audioSource = GetComponent<AudioSource>();
    }

    void Update() {
        _audioSource.Play();
    }
}
