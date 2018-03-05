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
            const int MY_NUMBER = 7;
            int UserNumber;
            UserNumber = int.Parse(txtNumber.Text);

            if (UserNumber == MY_NUMBER)
            {
                this.lblCorrect.Show();
                this.lblIncorrect.Hide();
            }

            if (UserNumber != MY_NUMBER)
            {
                this.lblIncorrect.Show();
                this.lblCorrect.Hide();
                
            }

        }
    }
}
