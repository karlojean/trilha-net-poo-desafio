namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstallApp(string appName)
        {
            Console.WriteLine("Instalando aplicativo da App Store");
        }
    }
}