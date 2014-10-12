/*
 * Created by SharpDevelop.
 * User: COMPAQ
 * Date: 02/10/2014
 * Time: 06:50 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Producto
{
	class Program
	{
		public static void Main(string[] args)
		{
			Productos productos = new Productos();
			productos.capturarPrimerProducto();
		    productos.capturarSegundoProducto();
		    productos.capturarTercerproducto();
		    productos.ImprecionCompra();
		}
	}
}
