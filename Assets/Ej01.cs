﻿//1.Crea un programa que permita ingresar por Inspector dos valores 
//    enteros y responda si son iguales o no lo son.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej01 : MonoBehaviour
{
    public int valor1;
    public int valor2;

    // Start is called before the first frame update
    void Start()
    {
        if (valor1 == valor2)
        {
            Debug.Log("Son iguales");
        }
        else
        {
            Debug.Log("NO son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
