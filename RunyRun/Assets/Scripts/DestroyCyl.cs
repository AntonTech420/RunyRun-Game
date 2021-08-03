using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCyl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float timer = 3f;

    void Update()
    {
       
        timer -= Time.deltaTime;

        if(timer <= 0){
            Destroy(gameObject);
        } 
    }
}
