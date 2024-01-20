using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Matriz_Transpuesta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizOriginal = new int[3, 3];
            int[,] matrizTranspuesta = new int[3, 3];
            
            for (int i = 0; i < 3 ; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizOriginal[i, j] = int.Parse(Interaction.InputBox("Ingresa el elemento de la MatrizOriginal[" + (i + 1) + "," + (j + 1) + "]"));
                }

            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizTranspuesta[i, j] = matrizOriginal[j, i];
                }
            }
            string resultado = "Matriz Original\n";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultado = resultado + matrizOriginal[i, j] + " | ";
                }
                resultado = resultado + "\n";
            }
            resultado += "\n\nMatriz Transpuesta\n";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultado = resultado + matrizTranspuesta[i, j] + " | ";
                }
                resultado = resultado + "\n";
            }
            
            MessageBox.Show(resultado);
        }
    }
}
