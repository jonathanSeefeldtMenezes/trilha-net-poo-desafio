namespace DesafioPOO.Models
{
    public class Nokia : Smartphone 
    {
        public Nokia(String numero, String modelo, String imei, int memoria) : base(numero,modelo,imei,memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
             Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no Nokia.");
        }
    }
}