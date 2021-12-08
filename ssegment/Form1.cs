using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ssegment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* 
           if(.Visible== true)
           {
               .BackColor = Color.;
           }
          */
        private void ChangeEnter(Button sender)
        {
            if (sender.Visible)
            {
                sender.BackColor = Color.Red;
            }
        }
        private void vis(Button sen1)
        {
            sen1.Visible = false;
        }
        private void ChangeLeave(Button sender)
        {
            if (sender.Visible)
            {
                sender.BackColor = Color.Maroon;
            }
        }


        private void forOne_Top_Left1_Left2_MID_BOT(Button sender, Button sender1, Button sender2, Button sender3,Button sender4)
        {
            //top
            sender.Visible = false;

            //left1
            sender1.Visible = false;

            //left2
            sender2.Visible = false;

            //mid
            sender3.Visible = false;

            //bot
            sender4.Visible = false;

        }

       
        private void forTwo_Lef1_rig2(Button sen1,Button sen2)
        {
            sen1.Visible = false;
            sen2.Visible = false;
        }

        private void forThree_lef1_lef2(Button sen1, Button sen2)
        {
            vis(sen1);
            vis(sen2);
        }

        private void forFour_top_lef2_bot(Button sen1,Button sen2, Button sen3)
        {
            vis(sen1);
            vis(sen2);
            vis(sen3);
        }

        private void forFive_right1_lef2(Button sen1, Button sen2)
        {
            vis(sen1);
            vis(sen2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // forOne_Top_Left1_Left2_MID_BOT(hr1_top_btn,hr1_left1_btn,hr1_left2_btn,hr1_mid_btn,hr1_bot_btn);
            // forTwo_Lef1_rig2(hr2_lef1_btn,hr2_rig2_btn);

            //forThree_lef1_lef2(hr1_left1_btn, hr1_left2_btn);

            // forFour_top_lef2_bot(hr1_top_btn,hr1_left2_btn ,hr1_bot_btn );

            forFive_right1_lef2(hr1_right1_btn, hr1_left2_btn);


        }

        private void hr1_top_btn_MouseEnter(object sender, EventArgs e)
        {
            if (hr1_top_btn.Visible == true)
            {
                hr1_top_btn.BackColor = Color.Red;
            }
        }

        private void hr1_top_btn_MouseLeave(object sender, EventArgs e)
        {
            if (hr1_top_btn.Visible == true)
            {
                hr1_top_btn.BackColor = Color.Maroon;
            }
        }

        private void hr1_left1_btn_MouseEnter(object sender, EventArgs e)
        {
            if (hr1_left1_btn.Visible == true)
            {
               hr1_left1_btn.BackColor = Color.Red;
            }
        }

        private void hr1_left1_btn_MouseLeave(object sender, EventArgs e)
        {
            if (hr1_left1_btn.Visible == true)
            {
               hr1_left1_btn.BackColor = Color.Maroon;
            }
        }
        
      
        private void hr1_left2_btn_MouseEnter(object sender, EventArgs e)
        {
            ChangeEnter(hr1_left2_btn);
           
        }

        private void hr1_mid_btn_MouseEnter(object sender, EventArgs e)
        {
            ChangeEnter(hr1_mid_btn);
        }

        private void hr1_mid_btn_MouseLeave(object sender, EventArgs e)
        {
            ChangeLeave(hr1_mid_btn);
        }

        private void hr1_right1_btn_MouseEnter(object sender, EventArgs e)
        {
            ChangeEnter(hr1_right1_btn);
        }

        private void hr1_right1_btn_MouseLeave(object sender, EventArgs e)
        {
            ChangeLeave(hr1_right1_btn);
        }

        private void hr1_right2_btn_MouseEnter(object sender, EventArgs e)
        {
            ChangeEnter(hr1_right2_btn);
        }

        private void hr1_right2_btn_MouseLeave(object sender, EventArgs e)
        {
            ChangeLeave(hr1_right2_btn);
        }

        private void hr1_bot_btn_MouseEnter(object sender, EventArgs e)
        {
            ChangeEnter(hr1_bot_btn);
        }

        private void hr1_bot_btn_MouseLeave(object sender, EventArgs e)
        {
            ChangeLeave(hr1_bot_btn);
        }

        private void hr1_left2_btn_MouseLeave(object sender, EventArgs e)
        {
            ChangeLeave(hr1_left2_btn);
        }

        private void hr2_lef2_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
