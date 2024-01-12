namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" - FEITO
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero,  modelo, imei, memoria)
        {

        }
        // TODO: Sobrescrever o método "InstalarAplicativo" - FEITO
         public override void InstalarAplicativo(string nomeApp)
         {
            Console.WriteLine($"Sistema IOS: \n Iniciando a instalação do Aplicativo {nomeApp}");
            Console.WriteLine($"{nomeApp}, já está pronto na sua tela inicial");
         }
    }
}