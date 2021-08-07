using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFloor : MonoBehaviour
{



    public GameObject movingFloorPannel;
    private string floorDirection = "up";
    public float floorMoveSpeed;

    void FixedUpdate()
    {
        float floorElevation = movingFloorPannel.transform.position.y;


        if (floorElevation >= 150)
        {
            floorDirection = "down";
        }else if(floorElevation <= 110)
        {
            floorDirection = "up";
        }

        if(floorDirection == "up")
        {
            floorElevation += floorMoveSpeed;

        }else if(floorDirection == "down") 
        {
            floorElevation -= floorMoveSpeed;
        }

        movingFloorPannel.transform.position = new Vector3(13.0f, floorElevation, 250.0f);

    }
}
