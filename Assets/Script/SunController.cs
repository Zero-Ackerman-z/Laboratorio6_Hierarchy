using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunController : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 1f; // Velocidad de rotaci�n de la Tierra

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Rotar la Tierra lentamente en el eje Y
        transform.Rotate(Vector2.up, rotationSpeed * Time.deltaTime);
    }
}
