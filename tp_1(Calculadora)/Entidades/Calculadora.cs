﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        #region Metodos
       

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;
            switch (ValidarOperador(operador))
            {
                case "+":
                    retorno = num1 + num2;
                    break;
                case "-":
                    retorno = num1 - num2;
                    break;
                case "*":
                    retorno = num1 * num2;
                    break;
                case "/":
                    retorno = num1 / num2;
                    break;
                default:
                    break;
            }
            return retorno;
        }

        private static string ValidarOperador(string operador)
        {
            string ret;

            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                ret = operador;
            }

            else
            {
                ret = "+";
            }
            return ret;
        }
        #endregion
    }
}
