using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource candyCollectedAudioSource;
    void Start()
    {
        Candy.OnCandyCollected+=OnCandyCollected;

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCandyCollected(){
        candyCollectedAudioSource.Play();
    }
}
