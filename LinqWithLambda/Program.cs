﻿using LinqWithLambda.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //ITeste teste = new TesteTodosClientes();
            //ITeste teste = new TesteSelect();
            //ITeste teste = new TesteFirst();
            //ITeste teste = new TesteSingle();
            //ITeste teste = new TesteLast();
            ITeste teste = new TesteTake();
            teste.Teste();


            Console.ReadLine();
        }
    }
}
