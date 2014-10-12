/*
 * Created by SharpDevelop.
 * User: COMPAQ
 * Date: 02/10/2014
 * Time: 06:59 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Producto
{
	/// <summary>
	/// Description of .
	/// </summary>
	public class Productos 
	{
		private int cantidad;
		private string descricion;
		private double precio;
		private double total1;
		
		private int cantidad2;
		private string descricion2;
		private double precio2;
		private double total2;
	    
		private int cantidad3;
		private string descricion3;
		private double precio3;
		private double total3;
	    
		private double totalcompra;
		private double totalcompra2;
		private double IVA;
		
		public Productos(){
		}
		
		public void capturarSegundoProducto(){
			Console.WriteLine("\nDame la cantidad del segundo porducto");
		    this.cantidad2=int.Parse (Console.ReadLine ());
			Console.WriteLine("Dame la descripcion del producto");
			this.descricion2=(Console.ReadLine ());
			Console.WriteLine("Dame el precio unitario");
			this.precio2=double.Parse (Console.ReadLine());
			
			this.total2= this.cantidad2*this.precio2;
			}
	
		public void capturarTercerproducto(){
			
		   Console.WriteLine("\nDame la cantidad del tercer porducto");
			this.cantidad3=int.Parse (Console.ReadLine ());
			Console.WriteLine("Dame la descripcion del producto");
			this.descricion3=(Console.ReadLine ());
			Console.WriteLine("Dame el precio unitario");
			this.precio3=double.Parse (Console.ReadLine());
			this.total3= this.cantidad3*this.precio3;
		
			Console.WriteLine("\n");
			
		
		}
		public void capturarPrimerProducto(){
			Console.WriteLine("Dame la cantidad del primer porducto");
			this.cantidad=int.Parse (Console.ReadLine ());
			Console.WriteLine("Dame la descripcion del producto");
			this.descricion=(Console.ReadLine ());
			Console.WriteLine("Dame el precio unitario");
			this.precio=double.Parse (Console.ReadLine());
			
			this.total1= this.cantidad*this.precio;
			
		}
		public void ImprecionCompra(){
		
			
			 Console.WriteLine("Cantidad\t"+this.cantidad +"\t"+ this.descricion+"\t"+ this.total1);
			Console.WriteLine("Cantidad\t"+this.cantidad2 +"\t"+ this.descricion2+"\t"+ this.total2);
		    Console.WriteLine("Cantidad\t"+this.cantidad3 +"\t"+ this.descricion3+"\t"+ this.total3);
			
			this.totalcompra = this.total1 + this.total2 + this.total3;
			Console.WriteLine("\nEl total de la compra sin IVA\t" + totalcompra);
            this.IVA = 7.5;
			Console.WriteLine(".............................+IVA"+this.IVA);
			this.totalcompra2 = this.totalcompra + this.IVA;
			Console.WriteLine("\nEl total de la compra con IVA\t" + this.totalcompra2);
			
			Console.ReadLine();
		}
	
		
		}
	}

