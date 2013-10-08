//Börjar med att ladda in nödvändiga bibliotek
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Namnrymd för att strukturera upp koden på ett snyggt sätt.
namespace TheGameTicTacToe
{   
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        //Vad ska hända när vi klickar på knappen "Spelare mot spelare"
        private void spelareMotSpelare_Click(object sender, EventArgs e)
        {
            //Vi gömmer detta fönster och visar det andra som visar spelare mot spelare
            playervsplayer theGameWindow = new playervsplayer();
            this.Hide();
            theGameWindow.Show();
        }

        private void Start_FormClosing(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            Settings easy = new Settings();
            this.Hide();
            easy.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
