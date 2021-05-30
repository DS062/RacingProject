using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingProject
{
    public partial class Form1 : Form
    {
        Better bet = new Better();
        int player1 = 50, player2 = 50, player3 = 50;

        private void start_race_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Rabit1_pic.Left += bet.jumpRabit();
            Rabit2_pic.Left += bet.jumpRabit();
            Rabit3_pic.Left += bet.jumpRabit();
            Rabit4_pic.Left += bet.jumpRabit();

            if (Rabit1_pic.Left>890) {
                timer1.Stop();
                MessageBox.Show("Rabbit no 1 win the race ");
                if (Johnson_player.Text.Contains("amount")) {
                    String[] f= Johnson_player.Text.Split(' ');
                    player1=bet.winnerResult(Convert.ToInt32(f[8]),1, Convert.ToInt32(f[3]),player1);
                    Johnson_player.Text = "Johnson has "+player1+" Dollar";
                }
                if (Morris_player.Text.Contains("amount"))
                {
                    String[] f = Morris_player.Text.Split(' ');
                    player2 = bet.winnerResult(Convert.ToInt32(f[8]), 1, Convert.ToInt32(f[3]), player2);
                    Morris_player.Text = "Morris has " + player2 + " Dollar";
                }
                if (Nekhro_player.Text.Contains("amount"))
                {
                    String[] f = Nekhro_player.Text.Split(' ');
                    player3 = bet.winnerResult(Convert.ToInt32(f[8]), 1, Convert.ToInt32(f[3]), player3);
                    Nekhro_player.Text = "Nekhro has " + player3 + " Dollar";
                }
                reset();

            }

            else if (Rabit2_pic.Left > 890)
            {
                timer1.Stop();
                MessageBox.Show("Rabbit no 2 win the race ");
                if (Johnson_player.Text.Contains("amount"))
                {
                    String[] f = Johnson_player.Text.Split(' ');
                    player1 = bet.winnerResult(Convert.ToInt32(f[8]), 2, Convert.ToInt32(f[3]), player1);
                    Johnson_player.Text = "Johnson has " + player1 + " Dollar";
                }
                if (Morris_player.Text.Contains("amount"))
                {
                    String[] f = Morris_player.Text.Split(' ');
                    player2 = bet.winnerResult(Convert.ToInt32(f[8]), 2, Convert.ToInt32(f[3]), player2);
                    Morris_player.Text = "Morris has " + player2 + " Dollar";
                }
                if (Nekhro_player.Text.Contains("amount"))
                {
                    String[] f = Nekhro_player.Text.Split(' ');
                    player3 = bet.winnerResult(Convert.ToInt32(f[8]), 2, Convert.ToInt32(f[3]), player3);
                    Nekhro_player.Text = "Nekhro has " + player3 + " Dollar";
                }
                reset();
            }

            else  if (Rabit3_pic.Left > 890)
            {
                timer1.Stop();
                MessageBox.Show("Rabbit no 3 win the race ");
                if (Johnson_player.Text.Contains("amount"))
                {
                    String[] f = Johnson_player.Text.Split(' ');
                    player1 = bet.winnerResult(Convert.ToInt32(f[8]), 3, Convert.ToInt32(f[3]), player1);
                    Johnson_player.Text = "Johnson has " + player1 + " Dollar";
                }
                if (Morris_player.Text.Contains("amount"))
                {
                    String[] f = Morris_player.Text.Split(' ');
                    player2 = bet.winnerResult(Convert.ToInt32(f[8]), 3, Convert.ToInt32(f[3]), player2);
                    Morris_player.Text = "Morris has " + player2 + " Dollar";
                }
                if (Nekhro_player.Text.Contains("amount"))
                {
                    String[] f = Nekhro_player.Text.Split(' ');
                    player3 = bet.winnerResult(Convert.ToInt32(f[8]), 3, Convert.ToInt32(f[3]), player3);
                    Nekhro_player.Text = "Nekhro has " + player3 + " Dollar";
                }
                reset();
            }

            else if (Rabit4_pic.Left > 890)
            {
                timer1.Stop();
                MessageBox.Show("Rabbit no 4 win the race ");
                if (Johnson_player.Text.Contains("amount"))
                {
                    String[] f = Johnson_player.Text.Split(' ');
                    player1 = bet.winnerResult(Convert.ToInt32(f[8]), 4, Convert.ToInt32(f[3]), player1);
                    Johnson_player.Text = "Johnson has " + player1 + " Dollar";
                }
                if (Morris_player.Text.Contains("amount"))
                {
                    String[] f = Morris_player.Text.Split(' ');
                    player2 = bet.winnerResult(Convert.ToInt32(f[8]), 4, Convert.ToInt32(f[3]), player2);
                    Morris_player.Text = "Morris has " + player2 + " Dollar";
                }
                if (Nekhro_player.Text.Contains("amount"))
                {
                    String[] f = Nekhro_player.Text.Split(' ');
                    player3 = bet.winnerResult(Convert.ToInt32(f[8]), 4, Convert.ToInt32(f[3]), player3);
                    Nekhro_player.Text = "Nekhro has " + player3 + " Dollar";
                }
                reset();
            }

        }

        // after playing resist funstion will be enabled

        public void reset() {
            combo_amount.Value = 10;
            combo_player.SelectedIndex = -1;
            combo_rabbit.SelectedIndex = -1;
            Rabit1_pic.Left = 0; Rabit2_pic.Left = 0; Rabit3_pic.Left = 0; Rabit4_pic.Left = 0;
            start_race_btn.Visible = false;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
        }

        // btn fix will check all conditions

        private void bet_fix_btn_Click(object sender, EventArgs e)
        {
            if (bet.chkValue(combo_player.SelectedIndex) == 1) {
                if (bet.chkValue(combo_rabbit.SelectedIndex) == 1) {
                    switch (combo_player.SelectedIndex) {
                        case 0:
                            if (player1 >= combo_amount.Value)
                            {
                                Johnson_player.Text = "Johanson select the " + combo_rabbit.SelectedItem.ToString() + " with the amount of " + combo_amount.Value;
                                start_race_btn.Visible = true;
                            }
                            else {
                                MessageBox.Show("You don't have enough Money ");
                            }
                            
                        break;
                        case 1:
                            if (player2 >= combo_amount.Value)
                            {
                                Morris_player.Text = "Morris select the " + combo_rabbit.SelectedItem.ToString() + " with the amount of " + combo_amount.Value;
                                start_race_btn.Visible = true;
                            }
                            else {
                                MessageBox.Show("You don't have enough Money ");
                            }
                            
                            break;
                        case 2:
                            if (player3 >= combo_amount.Value)
                            {
                                Nekhro_player.Text = "Nekhro select the " + combo_rabbit.SelectedItem.ToString() + " with the amount of " + combo_amount.Value;
                                start_race_btn.Visible = true;
                            }
                            else {
                                MessageBox.Show("You don't have enough Money ");
                            }
                            break;
                        default:
                            MessageBox.Show("You Need to select the details");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Here We need to select the name of the player ");
                }

            }
            else {
                MessageBox.Show("Here We need to select the name of the player ");
            }
        }
    }
}
