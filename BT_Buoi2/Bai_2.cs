using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Buoi2
{
    public partial class Bai_2 : Form
    {
        List<string> values;
        Button firstBtn = null;
        Button secondBtn = null;

        int player = 1;
        int score1 = 0;
        int score2 = 0;
        public Bai_2()
        {
            InitializeComponent();
        }
        void UpdateUI()
        {
            txtScore1.Text = score1.ToString();
            txtScore2.Text = score2.ToString();

            if (player == 1)
            {
                lbPlayer1.BackColor = Color.Yellow;
                lbPlayer2.BackColor = Color.Transparent;
            }
            else
            {
                lbPlayer2.BackColor = Color.Yellow;
                lbPlayer1.BackColor = Color.Transparent;
            }
        }
        void CheckWin()
        {
            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10 };

            if (buttons.All(b => !b.Enabled))
            {
                string result;

                if (score1 > score2)
                    result = "Player 1 thắng!";
                else if (score2 > score1)
                    result = "Player 2 thắng!";
                else
                    result = "Hòa!";

                MessageBox.Show(result);
            }
        }

        void SetupGame()
        {
            values = new List<string>()
            {
                "A","A","B","B","C","C","D","D","E","E"
            };

            Random rd = new Random();
            values = values.OrderBy(x => rd.Next()).ToList();

            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10 };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = "";
                buttons[i].Tag = values[i];
                buttons[i].Enabled = true;
                buttons[i].BackColor = SystemColors.Control;
            }

            player = 1;
            score1 = 0;
            score2 = 0;

            UpdateUI();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            SetupGame();
        }
        void XuLyButton(Button bt)
        {
            if (bt.Tag == null) return;
            if (bt.Text != "") return;

            bt.Text = bt.Tag.ToString();

            if (firstBtn == null)
            {
                firstBtn = bt;
                return;
            }

            secondBtn = bt;

            Timer t = new Timer();
            t.Interval = 600;

            t.Tick += (s, ev) =>
            {
                t.Stop();

                if (firstBtn != null && secondBtn != null)
                {
                    if (firstBtn.Tag.ToString() == secondBtn.Tag.ToString())
                    {
                        firstBtn.Enabled = false;
                        secondBtn.Enabled = false;

                        if (player == 1) score1++;
                        else score2++;
                    }
                    else
                    {
                        firstBtn.Text = "";
                        secondBtn.Text = "";

                        player = (player == 1) ? 2 : 1;
                    }
                }

                firstBtn = null;
                secondBtn = null;

                UpdateUI();
                CheckWin();
            };

            t.Start();
        }
        private void button1_Click(object sender, EventArgs e) { XuLyButton(button1); }
        private void button2_Click(object sender, EventArgs e) { XuLyButton(button2); }
        private void button3_Click(object sender, EventArgs e) { XuLyButton(button3); }
        private void button4_Click(object sender, EventArgs e) { XuLyButton(button4); }
        private void button5_Click(object sender, EventArgs e) { XuLyButton(button5); }
        private void button6_Click(object sender, EventArgs e) { XuLyButton(button6); }
        private void button7_Click(object sender, EventArgs e) { XuLyButton(button7); }
        private void button8_Click(object sender, EventArgs e) { XuLyButton(button8); }
        private void button9_Click(object sender, EventArgs e) { XuLyButton(button9); }
        private void button10_Click(object sender, EventArgs e) { XuLyButton(button10); }

        private void btReset_Click(object sender, EventArgs e)
        {
            SetupGame();
        }
    }
}
