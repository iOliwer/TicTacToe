//Laddar in det som är nödvändigt
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Namnrymden för en snygg och lättillgänglig struktur
namespace TheGameTicTacToe
{
    public partial class playervsplayer : Form
    {
        public playervsplayer()
        {
            InitializeComponent();
        }

        //Vi börjar med att deklarera någora variabler som ska användas senare
        Button clickedBtn; //för att samla datan från den knapp som vi klickade på.
        int whoseTurn; //För att avgöra vems tur det är
        bool[,] X/* X spelarens knappar */, O/*O spelarens knappar*/, cells/*Ockuperade celler*/, current/*X eller O*/; //Använder oss av ett 3x3 koordinatsystem
        string player; //X eller O
        bool finished; //Sant när spelet är slut

        private void gamePlayBtn_Click(object sender, EventArgs e)
        {
            int x, y;
            //Vi kontrollernar nu så att användaren klickar på en knapp, om ja, så tar vi kordinaterna (x,y)
            //Vi kontrollerar även så att spelet inte är slut:-)

            if (!wasClickedBefore(sender as Button, out x, out y) && !finished)
            {
                clickedBtn = (sender as Button); //Den klickade knappen från spelplanen

                if (whoseTurn == 0)
                {
                    (sender as Button).ForeColor = Color.Blue; //Ändrar färget på markeringen till blå
                    player = "X";
                    X[x, y] = true; //Vi tar ut positionen och markerar att denna har blivit ockuperad av Mr X!
                    current = X;
                }
                else
                {
                    (sender as Button).ForeColor = Color.Red; //Ändrar färgen till röd
                    player = "O";
                    O[x, y] = true; //Hämtar positionen och ockuperar nu platsen av O
                    current = O;
                }
                (sender as Button).Text = player; //Skriver ut rätt tecken X eller O

                cells[x, y] = true; //Denna platsen är numera fullsatt:-)
                whoseTurn = (whoseTurn + 1) % 2; //Här bytar vi tur. Vi skiftar mellan 0 och 1

                //Nu kollar vi efter en vinst
                if(Row(0) || Row(1) || Row(2) || Column(0) || Column(1) || Column(2) || Diagonals())
                {
                    //Uppdaterar poängnen
                    if(player == "X")
                    {
                        xLabel.Text = (int.Parse(xLabel.Text))+1.ToString();
                    }
                    else
                    {
                        oLabel.Text = (int.Parse(oLabel.Text))+1.ToString();
                    }

                    finished = true; //spelet är nu slut
                    MessageBox.Show(string.Format(player + " vinner detta parti!")); //Vi visar resultatet i en enkel messagebox
                }
                else
                    //Vi får inte glömma bort att kolla om det har blivit ojämt:-)
                {
                    bool draw = true;
                    for (int column = 0; column < 3; column++)
                    {
                        for (int row = 0; row < 3; row++)
                        {
                            if(!cells[row, column]) //Om vi hittar en tom rad!
                            {
                                draw = false;
                                break;
                            }
                        }
                        if (draw)
                        {
                            finished = true;
                            MessageBox.Show("Ingen vinnare(Kommer inte på ordet)");
                        }
                    }
                }
            }
        }

        private bool wasClickedBefore(Button button, out int x, out int y)
        {
            x = y = 0;
            switch (button.Name)
            {
                case "button1": x = 0; y = 0; break;
                case "button2": x = 0; y = 1; break;
                case "button3": x = 0; y = 2; break;
                case "button4": x = 1; y = 0; break;
                case "button5": x = 1; y = 1; break;
                case "button6": x = 1; y = 2; break;
                case "button7": x = 2; y = 0; break;
                case "button8": x = 2; y = 1; break;
                case "button9": x = 2; y = 2; break;
            }
            return (X[x, y] || O[x, y]);
        }

        private bool Diagonals()
        {
            return (
                (current[0, 0] && current[1, 1] && current[2, 2])
                ||
                (current[0, 2] && current[1, 1] && current[2, 0])
                );
        }
        
        //Retunerar positioner
        private bool Row(int pos)
        {
            return (current[pos, 0] && current[pos, 1] && current[pos, 2]);
        }

        private bool Column(int pos)
        {
            return (current[0, pos] && current[1, pos] && current[2, pos]);
        }

        //Ställer om våra variabler
        private void resetVariables()
        {
            finished = false;
            whoseTurn = 0;
            O = new bool[3, 3];
            X = new bool[3, 3];
            cells = new bool[3, 3];
        }

        private void theGame_load(object sender, EventArgs e)
        {
            resetVariables(); //Ställer om våra variabler när vi laddar theGame
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            //Ställer om allt till nytt. Tömmer alla rader och fält samt alla variabler
            button1.Text =
            button2.Text =
            button3.Text =
            button4.Text =
            button5.Text =
            button6.Text =
            button7.Text =
            button8.Text =
            button9.Text =
            "";
            resetVariables();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.Show();
        }

    }
}
