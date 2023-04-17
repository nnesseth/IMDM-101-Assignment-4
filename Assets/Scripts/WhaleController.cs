using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleController : MonoBehaviour
{

    [SerializeField] private Transform whale;
    private Vector3 rotation;

    void Start()
    {
        whale.GetComponent("humpbbackwhale");    
    }
    void Update()
    {
        rotation.y += 1;
        whale.Rotate(rotation);
    }
}
