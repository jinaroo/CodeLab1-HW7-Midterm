using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject mainCanvas;
    private GameObject player;
    
    // Start is called before the first frame update
    public virtual void Start()
    {
        mainCanvas = GameObject.FindWithTag("Canvas");
        mainCanvas.transform.GetChild(0).gameObject.SetActive(false);
        player = GameObject.FindWithTag("Player");
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mainCanvas.transform.GetChild(0).gameObject.SetActive(true);
            player.GetComponent<PlayerController>().Die();
        }
    }
}
