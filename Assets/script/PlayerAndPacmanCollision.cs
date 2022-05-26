using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAndPacmanCollision : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;

    public static Vector3 playerPos;
    public static Vector3 enemyPos;

    public static Vector2 diffPos;
    public static float diff, diff1;

    void ObjPositions()
    {
        playerPos = GameObject.Find("Player").transform.position;
        enemyPos = GameObject.Find("Enemy").transform.position;
        Debug.Log("Player:" + playerPos);
        Debug.Log("Enemy:" + enemyPos);

        if (playerPos[0] < enemyPos[0])
        {
            diff = enemyPos[0] - playerPos[0];
        }
        else
        {
            diff = playerPos[0] - enemyPos[0];
        }

        if (playerPos[2] < enemyPos[2])
        {
            diff1 = enemyPos[2] - playerPos[2];
        }
        else
        {
            diff1 = playerPos[2] - enemyPos[2];
        }

        /*if (
            playerPos[0] - enemyPos[0] < 5 ||
            playerPos[0] - enemyPos[0] > -5 ||
            playerPos[2] - enemyPos[2] < 5 ||
            playerPos[2] - enemyPos[2] > -5
            )
        {
            SceneManager.LoadScene(2);
        }*/

        /*if (diff1 < 0.1 || diff < 0.1)
        {
            SceneManager.LoadScene(2);
        }*/

        diffPos[0] = diff;
        diffPos[1] = diff1;

        Debug.Log(diffPos);
    }

    void Start()
    {
        ObjPositions();
    }

    void Update()
    {
        ObjPositions();
    }
}
