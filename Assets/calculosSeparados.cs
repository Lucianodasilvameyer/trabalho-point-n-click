using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class calculosseparados
{

    public static int Soma(int a, int b)
    {
        int resultado;
        resultado = a + b;
        Debug.Log("O resultado da soma é: " + resultado);

        return resultado;
    }
    public static float Soma(float a, float b)
    {
        float resultado;
        resultado = a + b;

        return resultado;
    }
}
