using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioSofrecom
{
    public class Letra
    {
        public char nombre { get; set; }
        public char valor { get; set; }
        public int posicion { get; set; }

        public Letra(char pNombre, char pTecla, int pPosicion)
        {
            nombre = pNombre;
            valor = pTecla;
            posicion = pPosicion;
        }
    }
}