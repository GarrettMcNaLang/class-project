using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource audio;
    public static GameManager Instance;
    private float defaultPitch;
    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this; //Instance requires a variable otherwise it equals null
        }

        defaultPitch = audio.pitch;

        DontDestroyOnLoad(this.gameObject);
    }
    //shortcut that is less expensive
   public void PauseMusic()
    {
        audio.pitch = 0;
    }

    public void UnPauseMusic()
    {
        audio.pitch = defaultPitch;
    }
}
