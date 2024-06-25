using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawns : MonoBehaviour
{
    public int cantidad;
    private int cantidadactual;

    private int index;

    public int min, max;
    public GameObject[] objetos;
    public Transform spawnpoint;

    private int parametros=40;

    void Start()
    {
        index = Random.Range(0, objetos.Length);  //random de objeto
        cantidad = Random.Range(min, max + 1);
        cantidadactual=cantidad;
        
        spawnearcosas();
    }

    void spawnearcosas()
    {
        cantidadactual--;
        

        float potitionX=Random.Range(-parametros,parametros);  //ramdom de posision
        float potitionZ=Random.Range(-parametros,parametros);

        Vector3 potition = new Vector3(potitionX, spawnpoint.position.y, potitionZ);  //creo vector posicion con los parametros y la altura de spawnpoint

        Instantiate(objetos[index], potition, Quaternion.identity);  //creo el objeto


        if (cantidadactual <= 0)return;   //si se supera el limite returnea
        Invoke(nameof(spawnearcosas), 1f);
    }
    
}
