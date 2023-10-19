namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string number, string imei, string model, int memory) : base(number, imei, model, memory)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Instalando Aplicativo {appName} do PlayStore");
        }
    }
}