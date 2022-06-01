using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class LataDeMetal : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Camera cameraPrincipal;
    [SerializeField] private BoxCollider2D localInicial;
    private bool estaDentro;
    private bool estaArrastando;
    Vector2 posicaoInicial;
    Vector2 posicaoFinal;


    private void Update()
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

    private void FixedUpdate()
    {
        if (estaArrastando)
        {
            rb.MovePosition(cameraPrincipal.ScreenToWorldPoint(Input.mousePosition));
        }
    }

    private void OnMouseOver()
    {
        estaDentro = true;
    }

    private void OnMouseExit()
    {
        estaDentro = false;
    }
}