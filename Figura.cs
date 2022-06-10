using System;
abstract class Figura
{

        public string nombre, color;
        public Figura
    (string nombre,string color)
    {
        this.nombre = nombre;
        this.color = color;
    }
        public abstract void CalcularArea();
}