﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NerdStore.Core.DomainObjects
{
    public class Validacoes
    {
        public static void ValidarSeIgual(object object1, object object2, string mensagem)
        {
            if(object1.Equals(object2))
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarSeDiferente(object object1, object object2, string mensagem)
        {
            if (!object1.Equals(object2))
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarCaracteres(string valor, int maximo, string mensagem)
        {
            var length = valor.Trim().Length;
            if (length > maximo)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarCaracteres(string valor, int minimo, int maximo, string mensagem)
        {
            var length = valor.Trim().Length;
            if (length < minimo || length > maximo)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarExpressao(string pattern, string valor, string mennsagem)
        {
            var regex = new Regex(pattern);
            if (!regex.IsMatch(valor))
            {
                throw new DomainException(mennsagem);
            }
        }

        public static void ValidarSeVazio(string valor, string mennsagem)
        {
            if (valor == null || valor.Trim().Length == 0)
            {
                throw new DomainException(mennsagem);
            }
        }

        public static void ValidarSeNulo(object object1, string mennsagem)
        {
            if (object1 == null)
            {
                throw new DomainException(mennsagem);
            }
        }

        public static void ValidarMinimoMaximo(double valor, double minimo, double maximo, string mennsagem)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(mennsagem);
            }
        }

        public static void ValidarMinimoMaximo(float valor, float minimo, float maximo, string mennsagem)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(mennsagem);
            }
        }

        public static void ValidarMinimoMaximo(int valor, int minimo, int maximo, string mennsagem)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(mennsagem);
            }
        }

        public static void ValidarMinimoMaximo(long valor, long minimo, long maximo, string mennsagem)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(mennsagem);
            }
        }

        public static void ValidarMinimoMaximo(decimal valor, decimal minimo, decimal maximo, string mennsagem)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(mennsagem);
            }
        }

        public static void ValidarSeMenorQue(long valor, long minimo, string mennsagem)
        {
            if (valor < minimo)
            {
                throw new DomainException(mennsagem);
            }
        }

        public static void ValidarSeMenorQue(double valor, double minimo, string mennsagem)
        {
            if (valor <= minimo)
            {
                throw new DomainException(mennsagem);
            }
        }

        public static void ValidarSeMenorQue(decimal valor, decimal minimo, string mennsagem)
        {
            if (valor <= minimo)
            {
                throw new DomainException(mennsagem);
            }
        }

        public static void ValidarSeMenorQue(int valor, int minimo, string mennsagem)
        {
            if (valor <= minimo)
            {
                throw new DomainException(mennsagem);
            }
        }

        public static void ValidarSeFalso(bool boolValor, string mennsagem)
        {
            if (boolValor)
            {
                throw new DomainException(mennsagem);
            }
        }

        public static void ValidarSeVerdadeiro(bool boolValor, string mennsagem)
        {
            if (!boolValor)
            {
                throw new DomainException(mennsagem);
            }
        }



    }
}
