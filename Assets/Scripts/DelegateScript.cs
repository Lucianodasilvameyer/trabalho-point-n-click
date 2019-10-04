using UnityEngine;
using System;

public class DelegateScript : MonoBehaviour
{
    public delegate void Del(int num);

    public Del meuDelegate;    
}
