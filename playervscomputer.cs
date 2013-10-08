using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGameTicTacToe
{
    public partial class playervscomputer : Form
    {
        public playervscomputer()
        {
            InitializeComponent();
        }

        //Vi deklarerar några variabler som ska användas lite längre ner i programmet
        bool[,] X, O;
        string player;
        bool finished; //Denna blir sann när spelet är slut
        int difficulity; //Vad har vi för svårighetsgrad
        string ButtonsIndexs; //Här sparar vi ner de val som finns kvar att göra. 
        int x, y; //Våra snygga kordinatotr
        Random rand; //Denna del gör det "väldigt" svårt att slå denna spelaren;)


        //Vi börjar med att rensa alla värden för att ha ett cleant spel:-)
        private void resetVars()
        {
            ButtonsIndexs = "123456789";
            finished = false;
            rand = new Random(); //Shake hskke
            O = new bool[3, 3];
            X = new bool[3, 3];
        }

        //Vi skriver på kanppen för att visa om den är tagen eller ej. Underlättar lite för de mänskliga:-).
        private void WriteOnButton(string player, Button targetBtn)
        {
            if (player == "O")
            {
                targetBtn.ForeColor = Color.Orange;
                O[x, y] = true; //Nu är banne mig denna plats tagen av Mr O!
            }
            else
            {
                targetBtn.ForeColor = Color.Black;
                X[x, y] = true; //Nä, nu blev denna plats tagen av Mr X!
            }
            targetBtn.Text = player;// Spännande, skriver vi X eller O här? Det beror givetvis på vem som tur det är:-)

            //Vi plockar bort numret på knappen från ButtonsIndexs
            if(targetBtn == button1)
            {
                ButtonsIndexs = ButtonsIndexs.Remove(ButtonsIndexs.IndexOf('1'),1);
            }
            if (targetBtn == button2)
            {
                ButtonsIndexs = ButtonsIndexs.Remove(ButtonsIndexs.IndexOf('2'), 1);
            }
            if (targetBtn == button3)
            {
                ButtonsIndexs = ButtonsIndexs.Remove(ButtonsIndexs.IndexOf('3'), 1);
            }
            if (targetBtn == button4)
            {
                ButtonsIndexs = ButtonsIndexs.Remove(ButtonsIndexs.IndexOf('4'), 1);
            }
            if (targetBtn == button5)
            {
                ButtonsIndexs = ButtonsIndexs.Remove(ButtonsIndexs.IndexOf('5'), 1);
            }
            if (targetBtn == button6)
            {
                ButtonsIndexs = ButtonsIndexs.Remove(ButtonsIndexs.IndexOf('6'), 1);
            }
            if (targetBtn == button7)
            {
                ButtonsIndexs = ButtonsIndexs.Remove(ButtonsIndexs.IndexOf('7'), 1);
            }
            if (targetBtn == button8)
            {
                ButtonsIndexs = ButtonsIndexs.Remove(ButtonsIndexs.IndexOf('8'), 1);
            }
            if (targetBtn == button9)
            {
                ButtonsIndexs = ButtonsIndexs.Remove(ButtonsIndexs.IndexOf('9'), 1);
            }
        }

        //Nu är det datorns tur att visa vad den går för.
        private void EasyPcTurnToWrite(string player)
        {
            //Vi kollar igenom ButtonsIndex och tar en av de lediga rutorna.
            int index = int.Parse(ButtonsIndexs[rand.Next(ButtonsIndexs.Length)].ToString()); //Gör att vi löper vidare i listan.
            switch (index)
            {
                case 1: x = y = 0; WriteOnButton(player, button1); break; //Första rutan
                case 2: x = 0; y = 1; WriteOnButton(player, button2); break; //Andra rutan
                case 3: x = 0; y = 2; WriteOnButton(player, button3); break; //Tredje rutan
                case 4: x = 1; y = 0; WriteOnButton(player, button4); break; //Mitten radens första
                case 5: x = 1; y = 1; WriteOnButton(player, button5); break; //Mitten randes andra
                case 6: x = 1; y = 2; WriteOnButton(player, button6); break; //Mitten radens tredje
                case 7: x = 2; y = 0; WriteOnButton(player, button7); break; //Nedre randen första
                case 8: x = 2; y = 1; WriteOnButton(player, button8); break; //Nedre randen andra
                case 9: x = 2; y = 2; WriteOnButton(player, button9); break; //Nedre randen tredje
            }
        }

        private void getCoordinates(int p, out int x, out int y)
        {//Ändrar variablerna x, y
            switch (p)
            {
                case 1: x = 0; y = 0; break;
                case 2: x = 0; y = 1; break;
                case 3: x = 0; y = 2; break;
                case 4: x = 1; y = 0; break;
                case 5: x = 1; y = 1; break;
                case 6: x = 1; y = 2; break;
                case 7: x = 2; y = 0; break;
                case 8: x = 2; y = 1; break;
                default: x = 2; y = 2; break;
            }
        }

        private bool clicked(int index)
        {//Sant om den har blivit klickad på och falsk om den fortfarande är klickbar:-)
            return (ButtonsIndexs.IndexOf(index.ToString()) == -1);
        }
        private bool clicked(int index, string p)
        {//Kollar om p är skrivet på en knapp. overload method.
            int a, b;
            switch (index)
            {
                case 1: a = 0; b = 0; break;
                case 2: a = 0; b = 1; break;
                case 3: a = 0; b = 2; break;
                case 4: a = 1; b = 0; break;
                case 5: a = 1; b = 1; break;
                case 6: a = 1; b = 2; break;
                case 7: a = 2; b = 0; break;
                case 8: a = 2; b = 1; break;
                default: a = 2; b = 2; break;
            }
            if (p == "X")
                return (X[a, b]);
            return (O[a, b]);
        }

        private void Write_buttonIndex(int index, string toWrite)
        {//Skriver in towrite med det indexet som vi har
            switch (index)
            {
                case 1: WriteOnButton(toWrite, button1); break;
                case 2: WriteOnButton(toWrite, button2); break;
                case 3: WriteOnButton(toWrite, button3); break;
                case 4: WriteOnButton(toWrite, button4); break;
                case 5: WriteOnButton(toWrite, button5); break;
                case 6: WriteOnButton(toWrite, button6); break;
                case 7: WriteOnButton(toWrite, button7); break;
                case 8: WriteOnButton(toWrite, button8); break;
                default: WriteOnButton(toWrite, button9); break;
            }
        }

        private bool check(int i, int k, string toCheck, string toWrite)
        {
            //K1 för rader, K2 för columner osv.
            string P = (toWrite == "X") ? "O" : "X";
            if ((clicked(i, toCheck) && clicked(i + k, toCheck) && !clicked(i + k + k)))
            {
                getCoordinates(i + k + k, out x, out y);
                Write_buttonIndex(i + k + k, toWrite);
                return true;
            }
            if ((clicked(i, toCheck) && clicked(i + k + k, toCheck) && !clicked(i + k)))
            {
                getCoordinates(i + k, out x, out y);
                Write_buttonIndex(i + k, toWrite);
                return true;
            }
            if ((clicked(i + k, toCheck) && clicked(i + k + k, toCheck) && !clicked(i)))
            {
                getCoordinates(i, out x, out y);
                Write_buttonIndex(i, toWrite);
                return true;
            }
            return false;
        }

        private void hardPcTurnWrite(string p)
        {
            string q = (p == "X") ? "O" : "X";
            //Låt oss kola om vi kan vinna:-)
            if (!check(1, 1, p, p))
                if (!check(4, 1, p, p))
                    if (!check(7, 1, p, p))
                        if (!check(1, 3, p, p))
                            if (!check(2, 3, p, p))
                                if (!check(3, 3, p, p))
                                    if (!check(1, 4, p, p))
                                        if (!check(3, 2, p, p))
                                            if (!check(1, 1, q, p))
                                                //Haha, ser inte ut som vi kan, låt oss försvara oss!!
                                                if (!check(4, 1, q, p))
                                                    if (!check(7, 1, q, p))
                                                        if (!check(1, 3, q, p))
                                                            if (!check(2, 3, q, p))
                                                                if (!check(3, 3, q, p))
                                                                    if (!check(1, 4, q, p))
                                                                        if(!check(3, 2, q, p))
                                                                            //Randomize this man!
                                                                        EasyPcTurnToWrite(p);   
        }

        //Diagonal vinst kanske på G;-)
        private bool Diagonals(bool[,] current)
        {
            return (
                (current[0, 0] && current[1, 1] && current[2, 2])
                ||
                (current[0, 2] && current[1, 1] && current[2, 0])
                );
        }

        //Var den en rad som vann?

        private bool Row(int player, bool[,] current)
        {
            //Klockan är för mycket nu för mig. Player kanske inte är det bästa var namnet. Borde kanske vara playerChoice?
            return (current[0, player] && current[1, player] && current[2, player]); 
        }

        private bool Column(int player, bool[,] current)
        {
            //Vann vi här på kolumn?
            return (current[player, 0] && current[player, 1] && current[player, 2]);
        }

        //Vart det nu en vinst eller blev det lika?
        private bool checkForHappynessOrNo(bool [,] current)
        {
            if (Row(0, current) || Row(1, current) || Row(2, current) || Column(0, current) || Column(1, current) || Column(2, current) || Diagonals(current))
            {
                //Nu delar vi ut en liten poäng
                if (current == X)
                {
                    xLabel.Text = (int.Parse(xLabel.Text) + 1).ToString();
                }
                else
                {
                    oLabel.Text = (int.Parse(oLabel.Text) + 1).ToString();
                }
                //Nu var spelet slut! Kul?
                finished = true; //Nu har vi satt spelet till ett slut
                MessageBox.Show(string.Format("{0} Vinner(Denna gång. Hur blir nästa?", (ButtonsIndexs.Length % 2 == 0) ? "X" : "O"));//Slänger ut ett litet meddelande. Kanske inte det snyggaste, men... Kör en ny typ för mig att använda variabel i en text. Smidigt...
            }
            else
            {
                if(ButtonsIndexs == "")
                {
                    //Spelet är nu slut. Det blev lika:-(
                    finished = true;
                    MessageBox.Show("Lika! Detta går inte. Spela igen:-)");
                }
            }
            return finished;
        }

        //Kollar om vi har klickar här tidigare
        private bool checkIfClickedBefore(Button btn, out int x, out int y)
        {
            x = y = 0;
            switch (btn.Name)
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

        //Vill du spela igen? Vad roligt! Här har du den knappen. Jag nollställer spelet till dig.
        private void playAgainBtn_Click(object sender, EventArgs e)
        {
            resetVars();
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
            if (player == "O") player = "X"; //Skriven en kort if-sats. Har varit lite för generös med långa If-satser. Får väl visa mitt utbud:-)
            else
            {
                player = "O";
                if (difficulity == 0)
                {
                    EasyPcTurnToWrite("X");
                }
                else
                {
                    hardPcTurnWrite("X");
                }
            }
        }

        private void gameBtns_Click(object sender, EventArgs e)
        {
            if(!checkIfClickedBefore(sender as Button, out x, out y) && !finished)
            {
                if (player == "O")
                {
                    WriteOnButton("O", sender as Button);
                    if (!checkForHappynessOrNo(O))
                    {
                        //Datorns tur
                        if (difficulity == 0)
                        {
                            EasyPcTurnToWrite("X");
                        }
                        else
                        {
                            hardPcTurnWrite("X");
                            checkForHappynessOrNo(X);
                        }
                    }
                }
                else
                {
                    //The humans tur
                    WriteOnButton("X", sender as Button); //Glömt att kommentera detta partiet. Använder sneder som en Button:-)
                    if (!checkForHappynessOrNo(O))
                    {
                        //Datorns tur
                        if (difficulity == 0)
                        {
                            EasyPcTurnToWrite("O");
                        }
                        else
                        {
                            hardPcTurnWrite("O");
                            checkForHappynessOrNo(O);
                        }
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (difficulity == 0)
                easyRB.Checked = true;
            else
                normalRB.Checked = true;
            playAgainBtn.PerformClick();
            xLabel.Text = oLabel.Text = "0";
            tableLayoutPanel1.Visible = false;
            this.Size = new Size(229, 300);
        }

        private void easyRB_Click(object sender, EventArgs e)
        {
            difficulity = 0;
        }

        private void hardRB_Click(object sender, EventArgs e)
        {
            difficulity = 1;
        }

        private void mainBtns(object sender, EventArgs e)
        {
            player = (sender as Button).Text; // Är du ett X eller ett O, huh?
            this.Size = new Size(382, 300); //Ändrar storleken på formuläret.
            tableLayoutPanel1.Visible = true; //Visar alla barnen
            if (difficulity == 0)
            {
                if (player == "O")
                {
                    EasyPcTurnToWrite("X");//Så Datorn fick va X:et idag..
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (player == "O")
                {
                    hardPcTurnWrite("X");
                }
            }
        }

        private void gobackBtn_Click(object sender, EventArgs e)
        {
            playervsplayer thegame = new playervsplayer();
            this.Hide();
            thegame.Show();
        }

        private void theGame_load(object sender, EventArgs e)
        {
            difficulity = 0;
            resetVars();
        }

        

    }
}
