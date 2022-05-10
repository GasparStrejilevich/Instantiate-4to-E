using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{
    public Text nombre;
    public void ShowMessageInConsole()
    {
        Debug.Log("Hello " + nombre.text);
    }
    public void showdouble()
    {
        if (nombre.text != "")
        {
            Debug.Log(int.Parse(nombre.text) * 2);
        }
        else
        {
            Debug.Log("EL ingreso no es valido");

        }
    }
}
