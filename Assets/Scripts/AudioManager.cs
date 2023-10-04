
using UnityEngine;


public class AudioManager : MonoBehaviour
{

    private static AudioManager instance;

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

    public static AudioManager Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        // Keeps the correct instance from being destroyed on load
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If there are multiple instances, destroy this one
            Destroy(this);
        }
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
