using System;

namespace trabajo_Angel_Gabriel
{
        class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();

            cuadrado cuadrado1 = new cuadrado
            ("ejemplo1", "verde", 8);
            cuadrado1.Imprimir1();
            lista.Add(cuadrado1);

            rectangulo rectangul = new rectangulo
            ("ejemplo2", "amarillo", 3, 5);
            rectangul.Imprimir2();
            lista.Add(rectangul);

            circulo rectangulo1 = new circulo
            ("ejemplo3", "verde", 8, 3.14);
            rectangulo1.Imprimir3();
            lista.Add(rectangulo1);
            
            foreach(Figura item in lista)
            {
                item.CalcularArea();
            }
        }
    }
}