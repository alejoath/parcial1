﻿using System;
using System.Security.Cryptography;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?
            //¿Cuál fue la venta que le generó la mayor comisión?
            //¿Cuál fue el promedio de las comisiones que recibió por cada venta?

            // declaracion de constantes
            const double sueldobase = 1380000;
            const double porcentajeComision = 0.10;
            const double objetivoVentas = 1000000;

            // declaracion de variables

            double venta1, venta2, venta3, comisiontotal, salariototal;

            Console.WriteLine("Ingrese el valor de la primera venta: ");
            venta1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la segunda venta: ");
            venta2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la tercera venta: ");
            venta3 = double.Parse(Console.ReadLine());

            //¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes?

            comisiontotal = (venta1 + venta2 + venta3) * porcentajeComision;
            Console.WriteLine($"Comisión total: {comisiontotal:N0}");

            //¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?

            salariototal = sueldobase + comisiontotal;
            Console.WriteLine($"Salario total: {salariototal:N0}");


        }
    }
}
