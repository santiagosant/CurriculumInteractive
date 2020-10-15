using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiOpciones : MonoBehaviour
{

    bool activado;
    public GameObject menuDePausa;
    public GameObject nivelTerminado;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !nivelTerminado.activeSelf)
        {
            activado = !activado;
            menuDePausa.SetActive(activado);
            Time.timeScale = (activado) ? 0 : 1f;
        }
    }

}
