class rectangulo:Figura
{
        public int altura, @base;
        public rectangulo
    (string nombre,string color, int altura, int @base):
    base(nombre, color)
    {
        this.altura = altura;
        this.@base = @base;
    }
    
            public override void CalcularArea()
    {
        int Area;
        Area= @base*altura;
        Console.WriteLine("Area rectangulo" + Area);
    }
        public void Imprimir2()
    {
        Console.WriteLine("nombre" + nombre);
        Console.WriteLine("color" + color);
    }
    
}