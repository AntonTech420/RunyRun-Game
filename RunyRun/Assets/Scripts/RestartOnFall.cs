using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnFall : MonoBehaviour
{
  [SerializeField]
  string strTag;
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider.tag == strTag)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void OnTriggerEnter(Collider other) 
    {
      if(other.tag==strTag)
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
    }
}
