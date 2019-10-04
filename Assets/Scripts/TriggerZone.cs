using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    [SerializeField] string cenaParaCarregar;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Singleton.instance.CarregarCena(cenaParaCarregar, this.gameObject.name);
        }
    }
}
