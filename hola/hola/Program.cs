/*
 * Created by SharpDevelop.
 * User: COMPAQ
 * Date: 01/10/2014
 * Time: 09:02 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace hola
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Dame el primer numero");
			int numero1=int.Parse (Console.ReadLine ());
			Console.WriteLine("Dame el segundo numero");
			int numero2=int.Parse (Console.ReadLine());
			
			int resultado = numero1 + numero2;
			Console.WriteLine("El resultado es\t" + resultado);
			Console.ReadLine();
		}
	}
}