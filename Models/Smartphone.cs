namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }

        
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        private string Model;
        private string IMEI;
        private int Memory;

        public Smartphone(string number, string model, string imei, int memory)
        {  
             // TODO: Passar os parâmetros do construtor para as propriedades
            Number = number;
            IMEI = imei;
            Model = model;
            Memory = memory;  
        }

        public void Call()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstallApp(string appName);
    }
}