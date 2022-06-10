class cuadrado:Figura
{
        public int lados;
        public cuadrado
    (string nombre,string color, int lados):base(nombre, color)
    {
        this.lados = lados;
    }
    
            public override void CalcularArea()
    {
        int Area;
        Area= lados*lados;
        Console.WriteLine("Area cuadrado" + Area);
    }
        public void Imprimir1()
    {
        Console.WriteLine("nombre" + nombre);
        Console.WriteLine("color" + color);
    }


} 