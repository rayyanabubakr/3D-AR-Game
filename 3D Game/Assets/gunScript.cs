using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunScript : MonoBehaviour
{
    AudioSource audio;
    public static gunScript instance;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void fireSound()
    {
        audio.Play();
    }
}
