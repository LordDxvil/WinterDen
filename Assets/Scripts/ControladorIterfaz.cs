﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorIterfaz : MonoBehaviour
{

    
    public Animator animMenuAjustes;
    public Animator animMenuMejora;
    public Animator animMenuExpediciones;
    public Animator animConejosEnSala;

    bool activaMenuAjustes = false;
   
    bool activaMenuMejora = false;
    bool activaConejosEnSala = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ApareceConejosEnSala()
    {
        activaConejosEnSala = !activaConejosEnSala;
        animConejosEnSala.SetBool("MenuActivo", activaConejosEnSala);
    }

   

    public void ApareceMenuAjustes()
    {
        activaMenuAjustes = !activaMenuAjustes;
        animMenuAjustes.SetBool("MenuActivo", activaMenuAjustes);
    }
    public void ApareceMenuMejora()
    {
        activaMenuMejora = !activaMenuMejora;
        animMenuMejora.SetBool("MenuActivo", activaMenuMejora);
    }
    public void DesapareceMenuExpediciones()
    {
        animMenuExpediciones.SetBool("MenuActivo", false);
    }
}
