using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pisar : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    void Running()
    {
        audioSource.Play();
    }
}
