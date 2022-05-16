using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenScript : MonoBehaviour
{
    public static ScreenScript Instance;

    public GameObject empDataScreen;
    public GameObject homeScreen;
    public GameObject registerScreen;


    private void Awake()
    {
        Instance = this;
    }
}
