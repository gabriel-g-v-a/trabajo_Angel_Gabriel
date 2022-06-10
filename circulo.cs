class circulo:Figura
{
        public double pi,Radio;

        public circulo
    (string nombre,string color, double Radio, double pi):base(nombre, color)
    {
        this.Radio = Radio;
        this.pi = pi;
    }
    
            public override void CalcularArea()
    {
        double Area;
        Radio= Math.Pow(Radio, 2);
        Area= Radio*pi;
        Console.WriteLine("Area circulo" + Area);
    }
        public void Imprimir3()
    {
        Console.WriteLine("nombre" + nombre);
        Console.WriteLine("color" + color);
    }
}