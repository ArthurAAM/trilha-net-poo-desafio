namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Instanciando numero para que poçamos ter uma validação na hora de definir o valor
        private string numero;

        // Instanciando novas variáveis para modelo, imei e memória, é possível acessá-las, assim
        // como em um smartphone normal, mas não mudá-las
        private string modelo;
        private string imei;
        private int memoria;

        public string Numero { get => numero; 
        set
            {
                if (value == "")
                {
                    throw new ArgumentException("O número não pode ser vazio");
                }

                numero = value;
            } }
        public string Modelo {get => modelo;}
        public string IMEI {get => imei;}
        public int Memoria {get => memoria;}

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            if (string.IsNullOrWhiteSpace(numero))
            {
                throw new ArgumentException("O número não pode ser nulo ou vazio.");
            }

            Numero = numero;
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;
        }

        public virtual void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public virtual void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}