using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float offsetX;
    public float offsetY;
    public Vector3 playerPosition;
    public float offsetSmoothing;
    
    // Start is called before the first frame update
    void Start()
    {
        // finds player in scene
        player = GameObject.FindWithTag("Player");
        GetPlayerPos();

        transform.position = playerPosition;

    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerPos();
        transform.position = Vector3.Lerp(transform.position, playerPosition, offsetSmoothing * Time.deltaTime);
    }

    void GetPlayerPos()
    {
        playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);

        if (player.transform.localScale.y > 0f)
            playerPosition = new Vector3(playerPosition.x + offsetX, 3, playerPosition.z);
//            playerPosition = new Vector3(playerPosition.x + offsetX, playerPosition.y + offsetY, playerPosition.z);
            
        else
            playerPosition = new Vector3(playerPosition.x - offsetX, 3, playerPosition.z);
//            playerPosition = new Vector3(playerPosition.x - offsetX, playerPosition.y + offsetY, playerPosition.z);
    }
}
