using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public int numero;
    public bool boleana;

    public string texto;

    // Start is called before the first frame update
    void Start()
    {
        /*if (numero == 8 && boleana == true)
        {
            Debug.Log("numero 8 y true");
        }*/

        /*if (numero == 1 && boleana == true)
        {
            Debug.Log("numero 1 y true");
        }

        else if (numero == 2 && boleana == true)
        {
            Debug.Log("numero 2 y true");
        }*/

        //Solo compara una condicion, pero no va de uno en uno va directo. El if va comparando uno a uno y si tienes 100 primero que tarda y segundo que consume recursos.
        switch (numero)
        {
            case 0:
                Debug.Log("0");
                transform.position = new Vector3(0, 0, 0);
            break;
            case 1:
                Debug.Log("1");
            break;
            case 2:
                Debug.Log("2");
            break;
            case 3:
                Debug.Log("3");
            break;
            case 4:
                Debug.Log("4");
            break;
            default:
                Debug.Log("sin numero");
            break;
        }

        switch (texto)
        {
            case "Juan":
                if(numero == 8 && boleana == true)
                {
                    Debug.Log("numero 8 y true");
                }
                Debug.Log("Hola Juan");
                transform.position = new Vector3(0, 0, 0);
            break;
            case "Pedro":
                Debug.Log("Hola Pedro");
            break;
            case "Manolo":
                Debug.Log("Hola Manolo");
            break;
            case "Juana":
                Debug.Log("Hola Juana");
            break;
            case "Petra":
                Debug.Log("Hola Petra");
            break;
            case "Manuela":
                Debug.Log("Hola Manuela");
            break;
            default:
                Debug.Log("Quien eres");
            break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
