using System;
using UnityEngine;

public class MovementAutomatic : MonoBehaviour
{
    enum TypeMovementBot { HorizontalBounce,VerticalBounce,HorizontalFromLeft, HorizontalFromRight,VerticalFromAbove, VerticalFromBelow }

    [SerializeField] TypeMovementBot typeMovementRobot;

    private Transform t;

    private void Awake()
    {
        t = GetComponent<Transform>();
    }
    private void Update()
    {
        try
        {
            switch (typeMovementRobot)
            {
                case TypeMovementBot.HorizontalBounce:
                    break;
                case TypeMovementBot.VerticalBounce:
                    break;
                case TypeMovementBot.HorizontalFromLeft:
                    break;
                case TypeMovementBot.HorizontalFromRight:
                    break;
                case TypeMovementBot.VerticalFromAbove:
                    break;
                case TypeMovementBot.VerticalFromBelow:
                    break;
            }
        }catch(Exception e)
        {
            Debug.LogError("No se ha encontrado el componente Transform en el objeto actual");
        }
    }

    private void HorizontalBounce()
    {
    float speed = 2.0f; // Velocidad del objeto
    float distance = 4.0f; // Distancia de rebote del objeto

    // Mueve el objeto horizontalmente utilizando la función Mathf.PingPong para generar el rebote
    t.position = new Vector3(Mathf.PingPong(Time.time * speed, distance), t.position.y, t.position.z);
    }

    private void VerticalBounce()
    {
    float speed = 2.0f; // Velocidad del objeto
    float distance = 4.0f; // Distancia de rebote del objeto

    // Mueve el objeto verticalmente utilizando la función Mathf.PingPong para generar el rebote
    t.position = new Vector3(t.position.x, Mathf.PingPong(Time.time * speed, distance), t.position.z);
    }

    private void HorizontalFromLeft()
    {
    float speed = 2.0f; // Velocidad del objeto

    // Mueve el objeto desde la izquierda hacia la derecha
    t.position += Vector3.right * Time.deltaTime * speed;
    }

    private void HorizontalFromRight()
    {
    float speed = 2.0f; // Velocidad del objeto

    // Mueve el objeto desde la derecha hacia la izquierda
    t.position -= Vector3.right * Time.deltaTime * speed;
    }

    private void VerticalFromAbove()
    {
    float speed = 2.0f; // Velocidad del objeto

    // Mueve el objeto desde la parte superior hacia abajo
    t.position -= Vector3.up * Time.deltaTime * speed;
    }

    private void VerticalFromBelow()
    {
    float speed = 2.0f; // Velocidad del objeto

    // Mueve el objeto desde la parte inferior hacia arriba
    t.position += Vector3.up * Time.deltaTime * speed;
    }
}