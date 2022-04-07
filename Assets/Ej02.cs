//2. Crear las variables necesarias para ingresar por Inspector 
//    el precio de 3 productos y un monto de dinero 
//    disponible. Comunicar si la suma de los mismos supera 
//    o no el monto de dinero disponible.Luego indicar cuánto 
//    dinero sobra o falta.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour
{

    public int precio1;
    public int precio2;
    public int precio3;

    public int dineroDisponible;

    // Start is called before the first frame update
    void Start()
    {
        int totalPrecio = precio1 + precio2 + precio3;
        if (totalPrecio > dineroDisponible)
        {
            Debug.Log("El total supera el dinero disponible");
            Debug.Log("Te falta " + (totalPrecio - dineroDisponible));
        }
        else
        {
            Debug.Log("El total NO supera el dinero disponible");
            Debug.Log("Te sobra " + (dineroDisponible - totalPrecio));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
