using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropSprite : MonoBehaviour
{
     Rigidbody2D rb;
     Camera cameraPrincipal;

     bool estaDentro;
     bool estaArrastando;

     void Update()
    {
        if (estaDentro && Input.GetKeyDown(KeyCode.Mouse0))
        {
            estaArrastando = true;
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            estaArrastando = false;
        }
    }

    void FixedUpdate()
    {
        if (estaArrastando)
        {
            rb.MovePosition(cameraPrincipal.ScreenToWorldPoint(Input.mousePosition));
        }
    }

     void OnMouseOver()
    {
        estaDentro = true;
    }

     void OnMouseExit()
    {
        estaDentro = false;
    }
}