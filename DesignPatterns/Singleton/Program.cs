
namespace Singleton
{
    class Program
    {
        private static void Main(string[] args)
        {
            Singleton jogador1 = Singleton.GetInstancia;
            jogador1.Mensagem("Jogador 1: A Bola está comigo nomeio de Campo!");

            Singleton jogador2 = Singleton.GetInstancia;
            jogador2.Mensagem("Jogador 2: Recebi a bola do Jogador 1!");

            Singleton jogador3 = Singleton.GetInstancia;
            jogador3.Mensagem("Jogador 3: Recebi a bola do Jogador 2!");
        }
    }
}