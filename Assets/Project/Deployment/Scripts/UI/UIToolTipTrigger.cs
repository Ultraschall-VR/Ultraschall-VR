﻿using System.Collections;
using Echosystem.Resonance.Game;
using UnityEngine;

namespace Echosystem.Resonance.UI
{
    public class UIToolTipTrigger : MonoBehaviour
    {
        [SerializeField] private ToolTipps.Tooltip _tooltip;

        [SerializeField] private GameProgress.GameProgressPower _learnedPower;
        private ToolTipps _toolTipps;

        private bool _isTriggered;


        [SerializeField] private float _delay;
        
        private void Start()
        {
            Invoke("Initialize", 0.01f);
        }

        private void Initialize()
        {
            _toolTipps = FindObjectOfType<ToolTipps>();
        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") && !_isTriggered)
            {
                _isTriggered = true;
                _toolTipps.ShowToolTipp(_tooltip);

                ActivatePower(_delay);
            }
        }

        private void ActivatePower(float delay)
        {
            StartCoroutine(ActivatePowerWithDelay(delay));
        }

        private IEnumerator ActivatePowerWithDelay(float delay)
        {
            yield return new WaitForSeconds(delay);
            
            switch (_learnedPower)
            {
                case GameProgress.GameProgressPower.Echoblaster:

                    GameProgress.Instance.LearnedEchoblaster = true;
                    GameProgress.Instance.SetPower();
                    break;

                case GameProgress.GameProgressPower.Grab:

                    GameProgress.Instance.LearnedGrab = true;
                    GameProgress.Instance.SetPower();
                    break;

                case GameProgress.GameProgressPower.Teleport:

                    GameProgress.Instance.LearnedTeleport = true;
                    GameProgress.Instance.SetPower();
                    break;

                case GameProgress.GameProgressPower.Uncover:

                    GameProgress.Instance.LearnedUncover = true;
                    GameProgress.Instance.SetPower();
                    break;

                case GameProgress.GameProgressPower.None:
                    break;
            }
            
            yield return null;
        }
    }
}