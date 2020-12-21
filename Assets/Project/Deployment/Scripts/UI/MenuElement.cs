﻿using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class MenuElement : MonoBehaviour
{
    private TextMeshProUGUI _text;
    [SerializeField] private Color _defaultColor;
    [SerializeField] private Color _highlightColor;
    [SerializeField] private AudioClip _highlightSound;
    [SerializeField] private Color _selectColor;
    [SerializeField] private AudioClip _selectSound;
    [SerializeField] private List<MonoBehaviour> _selectActions;

    private AudioSource _audioSource;
    private bool _audioPlaying = false;

    [HideInInspector] public bool Highlighted = false;
    [HideInInspector] public bool Selected = false;
    
    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        _text.faceColor = _defaultColor;
        _audioSource = GetComponent<AudioSource>();
    }

    public void Highlight()
    {
        _text.faceColor = _highlightColor;
        
        _audioSource.PlayOneShot(_highlightSound);
        
    }

    public void DeHighlight()
    {
        _text.faceColor = _defaultColor;
    }

    public void Select()
    {
        _text.faceColor = _selectColor;
        
        _audioSource.PlayOneShot(_selectSound);

        foreach (var action in _selectActions)
        {
            action.enabled = true;
            action.enabled = false;
        }
    }
}
