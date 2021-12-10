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
            sen1.BackColor = Color.Black;
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
                    xx.BackColor = Color.BlueViolet;
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
            label1.Text = DateTime.Now.ToString();
            this.BackColor = Color.Black;
            foreach (Control xx in groupBox5.Controls)
            {
                if (xx is Button)
                {
                    xx.BackColor = Color.Green;
                }
            }
            foreach (Control xx in groupBox6.Controls)
            {
                if (xx is Button)
                {
                    xx.BackColor = Color.Green;
                }
            }
            foreach (Control xx in groupBox4.Controls)
            {
                if (xx is Button)
                {
                    xx.BackColor = Color.Blue;
                }
            }
            foreach (Control xx in groupBox3.Controls)
            {
                if (xx is Button)
                {
                    xx.BackColor = Color.Blue;
                }
            }
        }

        private  void btnMouseEnter(Form1 x, EventArgs e)
        {
            foreach (Control xx in x.Controls)
            {
                if(xx is Button)
                {
                    xx.BackColor = Color.Orange;
                }
            }
        }

        private void hr1_top_btn_MouseLeave(object sender, EventArgs e)
        {
            ChangeLeave(hr1_top_btn);
        }

        private void hr1_left1_btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Cyan; ;
        }

        private void hr1_left1_btn_MouseLeave(object sender, EventArgs e)
        {
            ChangeLeave(hr1_left1_btn);
        }

        private void allbtns(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.BlueViolet)
            {
                btn.BackColor = Color.Cyan;
            }
            
           
        }
        private void allbtnsLEAVE(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Cyan)
            {
                btn.BackColor = Color.Black;
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
        int cnt = 0;  //counter
        string mysec; //date reader
        int scs = 0;  //stores the value of time(hh,mm,ss)
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            cnt += 1; //increments for time
            ss2(); //calls the function for second column for seconds
            ss1(); //calls the function for first column for seconds
            mm1(); //calls the function for first column for mins
            mm2(); //calls the function for second column for minns
            hh1(); //calls the function for first column for hours
            hh2(); //calls the function for second column for houurs
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
            scs = Convert.ToInt32(mysec.Substring(0,1));
            if (scs == 0)
            {
                grpALLTRU(groupBox4);
                forZero_mid(mm1mid);
            }
            else if (scs == 1)
            {
                grpALLTRU(groupBox4);
                forOne_Top_Left1_Left2_MID_BOT(mm1top, mm1l1, mm1l2, mm1mid, mm1bot);
               
            }
            else if (scs == 2)
            {
                grpALLTRU(groupBox4);
                forTwo_Lef1_rig2(mm1l1, mm1r2);
            }
            else if (scs == 3)
            {
                grpALLTRU(groupBox4);
                forThree_lef1_lef2(mm1l1, mm1l2);
            }
            else if (scs == 4)
            {
                grpALLTRU(groupBox4);
                forFour_top_lef2_bot(mm1top ,mm1l2,mm1bot);
            }
            else if (scs == 5)
            {
                grpALLTRU(groupBox4);
                forFive_right1_lef2(mm1r1, mm1l2);
            }
            else if (scs == 6)
            {
                grpALLTRU(groupBox4);
                forSix_right1(mm1r1);
            }
            else if (scs == 7)
            {
                grpALLTRU(groupBox4);
                forSeven_lef11_lef2_mid_bot(mm1l1,mm1l2,mm1mid,mm1bot);
            }
            else if (scs == 8)
            {

                grpALLTRU(groupBox4);
            }
            else if (scs == 9)
            {
                grpALLTRU(groupBox4);
                forNine_lef2_bot(mm1l2,mm1bot);
            }
        }
        
        private void mm2() //function for second column for mins
        {
            mysec = DateTime.Now.ToString("mm");
            scs = Convert.ToInt32(mysec.Substring(mysec.Length-1));

            if (scs == 0)
            {
                grpALLTRU(groupBox3);
                forZero_mid(mm2mid);
            }
            else if (scs == 1)
            {
                grpALLTRU(groupBox3);
                forOne_Top_Left1_Left2_MID_BOT(mm2top, mm2l1, mm2l2, mm2mid, mm2bot);

            }
            else if (scs == 2)
            {
                grpALLTRU(groupBox3);
                forTwo_Lef1_rig2(mm2l1, mm2r2);
            }
            else if (scs == 3)
            {
                grpALLTRU(groupBox3);
                forThree_lef1_lef2(mm2l1, mm2l2);
            }
            else if (scs == 4)
            {
                grpALLTRU(groupBox3);
                forFour_top_lef2_bot(mm2top, mm2l2, mm2bot);
            }
            else if (scs == 5)
            {
                grpALLTRU(groupBox3);
                forFive_right1_lef2(mm2r1, mm2l2);
            }
            else if (scs == 6)
            {
                grpALLTRU(groupBox3);
                forSix_right1(mm2r1);
            }
            else if (scs == 7)
            {
                grpALLTRU(groupBox3);
                forSeven_lef11_lef2_mid_bot(mm2l1, mm2l2, mm2mid, mm2bot);
            }
            else if (scs == 8)
            {
                grpALLTRU(groupBox3);
                grpALLTRU(groupBox3);
            }
            else if (scs == 9)
            {
                grpALLTRU(groupBox3);
                forNine_lef2_bot(mm2l2, mm2bot);
            }
        }

        private void hh1() //function for first column for hours
        {
            mysec = DateTime.Now.ToString("hh");
            scs = Convert.ToInt32(mysec.Substring(0,1));

            if (scs == 0)
            {
                grpALLTRU(groupBox1);
                forZero_mid(hr1_mid_btn);
            }
            else if (scs == 1)
            {
                grpALLTRU(groupBox1);
                forOne_Top_Left1_Left2_MID_BOT(hr1_top_btn,hr1_left1_btn,hr1_left2_btn,hr1_mid_btn,hr1_bot_btn);
            }
            else if (scs == 2)
            {
                grpALLTRU(groupBox1);
                forTwo_Lef1_rig2(hr1_left1_btn,hr1_right2_btn);
            }
            else if (scs == 3)
            {
                grpALLTRU(groupBox1);
                forThree_lef1_lef2(hr1_left1_btn,hr1_left2_btn);
            }
            else if (scs == 4)
            {
                grpALLTRU(groupBox1);
                forFour_top_lef2_bot(hr1_top_btn,hr1_left2_btn,hr1_bot_btn);
            }
            else if (scs == 5)
            {
                grpALLTRU(groupBox1);
                forFive_right1_lef2(hr1_right1_btn,hr1_left2_btn);
            }
            else if (scs == 6)
            {
                grpALLTRU(groupBox2);
                forSix_right1(hr1_right1_btn);
            }
            else if (scs == 7)
            {
                grpALLTRU(groupBox1);
                forSeven_lef11_lef2_mid_bot(hr1_left1_btn,hr1_left2_btn,hr1_mid_btn,hr1_bot_btn);
            }
            else if (scs == 8)
            {
                grpALLTRU(groupBox1);
                
            }
            else if (scs == 9)
            {
                grpALLTRU(groupBox1);
                forNine_lef2_bot(hr1_left2_btn,hr1_bot_btn);
            }
        }
        private void hh2() //function for second column for hours
        {
            mysec = DateTime.Now.ToString("hh");
            scs = Convert.ToInt32(mysec.Substring(mysec.Length-1));

            if (scs == 0)
            {
                grpALLTRU(groupBox2);
                forZero_mid(hr2_mid_btn);
            }
            else if (scs == 1)
            {
                grpALLTRU(groupBox2);
                forOne_Top_Left1_Left2_MID_BOT(hr2_top_btn,hr2_lef1_btn,hr2_lef2_btn,hr2_mid_btn,hr2_bot_btn);
            }
            else if (scs == 2)
            {
                grpALLTRU(groupBox2);
                forTwo_Lef1_rig2(hr2_lef1_btn,hr2_rig2_btn);
            }
            else if (scs == 3)
            {
                grpALLTRU(groupBox2);
                forThree_lef1_lef2(hr2_lef1_btn,hr2_lef2_btn);
            }
            else if (scs == 4)
            {
                grpALLTRU(groupBox2);
                forFour_top_lef2_bot(hr2_top_btn,hr2_lef2_btn,hr2_bot_btn);
            }
            else if (scs == 5)
            {
                grpALLTRU(groupBox2);
                forFive_right1_lef2(hr2_rig1_btn,hr2_lef2_btn);
            }
            else if (scs == 6)
            {
                grpALLTRU(groupBox2);
                forSix_right1(hr2_rig1_btn);
            }
            else if (scs == 7)
            {
                grpALLTRU(groupBox2);
                forSeven_lef11_lef2_mid_bot(hr2_lef1_btn,hr2_lef2_btn,hr2_mid_btn,hr2_bot_btn);
            }
            else if (scs == 8)
            {
                grpALLTRU(groupBox2);

            }
            else if (scs == 9)
            {
                grpALLTRU(groupBox2);
                forNine_lef2_bot(hr2_lef2_btn,hr2_bot_btn);
            }
        }

        private void hr2_rig1_btn_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void hr2_top_btn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void hr2_lef1_btn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void hr2_lef2_btn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void hr2_bot_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
