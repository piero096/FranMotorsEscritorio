using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FranMotors
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }
        public void UpdateProgress(int value)
        {
            // Asegurarse de que el valor esté dentro del rango de la barra de progreso
            value = Math.Max(0, Math.Min(value, progressBar1.Maximum));
            progressBar1.Value = value;
        }
    }
}
