using UnityEngine;
using UnityEngine.SceneManagement;

public class Singleton : MonoBehaviour
{
    public static Singleton instance;    

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }     
        
    }

    public void CarregarCena(string nomeCena, string invocador)
    {
        Debug.Log("CarregarCena chamado do GameObject " + invocador);

        SceneManager.LoadScene(nomeCena);
    }
}

public static class Operacoes
{   
    public static int Somar(int x, int y)
    {
        int resultado;

        resultado = x + y;

        return resultado;
    }

    public static int Subtrair(int x, int y)
    {
        int resultado;

        resultado = x - y;

        return resultado;
    }
}