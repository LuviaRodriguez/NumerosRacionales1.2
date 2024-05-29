namespace NumerosRacionales.Model
{
    public class Racional
    {
        private uint _numerador;
        private uint _denominador;

        public uint Numerador
        {
            get => _numerador;
            set
            {
                if (_numerador != value)
                {
                    _numerador = value;
                }
            }
        }
        public uint Denominador
        {
            get{return _denominador; }
            set
            {
                if ( _denominador !=value)
                {
                    _denominador = value;
                }
            }
}
       
        public Racional(uint numerador, uint denominador)
        {
            Numerador = numerador;
            Denominador = denominador;

        }

        public string ComoTexto()=>$"{Numerador}/{Denominador}";

        public double Fraccion()=> (double)Numerador / Denominador;
        

        public bool EsFraccionPropia()=> Numerador < Denominador;
        

        public Racional Sumar(Racional r) 
        {
            uint numerador;
            uint denominador;

            if (Denominador == r.Denominador)
            {
                numerador = Numerador + r.Numerador;
                denominador = Denominador;
            }
            else 
            {
                numerador = Numerador * r.Denominador + r.Numerador * Denominador;
                denominador = Denominador * r.Denominador;
            }
            return new Racional(numerador, denominador);
        }

        public Racional Restar(Racional r)
        {
            uint numerador;
            uint denominador;

            if (Denominador == r.Denominador)
            {
                numerador = Numerador - r.Numerador;
                denominador = Denominador;
            }
            else
            {
                numerador = Numerador * r.Denominador - r.Numerador * Denominador;
                denominador = Denominador * r.Denominador;
            }
            return new Racional(numerador, denominador);
        }

        public Racional Multiplicar(Racional r)
        {
            uint numerador = Numerador * r.Numerador;
            uint denominador = Denominador * r.Denominador;
            return new Racional(numerador, denominador);
        }

        public Racional Dividir(Racional r)
        {
            uint numerador = Numerador * r.Denominador;
            uint denominador = r.Numerador * Denominador;
            return new Racional(numerador, denominador);
        }
    }
}