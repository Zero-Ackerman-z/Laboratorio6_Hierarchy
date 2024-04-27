using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitaController : MonoBehaviour
{
    public Transform Planet; // Referencia  
    public float distanceFromPlanet = 10f; // Distancia 
    public float orbitSpeed = 2f; // Velocidad O
    public float rotationSpeed = 50f; // Velocidad R

    void Update()
    {
        // Orbitar alrededor del Sol
        transform.position = (transform.position - Planet.position).normalized * distanceFromPlanet + Planet.position;
        transform.RotateAround(Planet.position, Vector3.up, orbitSpeed * Time.deltaTime);

        // Rotar
        transform.Rotate(Vector2.up, rotationSpeed * Time.deltaTime);
    }
}
