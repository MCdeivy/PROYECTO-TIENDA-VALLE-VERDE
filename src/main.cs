//Desarrollar un programa para la  TIENDA VALLE VERDE, el cual permita calcular la venta total de los productos vendidos en un dia, teniendo en cuenta :
//1. Ingresar el producto a comprar
//2. Ingresar el valor
//3. Ingresar cantidad productos a comprar
//4. Si el pedido es superior o igual a  $10.000 pesos el domicilio es gratis
//5. Si es inferior a $10.000 este tiene un costo de $1.000 pesos adicionales
//6. Si el cliente no confirma método de pago el domicilio se cancela o entra en espera
//7. Si el total de la compra es superior o igual a $100.000 pesos se le hace un descuento del 5%
using System;

class Program
{
    static void Main()
    {
        string nombreProducto;
        double precioProducto;// dato numerico decimal
        int cantidad;//tipo de dato entero
        double subtotal;
        double totalCompra = 0;
        string continuar;// tipo de dato de txtono

        Console.WriteLine("===== TIENDA VALLE VERDE =====");

       
        do//comienza ciclo mientras se cimpla la condicion
        {
            Console.Write("Ingrese el nombre del producto: ");
            nombreProducto = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
            precioProducto = Convert.ToDouble(Console.ReadLine());// sirve para convertir un valor a un numero decimal

            Console.Write("Ingrese la cantidad: ");
            cantidad = Convert.ToInt32(Console.ReadLine());//SIRVE PARA CONVERTIR O REDONDEAR UN NUMERO

            subtotal = precioProducto * cantidad;
            totalCompra += subtotal;

            Console.WriteLine("Producto: " + nombreProducto);
            Console.WriteLine("Subtotal: $" + subtotal);

            Console.Write("¿Desea ingresar otro producto? (si/no): ");
            continuar = Console.ReadLine();

        } while (continuar == "si");//aca se cierra cuando se ponga no

        Console.WriteLine("\nTotal parcial de la compra: $" + totalCompra);

       
        if (totalCompra >= 100000)
        {
            double descuento = totalCompra * 0.05;
            totalCompra -= descuento;
            Console.WriteLine("Se aplicó descuento del 5%: $" + descuento);
        }

       
        if (totalCompra >= 10000)
        {
            Console.WriteLine("Domicilio GRATIS.");
        }
        else
        {
            totalCompra += 1000;
            Console.WriteLine("Domicilio con costo de $1.000.");
        }

     
        Console.Write("¿Confirma método de pago? (si/no): ");
        string confirmaPago = Console.ReadLine();

        if (confirmaPago == "si")
        {
            Console.WriteLine("Pedido confirmado.");
            Console.WriteLine("TOTAL A PAGAR: $" + totalCompra);
        }
        else
        {
            if (confirmaPago == "no")
            {
                Console.WriteLine("El domicilio se cancela o queda en espera hasta que confirmen metodo de pago.");
            }
        }

        Console.WriteLine("Gracias por comprar en TIENDA VALLE VERDE.");
    }
}