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

    [SerializeField]
    private AudioSource _pullLever;

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
        _walk.Play();
    }

    public void PlayDie()
    {
        _die.Play();
    }

    public void PlayVictory()
    {
        _victory.Play();
    }

    public void PlayKeyPickup()
    {
        _keyPickup.Play();
    }

    public void PlayDoor()
    {
        _door.Play();
    }

    public void PlayPullLever()
    {
        _pullLever.Play();
    }

}
