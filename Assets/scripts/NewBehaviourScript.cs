using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int cantCampo;
    public int cantPlatea;
    float precioCampo;
    float precioPlatea;
    float cantTotal;
    // Start is called before the first frame update
    void Start()
    {        
        if(cantTotal<0 || cantTotal>20,400 || cantTotal < 0 || cantTotal > 16,200){
            Debug.Log("error");
        }
        precioCampo = cantCampo * 1200;
        precioPlatea=cantPlatea * 2000;
        cantTotal= precioCampo + precioPlatea;
        Debug.Log("La recaudacion del campo es $" + precioCampo);
        Debug.Log("La recaudacion de platea es $" + precioPlatea);

        if(cantTotal=16,200f + 20,400){
            Debug.Log("Sold out");
        }
        if (cantTotal>(16,200f + 20,400)/2){
            Debug.Log("El festival fue un exito");
        }
        else if{
            Debug.Log("Debemos mejorar la convocatoria");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
