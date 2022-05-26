using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFallControl : MonoBehaviour
{
    public GameObject Player;
    public GameObject Plane;
    public static float verticalPositionPlayer;
    public static float verticalPositionPlane;

    void Start()
    {
        FallControl();
    }

    void Update()
    {
        FallControl();
    }

    void FallControl()
    {
        verticalPositionPlayer = GameObject.Find("Player").transform.position[1];
        verticalPositionPlane = GameObject.Find("Plane").transform.position[1];
        if (verticalPositionPlayer < verticalPositionPlane)
        {
            SceneManager.LoadScene(2);
        }
    }
}
