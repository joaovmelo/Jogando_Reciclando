using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LixeiraMetal : MonoBehaviour
{
    //[SerializeField] Component _lixeira;
    // [SerializeField] GameObject metal;

    public int metal = 0;
    // Start is called before the first frame update
    void Start()
    {
        //_lixeira = GetComponent<Component>();
        // _LataMetal = FindObjectOfType<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        print(metal);

    }
    void OnTriggerEnter2D(Collider2D material)
    {
        if (material.gameObject.CompareTag("metal"))
        {
            metal++;
            Destroy(material.gameObject);
        }
    }
}
