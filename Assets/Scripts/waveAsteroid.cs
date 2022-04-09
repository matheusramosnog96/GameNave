using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveAsteroid : MonoBehaviour
{
    public int qtndAsteroides = 20;
    public comportamentoAsteroid  prefabAmeteoro1;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < qtndAsteroides; i++){
            Vector3 posicao = new Vector3(0.0f, 0.0f, 0.0f);
            Instantiate(prefabAmeteoro1, posicao , Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
