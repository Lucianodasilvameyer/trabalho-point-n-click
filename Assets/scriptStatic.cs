using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class scriptStatic
{
    public static void movimentacao(this Transform player, Vector3 destino)
    {
        player.Translate(destino * Time.deltaTime, Space.World);
    }

}
