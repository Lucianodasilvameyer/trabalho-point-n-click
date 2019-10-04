using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public int A;
    public int B;

    public float a = 5.66f;
    public float b = 8.15f;

    // Start is called before the first frame update
    void Start()
    {
        //Invocar a 
        calculosseparados.Soma(5, 6);// aqui indentifica  sozino se é int ou float
    }

    // Update is called once per frame
    void Update()
    {

    }
}
