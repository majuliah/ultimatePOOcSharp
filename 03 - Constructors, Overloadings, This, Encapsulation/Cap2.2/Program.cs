﻿using static System.Console;
using System.Globalization;

namespace Cap2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("E.N.C.A.P.S.U.L.A.M.E.N.T.O");

            
            
            Compra compra = new Compra("TV", 900.00, 9);

            compra.Nome = "TV 8K";
            WriteLine(compra.Nome);            
            

            WriteLine(compra.GetQuantidade());
            
            
            
            
            
            
            
            

        }
    }
}