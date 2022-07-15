using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    private Transform player;
    private Vector3 tempPos;

    public GameObject wallPrefab;
    public GameObject flippedWallPrefab;
    public GameObject floorPrefab;
    //public GameObject rampPrefab;
    //public GameObject flippedRampPrefab;
    public SpriteRenderer _sr;

    public float wallYoffset = 0.65f;
    public float wallXoffset = -0.2f;
    public float flippedWallXoffset = -0.2f;
    public float flippedWallYoffset = -0.2f;
    public float floorYoffset = 0.45f;
    public float floorXoffset = 0f;
    //public float rampYoffset = 0f;
    //public float rampXoffset = 0f;
    //public float flippedRampXoffset = -0.2f;
    //public float flippedRampYoffset = -0.2f;

    public float prefabRotation = 45f;

    public string placeMode = "GetKeyDown";

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        

        if (Input.GetKey(KeyCode.Return))
        {
            tempPos = transform.position;
            tempPos.x = player.position.x;
            tempPos.y = player.position.y;

            BuildWall();
        }
        if (Input.GetKey(KeyCode.RightShift))
        {
            tempPos = transform.position;
            tempPos.x = player.position.x;
            tempPos.y = player.position.y;

            BuildFloor();
        }
        /*if (Input.GetKey(KeyCode.Backslash))
        {
            tempPos = transform.position;
            tempPos.x = player.position.x;
            tempPos.y = player.position.y;

            BuildRamp();
        }*/
    }
    
    void BuildWall()
    {
        if (_sr.flipX)
        {
            Instantiate(wallPrefab, new Vector3(tempPos.x - wallXoffset, tempPos.y - wallYoffset, 0), Quaternion.identity);
        }
        else
        {
            Instantiate(flippedWallPrefab, new Vector3(tempPos.x - flippedWallXoffset, tempPos.y - flippedWallYoffset, 0), Quaternion.identity);
        }
    }

    void BuildFloor()
    {
        Instantiate(floorPrefab, new Vector3(tempPos.x - floorXoffset, tempPos.y - floorYoffset, 0), Quaternion.identity);
    }

    /*void BuildRamp()
    {
        if (_sr.flipX)
        {
            Instantiate(rampPrefab, new Vector3(tempPos.x - rampXoffset, tempPos.y - rampYoffset, 35), Quaternion.identity);
        }
        else
        {
            Instantiate(flippedRampPrefab, new Vector3(tempPos.x - flippedRampXoffset, tempPos.y - flippedRampYoffset, 35), Quaternion.identity);
        }
    }*/

}
