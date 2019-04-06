using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Star : MonoBehaviour
{
    public GameObject mainCanvas;
    private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCanvas = GameObject.FindWithTag("Canvas");
        player = GameObject.FindWithTag("Player");
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mainCanvas.transform.GetChild(0).GetComponent<Text>().text = "meh.";
            player.GetComponent<PlayerController>().Win();
        }
    }
}
