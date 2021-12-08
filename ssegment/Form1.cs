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


        private void grpALLTRU(GroupBox sen)
        {
            foreach (Control xx in sen.Controls)
            {
                if (xx is Button)
                {
                    xx.Visible = true;
                }
            }
        }




        private void forOne_Top_Left1_Left2_MID_BOT(Button sender, Button sender1, Button sender2, Button sender3, Button sender4)
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


        private void forTwo_Lef1_rig2(Button sen1, Button sen2)
        {
            sen1.Visible = false;
            sen2.Visible = false;
        }

        private void forThree_lef1_lef2(Button sen1, Button sen2)
        {
            vis(sen1);
            vis(sen2);
        }

        private void forFour_top_lef2_bot(Button sen1, Button sen2, Button sen3)
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

        private void forSix_right1(Button sen1)
        {
            vis(sen1);
        }
        private void forSeven_lef11_lef2_mid_bot(Button sen1, Button sen2, Button sen3, Button sen4)
        {
            vis(sen1);
            vis(sen2);
            vis(sen3);
            vis(sen4);
        }

        private void forNine_lef2_bot(Button sen1, Button sen2)
        {
            vis(sen1);
            vis(sen2);
        }

        private void forZero_mid(Button sen1)
        {
            vis(sen1);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // forOne_Top_Left1_Left2_MID_BOT(hr1_top_btn,hr1_left1_btn,hr1_left2_btn,hr1_mid_btn,hr1_bot_btn);
            // forTwo_Lef1_rig2(hr2_lef1_btn,hr2_rig2_btn);

            //forThree_lef1_lef2(hr1_left1_btn, hr1_left2_btn);

            // forFour_top_lef2_bot(hr1_top_btn,hr1_left2_btn ,hr1_bot_btn );

            // forFive_right1_lef2(hr1_right1_btn, hr1_left2_btn);


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
        int cnt = 0;
        string mysec;
        int scs = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            cnt += 1;
            ss2();
            ss1();
        }
        private void ss2()
        {
            mysec = DateTime.Now.ToString("ss");
            scs = Convert.ToInt32(mysec.Substring(mysec.Length - 1));
            if (scs == 0)
            {
                grpALLTRU(groupBox5);
                forZero_mid(ss2mid);
            }
            else if (scs == 1)
            {
                grpALLTRU(groupBox5);
                forOne_Top_Left1_Left2_MID_BOT(ss2top, ss2l1, ss2l2, ss2mid, ss2bot);
            }
            else if (scs == 2)
            {
                grpALLTRU(groupBox5);
                forTwo_Lef1_rig2(ss2l1, ss2r2);
            }
            else if (scs == 3)
            {
                grpALLTRU(groupBox5);
                forThree_lef1_lef2(ss2l1, ss2l2);
            }
            else if (scs == 4)
            {
                grpALLTRU(groupBox5);
                forFour_top_lef2_bot(ss2top, ss2l2, ss2bot);
            }
            else if (scs == 5)
            {
                grpALLTRU(groupBox5);
                forFive_right1_lef2(ss2r1, ss2l2);
            }
            else if (scs == 6)
            {
                grpALLTRU(groupBox5);
                forSix_right1(ss2r1);
            }
            else if (scs == 7)
            {
                grpALLTRU(groupBox5);
                forSeven_lef11_lef2_mid_bot(ss2l1, ss2l2, ss2mid, ss2bot);
            }
            else if (scs == 8)
            {
                grpALLTRU(groupBox5);
            }
            else if (scs == 9)
            {
                grpALLTRU(groupBox5);
                forNine_lef2_bot(ss2l2, ss2bot);
            }
        }
        /*
          if (scs == 0)
            {
               
            }
            else if (scs == 1)
            {
               
            }
            else if (scs == 2)
            {
               
            }
            else if (scs == 3)
            {
               
            }
            else if (scs == 4)
            {
                
            }
            else if (scs == 5)
            {
               
            }
            else if (scs == 6)
            {
                
            }
            else if (scs == 7)
            {
                
            }
            else if (scs == 8)
            {
                grpALLTRU(groupBox);
            }
            else if (scs == 9)
            {
               
            }
         
         */

        private void ss1()
        {
            mysec = DateTime.Now.ToString("ss");
            scs= Convert.ToInt32(mysec.Substring(0, 1));
            if (scs == 0)
            {
                grpALLTRU(groupBox6);
                forZero_mid(ss1mid);
            }
            else if (scs == 1)
            {
                grpALLTRU(groupBox6);
                forOne_Top_Left1_Left2_MID_BOT(ss1top, ss1l1, ss1l2, ss1mid, ss1bot);
            }
            else if (scs == 2)
            {
                grpALLTRU(groupBox6);
                forTwo_Lef1_rig2(ss1l1, ss1r2);
            }
            else if (scs == 3)
            {
                grpALLTRU(groupBox6);
                forThree_lef1_lef2(ss1l1, ss1l2);
            }
            else if (scs == 4)
            {
                grpALLTRU(groupBox6);
                forFour_top_lef2_bot(ss1top, ss1l2, ss1bot);
            }
            else if (scs == 5)
            {
                grpALLTRU(groupBox6);
                forFive_right1_lef2(ss1r1, ss1l2);
            }
            else if (scs == 6)
            {
                grpALLTRU(groupBox6);
                forSix_right1(ss1r1);
            }
            else if (scs == 7)
            {
                grpALLTRU(groupBox6);
                forSeven_lef11_lef2_mid_bot(ss1l1, ss1l2, ss1mid, ss1bot);
            }
            else if (scs == 8)
            {
                grpALLTRU(groupBox6);
            }
            else if (scs == 9)
            {
                grpALLTRU(groupBox6);
                forNine_lef2_bot(ss1l2, ss1bot);
            }
        } 
        }
}
