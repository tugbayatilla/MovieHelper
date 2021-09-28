using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieHelper
{
    public partial class FormDrawShapes : MenuFormTemplete
    {
        public FormDrawShapes()
        {
            InitializeComponent();
        }

        private void btnDrawSquare_Click(object sender, EventArgs e)
        {
            try
            {
                MouseEvents.DrawSquare(Convert.ToInt32(txtSquareValue.Text));
            }
            catch
            {
                MessageBox.Show("Only Digits.");
            }
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            try
            {
                MouseEvents.DrawCircle(Convert.ToInt32(txtSquareValue.Text));
            }
            catch
            {
                MessageBox.Show("Only Digits.");
            }
            
        }
    }
}