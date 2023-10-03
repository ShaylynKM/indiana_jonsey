using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class AudioManager : MonoBehaviour
{
    #region Singleton

    private static AudioManager _audioInstance;
    public static AudioManager AudioInstance {  get { return _audioInstance; } }

    #endregion

    [SerializeField]
    private AudioSource _walk;

    [SerializeField]
    private AudioSource _die;

    [SerializeField]
    private AudioSource _victory;

    [SerializeField]
    private AudioSource _keyPickup;

    [SerializeField]
    private AudioSource _door;

    void Start()
    {
        
    }

    private void Awake()
    {
        // Keeps the AudioManager from being destroyed when the scene changes
        if(AudioInstance != this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void PlayWalk()
    {

    }

    public void PlayDie()
    {

    }

    public void PlayVictory()
    {

    }

    public void PlayKeyPickup()
    {

    }

    public void PlayDoor()
    {

    }

}
