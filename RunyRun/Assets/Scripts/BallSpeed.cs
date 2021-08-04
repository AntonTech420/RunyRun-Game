using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeed : MonoBehaviour
{
    [SerializeField]Vector3 v3force; 
    // Start is called before the first frame update
    void FixedUpdate()
    {
        
            GetComponent<Rigidbody>().velocity += v3force;
        
    }
}
