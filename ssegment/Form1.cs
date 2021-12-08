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
        private void ChangeEnter(Button sender) //function to change back color of a called button
        {
            if (sender.Visible)
            {
                sender.BackColor = Color.Red;
            }
        }
        private void vis(Button sen1) //function to disable visibility of a called button 
        {
            sen1.Visible = false;
        }
        private void ChangeLeave(Button sender) //function to change the  backcolor of called button
        {
            if (sender.Visible)
            {
                sender.BackColor = Color.Maroon;
            }
        }
        private void grpALLTRU(GroupBox sen) //function to enable visibility of all btns in a called groupbox
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
            //function to form # 1 in segments
            vis(sender);
            vis(sender1);
            vis(sender2);
            vis(sender3);
            vis(sender4);
        }
        private void forTwo_Lef1_rig2(Button sen1, Button sen2)
        {

            //function to form # 2 in segments
            vis(sen1);
            vis(sen2);
        }
        private void forThree_lef1_lef2(Button sen1, Button sen2)
        {
            //function to form # 3 in segments
            vis(sen1);
            vis(sen2);
        }

        private void forFour_top_lef2_bot(Button sen1, Button sen2, Button sen3)
        {
            //function to form # 4 in segments
            vis(sen1);
            vis(sen2);
            vis(sen3);
        }

        private void forFive_right1_lef2(Button sen1, Button sen2)
        {
            //function to form # 5 in segments
            vis(sen1);
            vis(sen2);
        }

        private void forSix_right1(Button sen1)
        {
            //function to form # 6 in segments
            vis(sen1);
        }
        private void forSeven_lef11_lef2_mid_bot(Button sen1, Button sen2, Button sen3, Button sen4)
        {
            //function to form # 7 in segments
            vis(sen1);
            vis(sen2);
            vis(sen3);
            vis(sen4);
        }

        private void forNine_lef2_bot(Button sen1, Button sen2)
        {
            //function to form #9 in segments
            vis(sen1);
            vis(sen2);
        }

        private void forZero_mid(Button sen1)
        {
            //function to form # 0 in segments
            vis(sen1);
        }
        // if you are wondering why theres  no function for 8, theres no buttons in segments needed to disable visibility
        private void Form1_Load(object sender, EventArgs e)
        {
         //codes to run when program starts
        }

        private void hr1_top_btn_MouseEnter(object sender, EventArgs e)
        {
            ChangeEnter(hr1_top_btn);
        }

        private void hr1_top_btn_MouseLeave(object sender, EventArgs e)
        {
            ChangeLeave(hr1_top_btn);
        }

        private void hr1_left1_btn_MouseEnter(object sender, EventArgs e)
        {
            ChangeEnter(hr1_left1_btn);
        }

        private void hr1_left1_btn_MouseLeave(object sender, EventArgs e)
        {
            ChangeLeave(hr1_left1_btn);
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
        int cnt = 0;  //counter
        string mysec; //date reader
        int scs = 0;  //stores the value of time(hh,mm,ss)
        private void timer1_Tick(object sender, EventArgs e)
        {
            cnt += 1; //increment
            ss2(); //calls the function for second column for seconds
            ss1(); //calls the function for first column for seconds
        }
        private void ss2() //function for second column for seconds
        {
            mysec = DateTime.Now.ToString("ss"); //stores the seconds in mysec variable
            scs = Convert.ToInt32(mysec.Substring(mysec.Length - 1)); //gets the last char of string
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
        private void ss1() //function for first column for seconds
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
        private void mm1() //function for firstt column for minss
        {
            mysec = DateTime.Now.ToString("mm");
            scs = Convert.ToInt32(mysec.Substring(mysec.Length-1));
        }
        
        private void mm2() //function for second column for mins
        {
            mysec = DateTime.Now.ToString("mm");
            scs = Convert.ToInt32(mysec.Substring(0, 1));
        }

        private void hh1() //function for first column for hours
        {
            mysec = DateTime.Now.ToString("hh");
            scs = Convert.ToInt32(mysec.Substring(mysec.Length-1));
        }
        private void hh2() //function for second column for hours
        {
            mysec = DateTime.Now.ToString("hh");
            scs = Convert.ToInt32(mysec.Substring(0, 1));
        }
    
    
    }
}
