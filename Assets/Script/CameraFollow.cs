using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField]
    public bool autoFindPlayer;
    public GameObject player;

    public bool autoCameraOffset;
    public Vector3 cameraOffset;


    // Start is called before the first frame update
    private void Awake()
    {
        if (autoFindPlayer == true)
            player = GameObject.FindGameObjectWithTag("Player");

        if (autoFindPlayer && autoCameraOffset)
            cameraOffset = (transform.position - player.transform.position);
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = (player.transform.position + cameraOffset);
    }
}
