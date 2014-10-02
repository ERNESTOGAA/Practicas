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
			Console.WriteLine("Dame la cantidad del primer porducto");
			int cantidad=int.Parse (Console.ReadLine ());
			Console.WriteLine("Dame la descripcion del producto");
			string descricion=(Console.ReadLine ());
			Console.WriteLine("Dame el precio unitario");
			double precio=double.Parse (Console.ReadLine());
			
			   double total1= cantidad*precio;
			
			Console.WriteLine("\nDame la cantidad del segundo porducto");
			int cantidad2=int.Parse (Console.ReadLine ());
			Console.WriteLine("Dame la descripcion del producto");
			string descricion2=(Console.ReadLine ());
			Console.WriteLine("Dame el precio unitario");
			double precio2=double.Parse (Console.ReadLine());
			double total2= cantidad2*precio2;
			
			Console.WriteLine("\nDame la cantidad del tercer porducto");
			int cantidad3=int.Parse (Console.ReadLine ());
			Console.WriteLine("Dame la descripcion del producto");
			string descricion3=(Console.ReadLine ());
			Console.WriteLine("Dame el precio unitario");
			double precio3=double.Parse (Console.ReadLine());
			double total3= cantidad3*precio3;
			 
			Console.WriteLine("\n");
			
			 Console.WriteLine("Cantidad\t"+cantidad +"\t"+ descricion+"\t"+ total1);
			Console.WriteLine("Cantidad\t"+cantidad2 +"\t"+ descricion2+"\t"+ total2);
		    Console.WriteLine("Cantidad\t"+cantidad3 +"\t"+ descricion3+"\t"+ total3);
			
			double totalcompra = total1 + total2 + total3;
			Console.WriteLine("\nEl total de la compra sin IVA\t" + totalcompra);
			double IVA = 7.5;
			Console.WriteLine(".............................+IVA"+IVA);
			double totalcompra2 = totalcompra + IVA;
			Console.WriteLine("\nEl total de la compra con IVA\t" + totalcompra2);
			//int total = numero1 + numero2;
			//Console.WriteLine("El resultado es\t" + resultado);
			Console.ReadLine();
		}
	}
}