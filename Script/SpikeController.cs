using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour
{
    // Start is called before the first frame update4
    public GameObject[] LeftSpikes;
    public GameObject[] RightSpikes;
    void Start()
    {
         BirdControl.OnCollidedWithWall+=BirdCollidedWithWall;
         HideSpikes();
    }
    void HideSpikes(){
        for(int i=0;i<LeftSpikes.Length;i++)
        {
            LeftSpikes[i].gameObject.SetActive(false);
        }
        for(int i=0;i<RightSpikes.Length;i++)
        {
            RightSpikes[i].gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void BirdCollidedWithWall(int dir){
        HideSpikes();
        GameObject[]spikes=dir==-1?LeftSpikes:RightSpikes;
        int randomIndex=UnityEngine.Random.Range(0,spikes.Length);
        spikes[randomIndex].SetActive(true);
    }
}
