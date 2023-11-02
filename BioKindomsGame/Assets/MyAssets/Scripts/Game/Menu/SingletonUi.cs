using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonUi : MonoBehaviour
{
    public static SingletonUi singletonUi;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        singletonUi = this;
    }
}
