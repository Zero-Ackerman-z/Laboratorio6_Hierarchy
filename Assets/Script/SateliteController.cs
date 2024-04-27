using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SateliteController : MonoBehaviour
{
    public Transform Planet; // Referencia al objeto Tierra
    public Transform sun; // Referencia al objeto Sol
    public float distanceFromPlanet; // Distancia del sat�lite a la Tierra
    public float orbitSpeed; // Velocidad de �rbita alrededor de la Tierra
    private float rotationSpeed = 5f; // Velocidad de rotaci�n del sat�lite

    void Update()
    {
        // Orbitar alrededor de la Tierra
        transform.position = (transform.position - Planet.position).normalized * distanceFromPlanet + Planet.position;
        transform.RotateAround(Planet.position, Vector3.up, orbitSpeed * Time.deltaTime);


        // Ajustar la rotaci�n del sat�lite para que siempre mire hacia el Sol
        Vector3 directionToSun = (sun.position - transform.position).normalized;
        transform.rotation = Quaternion.LookRotation(directionToSun, Planet.up);

        // Rotar sobre su propio eje
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
