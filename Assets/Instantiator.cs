using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public Text cantida;
   public int cloneamount;
    GameObject clon;
    public void TripleInstantiate()
    {
        
        cloneamount = int.Parse(cantida.text);
        for(int i=0;i<cloneamount;i++)
        {
            clon = Instantiate(objectToClone);
            Destroy(clon, 1);
            
        }
    }
}
