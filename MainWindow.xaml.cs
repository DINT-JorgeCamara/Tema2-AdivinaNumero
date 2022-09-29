using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            numSecreto = NumAleatorio();
        }
        public int numSecreto;
        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
            if(int.Parse(NumUsuarioTextBox.Text) == numSecreto)
                PistaTextBlock.Text = "!Enhorabuena. Has acertado el número!";
            else if (int.Parse(NumUsuarioTextBox.Text) > numSecreto)
                PistaTextBlock.Text= "Pista: el número es menor";
            else PistaTextBlock.Text = "Pista: el número es mayor";
            NumUsuarioTextBox.Text = "";
        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numSecreto = NumAleatorio();
            NumUsuarioTextBox.Text = "";
            PistaTextBlock.Text = "";
        }

        private int NumAleatorio()
        {
            Random ran = new Random();
            return ran.Next(0, 101);
        }
    }
}
