using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField] GameObject[] cameraPlayer1;
    [SerializeField] GameObject[] cameraPlayer2;


    private int index1 = 0;
    private int index2 = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (index1 < cameraPlayer1.Length -1)
            {
                index1 += 1;
            }
            else
            {
                index1 = 0;
            }

            for (int i = 0; i < cameraPlayer1.Length; i++)
            {
                cameraPlayer1[i].SetActive(false);
            }

            cameraPlayer1[index1].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            if (index2 < cameraPlayer2.Length -1)
            {
                index2 += 1;
            }
            else
            {
                index2 = 0;
            }

            for (int i = 0; i < cameraPlayer2.Length; i++)
            {
                cameraPlayer2[i].SetActive(false);
            }

            cameraPlayer2[index2].SetActive(true);
        }
    }
}
