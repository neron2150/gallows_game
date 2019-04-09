using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        string bufword;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void setwordbtnclick(object sender, MouseEventArgs e)
        {
            bufword += (sender as Button).Text;
            lblsetuserword.Text += "*";
        }

        private void button33_Click(object sender, EventArgs e) //backspace
        {
            if (bufword != "")
            {
                bufword = bufword.Remove(bufword.Length - 1, 1);
                lblsetuserword.Text = lblsetuserword.Text.Remove(lblsetuserword.Text.Length - 1, 1);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button67_Click(object sender, EventArgs e) //кнопка "Готово" 
        {
            Gallows.obj.MainWord = bufword;
            Gallows.obj.UserWord = Gallows.Replace(Gallows.obj.MainWord);
            tabControl1.SelectedTab = tabPage2; //смена страницы
            lbluserword.Text = Gallows.obj.UserWord;
            lblfinishword.Text = Gallows.obj.MainWord;
        }


        ////// tabpage 2 //////
        private void setthemebtnclick(object sender, MouseEventArgs e) 
        {
            
            lblsettheme.Text += (sender as Button).Text;
        }

        private void button34_Click(object sender, EventArgs e) //backspace
         {
            if (lblsettheme.Text != "")
            {

                lblsettheme.Text = lblsettheme.Text.Remove(lblsettheme.Text.Length - 1, 1);
            }
        }

        private void button68_Click(object sender, EventArgs e) //кнопка "Готово" 
        {
            Gallows.obj.Theme = lblsettheme.Text;
            lbltheme.Text = Gallows.obj.Theme;
            tabControl1.SelectedTab = tabPage3; //смена страницы
            
        }


        ////// tabpage 3 //////
        private void wordbtnclick(object sender, MouseEventArgs e)
        {
           lbluserword.Text =  Gallows.obj.LetterSelection(Convert.ToChar((sender as Button).Text));
           (sender as Button).Visible = false;
             switch (Gallows.obj.Chanse)
                    {
                        case 1: { pictureBox1.Image = Properties.Resources.p1; pictureBox1.Visible = true; } break;
                        case 2: {pictureBox1.Image = Properties.Resources.p2;   pictureBox1.Visible = true; } break;
                        case 3: {pictureBox1.Image = Properties.Resources.p3;   pictureBox1.Visible = true; } break;
                        case 4: {pictureBox1.Image = Properties.Resources.p4;   pictureBox1.Visible = true; } break;
                        case 5: pictureBox1.Image = Properties.Resources.p5; break;
                        case 6: pictureBox1.Image = Properties.Resources.p6; break;
                        case 7: pictureBox1.Image = Properties.Resources.p7; break;
                        case 8: pictureBox1.Image = Properties.Resources.p8; break;
                        case 9: pictureBox1.Image = Properties.Resources.p9; break;
                        case 10: pictureBox1.Image = Properties.Resources.p10; break;
                        case 11: pictureBox1.Image = Properties.Resources.p11; break;
                        case 12:
                            {
                                lblfinish.Text = "Вы проиграли :(";
                                pictureBox1.Image = Properties.Resources.p12; 
                                tabControl1.SelectedTab = tabPage4;

                            } 
                            break;
                            
                    }
            if (Gallows.obj.MainWord ==Gallows.obj.UserWord)
            {
                lblfinish.Text = "Вы выиграли!!!";
                tabControl1.SelectedTab = tabPage4;            
            }
            
        }
        ////// tabpage 4 //////
        private void button100_Click(object sender, EventArgs e)//выход
        {
            this.Close();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            Gallows.obj = new Gallows();
            tabControl1.SelectedTab = tabPage5;
            button70.Visible = true;
            button71.Visible = true;
            button72.Visible = true;
            button73.Visible = true;
            button74.Visible = true;
            button75.Visible = true;
            button76.Visible = true;
            button77.Visible = true;
            button78.Visible = true;
            button79.Visible = true;
            button80.Visible = true;
            button81.Visible = true;
            button82.Visible = true;
            button83.Visible = true;
            button84.Visible = true;
            button85.Visible = true;
            button86.Visible = true;
            button87.Visible = true;
            button88.Visible = true;
            button89.Visible = true;
            button90.Visible = true;
            button91.Visible = true;
            button92.Visible = true;
            button93.Visible = true;
            button94.Visible = true;
            button95.Visible = true;
            button96.Visible = true;
            button97.Visible = true;
            button98.Visible = true;
            button99.Visible = true;
            button100.Visible = true;
            button101.Visible = true;
            button102.Visible = true;
            pictureBox1.Visible = false;
            lblsettheme.Text = "";
            lblsetuserword.Text = "";
            bufword = "";



        }

        private void SelectDifficulty(object sender, MouseEventArgs e)
        {
            btndiff1.Image = Properties.Resources.bigbtnOrange;
            btndiff2.Image = Properties.Resources.bigbtnOrange;
            btndiff3.Image = Properties.Resources.bigbtnOrange;
            btndiff4.Image = Properties.Resources.bigbtnOrange;

            (sender as Button).Image = Properties.Resources.bigbtnOrangeEnter;
            Gallows.obj.Difficulty = Convert.ToByte((sender as Button).Tag);
        }

        private void button103_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button104_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            Gallows.obj.ComputerWordSelection();
            lbltheme.Text = Gallows.obj.Theme;
            Gallows.obj.UserWord = Gallows.Replace(Gallows.obj.MainWord);
            lbluserword.Text = Gallows.Replace(Gallows.obj.MainWord);
            lblfinishword.Text = Gallows.obj.MainWord;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
