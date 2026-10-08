
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BibliotecaScript : MonoBehaviour
{
    public LibroScript[] libros;
    public GameObject cartelReservado;

    // Start is called before the first frame update
    void Start()
    {
        libros = FindObjectsOfType <LibroScript>();

        for(int i=0; i < libros.Length; i++)
        {
            libros[i].color = Random.Range(1, 6);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CheclIfReservedAndReserve(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CheclIfReservedAndReserve(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CheclIfReservedAndReserve(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            CheclIfReservedAndReserve(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            CheclIfReservedAndReserve(4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            CheclIfReservedAndReserve(5);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            CheclIfReservedAndReserve(6);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            CheclIfReservedAndReserve(7);
        }
    }

    void MostrarMensajeReservado()
    {
        cartelReservado.SetActive(true);
        Invoke(nameof(OcultarMensajeReservado),4);
    }

    void OcultarMensajeReservado()
    {
        cartelReservado.SetActive(false);
    }
    void CheclIfReservedAndReserve(int index)
    {
        if (libros[index].reservado == false)
        {
            libros[index].color = 0;
            libros[index].reservado = true;
        }
        else
        {
            MostrarMensajeReservado();
        }
    }
}
