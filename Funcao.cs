using System.Windows;

namespace ProjetoCalculadora
{
    class Funcao
    {
        public static void MsgErro(string Msg)
        {
            MessageBox.Show(Msg,
                            "Algo deu Errado.", 
                            MessageBoxButton.OK);
        }
    }
}
