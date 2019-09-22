﻿using System.Collections.Generic;

namespace TrabalhoCalculadora
{
    public class Calculadora
    {
        private List<float> _memoria = new List<float>();
        public List<float> Memoria { get => _memoria; set => _memoria = value; }

        public float RealizarOperacao(float Numero1, float Numero2, string operacao)
        {
            float resultado = float.NaN;
            switch (operacao)
            {
                case "a":
                    resultado = Adicionar(Numero1, Numero2);
                    break;
                case "s":
                    resultado = Subtrair(Numero1, Numero2);
                    break;
                case "m":
                    resultado = Multiplicar(Numero1, Numero2);
                    break;
                case "d":
                    resultado = Dividir(Numero1, Numero2);
                    break;
                default:
                    break;
            }
            return resultado;
        }

        private float Adicionar(float Numero1, float Numero2)
        {
            return Numero1 + Numero2;
        }

        private float Subtrair(float Numero1, float Numero2)
        {
            return Numero1 - Numero2;
        }

        private float Multiplicar(float Numero1, float Numero2)
        {
            return Numero1 * Numero2;
        }

        private float Dividir(float Numero1, float Numero2)
        {
            return Numero1 / Numero2;
        }
    }
}