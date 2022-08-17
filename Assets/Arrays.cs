using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    int[] myIntArray = new int[10];

    //tipo de variable invidividual  entre corchetes
    // se le asigna el nombre a la coleccion lo cual es importante pues los array son arreglos de guardados de variables
    // para especificar la longitud de los elementos ponemos "new" lo cual esto no asegura cuanta cantidad de elementos se guardara en el Arreglo, en este caso son 10

    void Start()
    {
        //se inicia la inicializacion de elementos, o sea la referencia de elementos los cuales estaran dentro del arreglo
        //lo que esta dentro del arreglo son indices; para referenciar un elemento del arreglo es necesario un índice, que indique la posición relativa del elemento en el arreglo.
        //por lo que en total hay 10 posiciones dentro de los corchetes donde estan los elementos referenciados despues del "="
        myIntArray[0] = 5;
        //Variable//indice de posicion del elemento//Elemento
        myIntArray[1] = 10;
        myIntArray[2] = 20;
        myIntArray[3] = 15;
        myIntArray[4] = 12;
        myIntArray[5] = 8;
        myIntArray[6] = 0;
        myIntArray[7] = 9;
        myIntArray[8] = 7;
        myIntArray[9] = 13;
        //el indice de los elementos es un numero entero el cual siempre su indice empieza en 0 como se ve en el codigo que es desde 0 hasta 9, esto es el total de las posiciones
        for (int i = 0; i<myIntArray.Length; i++)
        {
            int numeroR = Random.Range( 0, 25);
            i = 0;

            int indice = 0;
            while (indice < myIntArray.Length)
            {
                if (numeroR == myIntArray[i])
                {
                    numeroR = Random.Range(0, 25);
                    indice = 0;
                }
                else
                {
                    indice++;
                }
            }
        }
        
    }
}
