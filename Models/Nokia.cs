namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string number, string name, string model, int memory) : base(number, name, model, memory)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstallApp(string appName)
        {
            Console.WriteLine("Instalando Aplicativo do PlayStore");
        }
    }
}