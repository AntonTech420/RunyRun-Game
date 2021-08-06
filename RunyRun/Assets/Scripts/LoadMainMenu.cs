using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    KeyCode KeyMainMenu;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyMainMenu))
            SceneManager.LoadScene("Main Menu");
        
    }
}

