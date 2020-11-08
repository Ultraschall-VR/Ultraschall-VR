﻿using System;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class PlayerSpawner : MonoBehaviour
{
    public bool NonVR;
    public bool IsMenu;

    [SerializeField] private GameObject _vrPlayerPrefab;
    [SerializeField] private GameObject _nonVrPlayerPrefab;
    [SerializeField] private Transform _playerSpawn;

    [Header("Settings")] [SerializeField] private bool _joystickMovement;
    [SerializeField] private float _joystickMovementSpeed;
    [SerializeField] private bool _teleportMovement;
    [SerializeField] private float _teleportMaxRange;
    [SerializeField] private float _teleportMovementSpeed;
    [SerializeField] private bool _loadWholeGame;

    [SerializeField] private bool _invisiblePlayer;

    [HideInInspector] public GameObject PlayerInstance = null;

    public static PlayerSpawner Instance;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        if (NonVR)
        {
            InstantiatePlayer(_nonVrPlayerPrefab, _playerSpawn.position, _playerSpawn.rotation);
        }
        else
        {
            InstantiatePlayer(_vrPlayerPrefab, _playerSpawn.position, _playerSpawn.rotation);
        }
    }

    public void InstantiatePlayer(GameObject playerPrefab, Vector3 position, Quaternion rotation)
    {
        if (!FindObjectOfType<PlayerMovement>())
        {
            PlayerInstance = Instantiate(playerPrefab, position, rotation);
            PlayerInstance.name = _vrPlayerPrefab.name;
        }
        else
        {
            PlayerInstance = FindObjectOfType<PlayerMovement>().gameObject;
            PlayerInstance.transform.position = position;
            PlayerInstance.transform.rotation = rotation;
        }

        if (NonVR)
        {
            return;
        }

        if (_invisiblePlayer)
        {
            PlayerInstance.GetComponent<PlayerInput>().ControllerLeft.gameObject.SetActive(false);
            PlayerInstance.GetComponent<PlayerInput>().ControllerRight.gameObject.SetActive(false);
        }
        else
        {
            PlayerInstance.GetComponent<PlayerInput>().ControllerLeft.gameObject.SetActive(true);
            PlayerInstance.GetComponent<PlayerInput>().ControllerRight.gameObject.SetActive(true);
        }

        PlayerInstance.GetComponent<ControllerManager>().SceneLoader.LoadFirstScene = _loadWholeGame;
        PlayerInstance.GetComponent<PlayerMovement>().JoystickMovement = _joystickMovement;
        PlayerInstance.GetComponent<PlayerMovement>().TeleportEnabled = _teleportMovement;
        PlayerInstance.GetComponent<PlayerMovement>().JoystickMovementSpeed = _joystickMovementSpeed;
        PlayerInstance.GetComponent<PlayerMovement>().TeleportMovementSpeed = _teleportMovementSpeed;
        PlayerInstance.GetComponent<PlayerMovement>().TeleportMaxRange = _teleportMaxRange;
        
        
    }

    public void MovePlayer(Vector3 position, Quaternion rotation)
    {
        PlayerInstance.transform.position = position;
        PlayerInstance.transform.rotation = rotation;
    }
}