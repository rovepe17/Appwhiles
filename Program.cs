using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwhiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad, contador = 1, contador2 = 0;
            float longitud;
            Console.WriteLine("programa contador piezas aptas");
            Console.WriteLine("la cantidad de piezas:");
            cantidad = int.Parse(Console.ReadLine());
            while(contador<=cantidad)
            {
                Console.WriteLine("ingrese longitud de la pieza:");
                longitud=float.Parse(Console.ReadLine());
                if (longitud >=1.20 &&longitud <= 1.30)
    {
        contador2=contador2++;
    }
    contador++;
}
Console.WriteLine("numero de piezas aptas:"+contador2);
Console.ReadKey();
}
    }
}
