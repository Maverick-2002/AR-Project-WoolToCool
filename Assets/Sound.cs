using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource sheep;
    // Update is called once per frame
   public void Sheep()
    {
        sheep.Play();
    }
}
