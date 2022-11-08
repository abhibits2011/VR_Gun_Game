using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip onHover, onClick;
    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Hover()
    {
        audiosource.PlayOneShot(onHover);
    }
    public void Click()
    {
        audiosource.PlayOneShot(onClick);
    }

}
