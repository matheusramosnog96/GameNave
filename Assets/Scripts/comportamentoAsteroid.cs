using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamentoAsteroid : MonoBehaviour
{
    public Rigidbody2D meteoro1;
    public float velocidadeMax = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle;
        direcao = direcao * velocidadeMax; 
        meteoro1.velocity = direcao;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
