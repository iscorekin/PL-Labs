﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Polynomial
    {
        private readonly double[] _coefficients;

        public Polynomial(double[] coefficients)
        {
            _coefficients = coefficients;
        }

        public double this[int n]
        {
            get => _coefficients[n];
            set => _coefficients[n] = value;
        }

        public int Order
        {
            get => _coefficients.Length;
        }

        public override string ToString()
        {
            return string.Format("Коэффициенты: " + string.Join("; ", _coefficients));
        }

        public double Calculate(double x)
        {
            int n = _coefficients.Length - 1;
            double result = _coefficients[n];
            for (int i = n - 1; i >= 0; i--)
            {
                result = x * result + _coefficients[i];
            }
            return result;
        }

        public static Polynomial operator +(Polynomial pFirst, Polynomial pSecond)
        {
            int itemsCount = Math.Max(pFirst._coefficients.Length, pSecond._coefficients.Length);
            var result = new double[itemsCount];

            for (int i = 0; i < itemsCount; i++)
            {
                double a = 0;
                double b = 0;
                if (i < pFirst._coefficients.Length)
                {
                    a = pFirst[i];
                }
                if (i < pSecond._coefficients.Length)
                {
                    b = pSecond[i];
                }
                result[i] = a + b;
            }

            return new Polynomial(result);
        }

        public static Polynomial operator -(Polynomial pFirst, Polynomial pSecond)
        {
            int itemsCount = Math.Max(pFirst._coefficients.Length, pSecond._coefficients.Length);
            var result = new double[itemsCount];

            for (int i = 0; i < itemsCount; i++)
            {
                double a = 0;
                double b = 0;
                if (i < pFirst._coefficients.Length)
                {
                    a = pFirst[i];
                }
                if (i < pSecond._coefficients.Length)
                {
                    b = pSecond[i];
                }
                result[i] = a - b;
            }

            return new Polynomial(result);
        }

        public static Polynomial operator *(Polynomial pFirst, Polynomial pSecond)
        {
            int itemsCount = pFirst._coefficients.Length + pSecond._coefficients.Length - 1;
            var result = new double[itemsCount];

            for (int i = 0; i < pFirst._coefficients.Length; i++)
            {
                for (int j = 0; j < pSecond._coefficients.Length; j++)
                {
                    result[i + j] += pFirst[i] * pSecond[j];
                }
            }

            return new Polynomial(result);
        }

        public static bool operator ==(Polynomial pFirst, Polynomial pSecond)
        {
            if (pFirst._coefficients.Length != pSecond._coefficients.Length)
            {
                return false;
            }
            for (int i = 0; i < pFirst._coefficients.Length; i++)
            {
                if (pFirst[i] != pSecond[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator !=(Polynomial pFirst, Polynomial pSecond)
        {
            return !(pFirst == pSecond);
        }
    }
}
