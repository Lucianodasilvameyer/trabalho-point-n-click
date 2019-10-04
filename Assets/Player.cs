using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public LayerMask  chao;

    // Start is called before the first frame update
    void Start()
    {
        chao = LayerMask.GetMask("Chão");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))//aqui  1 depois do GetMouseButton é o botão direito do mouse, o zero seria o esquerdo
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);// aqui o ray é o raio, o ScreenPointToRay é para definir um ponto especifico
            RaycastHit rayHit;// aqui seria onde o raio acertou

            if (Physics.Raycast(ray, out rayHit, 50f, chao))// o chão é a layer q decide onde a luz acerta
            {
                scriptStatic.movimentacao(this.transform, rayHit.point);
            }
        }
    }
}
