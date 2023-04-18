using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleController : MonoBehaviour
{

    [SerializeField] private Transform whale;
    [SerializeField] private Vector3 movement;
    [SerializeField] private Vector3 rotation;

    void Start()
    {
        movement.x = 0.004F;
        rotation.y = -0.01F;
    }
    void Update()
    {
        if (GameObject.Find("WhaleDad"))
        {
            whale.Rotate(rotation);
            whale.Translate(movement);
        } else
        {
            Debug.Log("WhaleDad object not found.");
        }
    }
}
