using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace KP_WINFORM_RACE
{
    public partial class Menu : Form
    {
        private string chosenRunner;
        private int money;
        private int bet;
        private int winAmount;

        public Menu()
        {
            InitializeComponent();
            money = 5000;
        }

        private void blueRunner_Click(object sender, EventArgs e)
        {
            chosenRunner = "blueRunner";
            UpdateForm();
        }

        private void yellowRunner_Click(object sender, EventArgs e)
        {
            chosenRunner = "yellowRunner";
            UpdateForm();
        }

        private void purpleRunner_Click(object sender, EventArgs e)
        {
            chosenRunner = "purpleRunner";
            UpdateForm();
        }

        private void redRunner_Click(object sender, EventArgs e)
        {
            chosenRunner = "redRunner";
            UpdateForm();
        }

        private void greenRunner_Click(object sender, EventArgs e)
        {
            chosenRunner = "greenRunner";
            UpdateForm();
        }

        public void Result(bool isWin, int coeff, int prevBet)
        {
            if (isWin)
            {
                winAmount = (prevBet * coeff);
                lblResult.ForeColor = Color.Green;
                lblResult.Text = $"+ {winAmount}";
                money += bet * coeff;
            }
            else
            {
                winAmount = (prevBet);
                lblResult.ForeColor = Color.Red;
                lblResult.Text = $"- {winAmount}";
                money -= bet;
            }
            ClearForm();
            UpdateForm();
        }
        private void ClearForm()
        {
            bet = 0;
            tbBet.Text = "0";
            chosenRunner = "";
            lblError.Text = "";
        }

        private void UpdateForm()
        {
            lblMoney.Text = $"Money: {money}";
            lblRunner.Text = $"Runner: {chosenRunner}";
            lblBet.Text = $"Bet: {bet}";
            tbBet.Text = bet.ToString();
            tbBet.Select(tbBet.Text.Length, 0);
            Invalidate();
        }

        private void tbBet_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(tbBet.Text, out bet) || money - bet < 0)
            {
                bet = 0;
                tbBet.Text = "0";
            }
            UpdateForm();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(chosenRunner) || bet <= 0)
            {
                lblError.Text = "Необходимо выбрать игрока и ставку";
                return;
            }
            Hide();
            Game game = new Game(this);
            game.TransferData(chosenRunner, bet);
            game.ShowDialog();
            Show();
        }

        private void SaveGame()
        {
            // Loading our data to the PlayerData class
            var data = new PlayerData
            {
                Money = this.money
            };

            // Converting the PlayerData to string json by JsonConvert.SerializeObject
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);

            // Filling the file "save.json" with converted json
            File.WriteAllText("save.json", json);

        }

        public void LoadGame()
        {
            // Checking if the save file exists
            if (!File.Exists("save.json"))
                return;

            // Reading json file
            string json = File.ReadAllText("save.json");

            // Filling the PlayerData class with saved parameters by JsonConvert.DeserializeObject<PlayerData>(data)
            PlayerData data = JsonConvert.DeserializeObject<PlayerData>(json);

            money = data.Money;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveGame();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            LoadGame();
            UpdateForm();
        }

        public void SetMoney(uint money)
        {
            this.money = (int)money;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetMoney form = new SetMoney(this);
            form.ShowDialog();
            UpdateForm();
        }
    }
}
