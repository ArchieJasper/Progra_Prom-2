using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : Botones
{

    public void Presionar()
    {
        IncreaseScore();
    }
    protected override void NuevoScore(int Puntaje)
    {
        Boton.GetInstance().score += Puntaje;
        Boton.GetInstance().UpdateScore();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
