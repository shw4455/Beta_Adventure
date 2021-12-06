using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchSound : MonoBehaviour
{
    void Start()
    {
        Invoke("PlaySound", 1f);
    }

    void PlaySound()
    {
        AudioSource Audio = this.gameObject.GetComponent<AudioSource>();
        Audio.Play();
    }
}
