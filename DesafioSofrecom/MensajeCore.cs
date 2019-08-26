using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DesafioSofrecom
{
    public class MensajeCore
    {
        List<Letra> lstLetraValor = new List<Letra>();
        Letra letraA = new Letra('a', '2', 1);
        Letra letraB = new Letra('b', '2', 2);
        Letra letraC = new Letra('c', '2', 3);

        Letra letraD = new Letra('d', '3', 1);
        Letra letraE = new Letra('e', '3', 2);
        Letra letraF = new Letra('f', '3', 3);

        Letra letraG = new Letra('g', '4', 1);
        Letra letraH = new Letra('h', '4', 2);
        Letra letraI = new Letra('i', '4', 3);

        Letra letraJ = new Letra('j', '5', 1);
        Letra letraK = new Letra('k', '5', 2);
        Letra letraL = new Letra('l', '5', 3);

        Letra letraM = new Letra('m', '6', 1);
        Letra letraN = new Letra('n', '6', 2);
        Letra letraO = new Letra('o', '6', 3);

        Letra letraP = new Letra('p', '7', 1);
        Letra letraQ = new Letra('q', '7', 2);
        Letra letraR = new Letra('r', '7', 3);
        Letra letraS = new Letra('s', '7', 4);

        Letra letraT = new Letra('r', '8', 1);
        Letra letraU = new Letra('u', '8', 2);
        Letra letraV = new Letra('v', '8', 3);

        Letra letraW = new Letra('w', '9', 1);
        Letra letraX = new Letra('x', '9', 2);
        Letra letraY = new Letra('y', '9', 3);
        Letra letraZ = new Letra('z', '9', 4);

        Letra letraEspacio = new Letra(' ', '0', 1);
        public MensajeCore()
        {
            lstLetraValor.Add(letraA);
            lstLetraValor.Add(letraB);
            lstLetraValor.Add(letraC);

            lstLetraValor.Add(letraD);
            lstLetraValor.Add(letraE);
            lstLetraValor.Add(letraF);

            lstLetraValor.Add(letraG);
            lstLetraValor.Add(letraH);
            lstLetraValor.Add(letraI);

            lstLetraValor.Add(letraJ);
            lstLetraValor.Add(letraK);
            lstLetraValor.Add(letraL);

            lstLetraValor.Add(letraM);
            lstLetraValor.Add(letraN);
            lstLetraValor.Add(letraO);

            lstLetraValor.Add(letraP);
            lstLetraValor.Add(letraQ);
            lstLetraValor.Add(letraR);
            lstLetraValor.Add(letraS);

            lstLetraValor.Add(letraT);
            lstLetraValor.Add(letraU);
            lstLetraValor.Add(letraV);

            lstLetraValor.Add(letraW);
            lstLetraValor.Add(letraX);
            lstLetraValor.Add(letraY);
            lstLetraValor.Add(letraZ);

            lstLetraValor.Add(letraEspacio);

        }
        public string SecuenciaByMensaje(string pMensaje)
        {
            string secuancia = "";

            for (int i = 0; i < pMensaje.Length; i++)
            {
                Letra letra = lstLetraValor.FirstOrDefault(l => l.nombre == pMensaje[i]);
                if (i > 0)
                {
                    Letra letraAnterior = lstLetraValor.FirstOrDefault(l => l.nombre == pMensaje[i - 1]);
                    if (letraAnterior.valor == letra.valor)
                    {
                        secuancia += " ";
                    }
                }
                secuancia += string.Concat(Enumerable.Repeat(letra.valor, letra.posicion));
            }

            return secuancia;
        }
    }
}
