using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoShipWinForm
{
    public partial class Form1 : Form
    {
        Ship ship = new Ship();
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNewShip_Click(object sender, EventArgs e)
        {
            ship = new Ship();
        }
        private void UpdateUI()
        {
            // Set all the properties to match the ship properties
            progressBar1.Maximum = ship.Capacity;
            
            if (ship.GetShipLoad() <= ship.Capacity)
            {
                progressBar1.Value = ship.GetShipLoad(); 
            }

        }
    }
}
