﻿using System;

namespace Ex02
{
    class Program
    {   
        private string Titular { get; set; }
        private double _saldo;
        public void Deposito(double quantia)
        {
            _saldo += quantia;
        }
        public double GetSaldo()
        {
            return _saldo;
        }
    }
}