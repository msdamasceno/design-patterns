namespace Mediator
{
    class Programa
    {
        static void Main(string[] args)
        {
            MediatorConcreto m = new MediatorConcreto();
            ColegaConcreto1 colega1 = new ColegaConcreto1(m);
            ColegaConcreto2 colega2 = new ColegaConcreto2(m);
            
            m.Colega1 = colega1;
            m.Colega2 = colega2;

            colega1.Enviar("Como você está?");
            colega2.Enviar("Bem, Obrigado!");

            Console.ReadKey();
        }
    }
}