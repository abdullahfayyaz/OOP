using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_FINALIZED.BL;

namespace HMS_FINALIZED
{
    public partial class RoomsCategoryUC : UserControl
    {
        public RoomsCategoryUC()
        {
            InitializeComponent();
            Panel_Room.Visible = false;
        }

        private void RoomsCategoryUC_Load(object sender, EventArgs e)
        {
            Room room = new Room();
            SinglePriceLabel.Text = Convert.ToString(room.TypeSingle);
            DoublePriceLabel.Text = Convert.ToString(room.TypeDouble);
            TriplePriceLabel.Text = Convert.ToString(room.TypeTriple);
            TwinPriceLabel.Text = Convert.ToString(room.TypeTwin);
            KingPriceLabel.Text = Convert.ToString(room.TypeKing);
            ExecutivePriceLabel.Text = Convert.ToString(room.TypeExecutive);
        }

        private void NextGradientButton_Click(object sender, EventArgs e)
        {
            Panel_Room.Visible = true;
        }

        private void BackGradientButton_Click(object sender, EventArgs e)
        {
            Panel_Room.Visible = false;
        }
    }
}
