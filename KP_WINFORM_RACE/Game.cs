using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP_WINFORM_RACE
{
    public partial class Game : Form
    {
        private Menu game;
        private Random rnd;
        private Runner runner;
        private int bet;
        private int XStart;
        private int YStart;
        private int XFinish;
        private int runnerHeight;
        private string winnerName;
        private string chosenRunner;

        Runner[] runners = new Runner[5];
        Dictionary<string, int> coeff;
        string[] runNames = {
            "blueRunner",
            "redRunner",
            "yellowRunner",
            "purpleRunner",
            "greenRunner"
        };
        
        public Game(Menu game)
        {
            InitializeComponent();

            this.game = game;
            XStart = 50;
            XFinish = ClientSize.Width - 50;
            YStart = 200;

            coeff = new Dictionary<string, int>
            {
                { runNames[0], 2},
                { runNames[1], 4},
                { runNames[2], 6},
                { runNames[3], 8},
                { runNames[4], 10},
            };
        }

        private void Game_Load(object sender, EventArgs e)
        {
            rnd = new Random();
            //runnerHeight = new Runner(0, 0, 0, "").height;
            runnerHeight = 70;

            for (int i = 0; i < 5; i++)
            {
                runner = new Runner(XStart, YStart + i * (runnerHeight - 30), (float) rnd.NextDouble() * 10, runNames[i], this);
                runners[i] = runner;
            }
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            foreach (var runner in runners)
            {
                runner.Draw(e.Graphics);
            }
        }

        public void TransferData(string chosenRunner, int bet)
        {
            this.chosenRunner = chosenRunner;
            this.bet = bet;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var runner in runners)
            {
                if (rnd.Next(2) == 0)
                    runner.adSpeed += (float)rnd.NextDouble();
                else if (runner.adSpeed > 0)
                    runner.adSpeed -= (float)rnd.NextDouble();

                if (runner.xw >= XFinish)
                {
                    winnerName = runner.name;
                    game.Result(winnerName == chosenRunner, coeff[chosenRunner], bet);
                    Close();
                }
                runner.Move();
            }
            Invalidate();
        }
    }
}
