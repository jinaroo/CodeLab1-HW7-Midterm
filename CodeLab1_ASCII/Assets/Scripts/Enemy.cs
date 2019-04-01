using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject mainCanvas;
    
    // Start is called before the first frame update
    public virtual void Start()
    {
        mainCanvas = GameObject.FindWithTag("Canvas");
        mainCanvas.transform.GetChild(0).gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mainCanvas.transform.GetChild(0).gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
