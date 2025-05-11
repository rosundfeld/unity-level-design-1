using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeiroScript : MonoBehaviour
{
    public float position;
    void Start()
    {
        position = PlayerPrefs.GetFloat("POSICAO", 1); //<-- salva algo no PC do jogador. (nome variavel, default (se nao tiver nada guardado retorna 0))

        position++;

        PlayerPrefs.SetFloat("POSICAO", 2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
