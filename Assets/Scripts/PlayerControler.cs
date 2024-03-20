using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] GameObject playerCar1;
    [SerializeField] GameObject playerCar2;

    [SerializeField] private float carSpeed = 25f;
    [SerializeField] private float carTurnSpeed = 1f;

    public Respawner respawnTime;


    void FixedUpdate()
    {

        playerCar1.transform.Translate(Vector3.forward * Time.deltaTime * carSpeed);

        playerCar2.transform.Translate(Vector3.forward * Time.deltaTime * carSpeed);


        if (Input.GetKey(KeyCode.A))
        {
            playerCar1.transform.Rotate(0.0f, -carTurnSpeed * Time.deltaTime, 0.0f, Space.Self);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playerCar1.transform.Rotate(0.0f, carTurnSpeed * Time.deltaTime, 0.0f, Space.Self);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerCar2.transform.Rotate(0.0f, -carTurnSpeed * Time.deltaTime, 0.0f, Space.Self);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            playerCar2.transform.Rotate(0.0f, carTurnSpeed * Time.deltaTime, 0.0f, Space.Self);
        }
    }




}
