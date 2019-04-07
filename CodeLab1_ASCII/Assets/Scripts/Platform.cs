using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().Play("platform_animation", -1, Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
