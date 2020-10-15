using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalizarNivel : MonoBehaviour
{
    public GameObject nivelTerminado;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        nivelTerminado.SetActive(true);
        Time.timeScale = 0;
    }
}
