﻿using System;
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

namespace ControlesDeUsuario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CbFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdParametrosFigura.Children.Clear();
            switch(cbFigura.SelectedIndex)
            {
                case 0: // Circulo

                    grdParametrosFigura.Children.Add(new ParametroCirculo());

                    break;
                case 1: // Triangulo

                    grdParametrosFigura.Children.Add(new ParametroTriangulo());

                    break;
                case 3: //Cuadrado

                    grdParametrosFigura.Children.Add(new ParametroCuadrado());

                    break;
                case 4: //Pentagono

                    grdParametrosFigura.Children.Add(new ParametroPentagono());

                    break;
                case 5: //Trapecio

                    grdParametrosFigura.Children.Add(new ParametroTrapecio());

                    break;
                default:
                    break;
            }
        }

        private void BtnCalcularArea_Click(object sender, RoutedEventArgs e)
        {
            double area = 0.0;
            switch(cbFigura.SelectedIndex)
            {
                case 0: //Circulo
                    double radio =
                        double.Parse(((ParametroCirculo)(grdParametrosFigura.Children[0])).txtRadio.Text);
                    area = Math.PI * radio * radio;
                    break;
                default:
                    break;
            }
        }
    }
}
