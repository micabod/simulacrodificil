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
        precioCampo = cantCampo * 1200;
        precioPlatea = cantPlatea * 2000;
        cantTotal = precioCampo + precioPlatea;
        if (cantCampo<0 || cantCampo>20400 || cantPlatea < 0 || cantPlatea > 16200){
            Debug.Log("error");
            return;
        }

        Debug.Log("La recaudacion del campo es $" + precioCampo);
        Debug.Log("La recaudacion de platea es $" + precioPlatea);
        Debug.Log("La recaudación total es $" + cantTotal);
        int capacidadTotal = 20400 + 16200;
        int entradasVendidas = cantCampo + cantPlatea;
        int entradasVacantes = capacidadTotal - entradasVendidas;
        Debug.Log("Cantidad de entradas vacantes: " + entradasVacantes);

        if (entradasVendidas==capacidadTotal){
            Debug.Log("Sold out");
        }
        if (entradasVendidas>capacidadTotal/2){
            Debug.Log("El festival fue un exito");
        }
        else{
            Debug.Log("Debemos mejorar la convocatoria");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
