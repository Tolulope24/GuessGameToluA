using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGameToluA
{
    public partial class frmGuessingGame : Form
    {
        public frmGuessingGame()
        {
            InitializeComponent();
            this.lblCorrect.Hide();
            this.lblIncorrect.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            const int MAX_NUMBER = 10;
            const int MyNumber = 4;


           
                
            int MyNumber;
            MyNumber = int.Parse(txtNumber.Text);
            if (MyNumber == MAX_NUMBER);
            this.lblCorrect.Show();
            if (MyNumber != MAX_NUMBER);
            this.lblIncorrect.Show();


        }
    }
}
