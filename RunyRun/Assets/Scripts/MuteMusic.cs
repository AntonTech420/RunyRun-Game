using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuteMusic : MonoBehaviour
{
    [SerializeField]
    KeyCode MutingMusic;

    [SerializeField]
    AudioSource background;
    

    private float isMuted;




    // Start is called before the first frame update
    void Start()
    {
        isMuted = 1;
    }

    // public void MutePressed()
    // {
    //     isMuted = !isMuted;
    //     AudioListener.pause = isMuted;
    // }
    void Update()
    {
        if(Input.GetKey(MutingMusic)&& isMuted ==0)
        {
            isMuted = 1.0f;
            AudioListener.volume = isMuted;
        }
        if(Input.GetKey(MutingMusic)&& isMuted ==1.0f)
        {
            isMuted = 0;
            AudioListener.volume = isMuted;
        }
    }

    // public AudioListener Mute;
 
    //  void Start()
    //  {
    //      //Reference to the AudioListener component on the object
    //      Mute = GetComponent<AudioListener>();
    //  }
 
    //  void Update()
    //  {
    //      //Toggles sound on/off by pressing 'M'
    //      if (Input.GetKey(KeyCode.M) && Mute.enabled == true)
    //      {
    //          Mute.enabled = false;
    //      }
    //      if (Input.GetKey(KeyCode.M) && Mute.enabled == false)
    //      {
    //          Mute.enabled = true;
    //      }
    //  }
}
