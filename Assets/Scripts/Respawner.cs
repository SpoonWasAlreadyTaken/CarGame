using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{

    [SerializeField] Collider playerCar1;
    [SerializeField] Collider playerCar2;

    [SerializeField] GameObject playerCar1Object;
    [SerializeField] GameObject playerCar2Object;




    private void OnTriggerEnter(Collider other)
    {
        if (other == playerCar1)
        {
            playerCar1Object.transform.position = new Vector3(-5, 1, -10);
            playerCar1Object.transform.rotation = new Quaternion(0, 0, 0, 0);
            playerCar1Object.transform.Translate(0, 0, 0);
        }

        if (other == playerCar2)
        {
            playerCar2Object.transform.position = new Vector3(5, 1, -10);
            playerCar2Object.transform.rotation = new Quaternion(0, 0, 0, 0);
            playerCar2Object.transform.Translate(0, 0, 0);
        }
    }

}
