using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 寄存器配置
{
    
    public partial class Form1 : Form
    {
        RegConfig reg_conf = new RegConfig();

        Byte[] Register_Value = new Byte[8] { 0,0,0,0,0,0,0,0} ;
        

        UInt64 Bit0_Tick, Bit1_Tick, Bit2_Tick, Bit3_Tick, Bit4_Tick, Bit5_Tick, Bit6_Tick, Bit7_Tick;

        private void Reg1_Buuton_Click(object sender, EventArgs e)
        {
            if (Register_Value[1] == 0)
            {
                Register_Value[1] = 1;
            }
            else if (Register_Value[1] == 1)
            {
                Register_Value[1] = 0;
            }

            Reg1_Buuton.Text = Register_Value[1].ToString();
        }

        private void Reg0_Button_Click(object sender, EventArgs e)
        {
            if (Register_Value[0] == 0)
            {
                Register_Value[0] = 1;
            }
            else if (Register_Value[0] == 1)
            {
                Register_Value[0] = 0;
            }

            Reg0_Button.Text = Register_Value[0].ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Int32 result = Register_Value[7] * 128 + Register_Value[6] * 64 + Register_Value[5] * 32 + Register_Value[4] * 16 +

                  Register_Value[3] * 8 + Register_Value[2] * 4 + Register_Value[1] * 2 + Register_Value[0];

            string t = result.ToString("X2");

            Result_Value_TextBox.Text = "0x" + t;

        }

        private void Reg_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Reg_ListBox.SelectedIndex;

            Bit7_TextBox.Text = reg_conf.Reg_datas[index].Bit7_Des;
            Bit6_TextBox.Text = reg_conf.Reg_datas[index].Bit6_Des;
            Bit5_TextBox.Text = reg_conf.Reg_datas[index].Bit5_Des;
            Bit4_TextBox.Text = reg_conf.Reg_datas[index].Bit4_Des;
            Bit3_TextBox.Text = reg_conf.Reg_datas[index].Bit3_Des;
            Bit2_TextBox.Text = reg_conf.Reg_datas[index].Bit2_Des;
            Bit1_TextBox.Text = reg_conf.Reg_datas[index].Bit1_Des;
            Bit0_TextBox.Text = reg_conf.Reg_datas[index].Bit0_Des;
        }

        private void Reg2_Button_Click(object sender, EventArgs e)
        {
            if (Register_Value[2] == 0)
            {
                Register_Value[2] = 1;
            }
            else if (Register_Value[2] == 1)
            {
                Register_Value[2] = 0;
            }

            Reg2_Button.Text = Register_Value[2].ToString();
        }

        private void Reg3_Button_Click(object sender, EventArgs e)
        {
            if (Register_Value[3] == 0)
            {
                Register_Value[3] = 1;
            }
            else if (Register_Value[3] == 1)
            {
                Register_Value[3] = 0;
            }

            Reg3_Button.Text = Register_Value[3].ToString();
        }

        private void Reg4_Button_Click(object sender, EventArgs e)
        {
            if (Register_Value[4] == 0)
            {
                Register_Value[4] = 1;
            }
            else if (Register_Value[4] == 1)
            {
                Register_Value[4] = 0;
            }

            Reg4_Button.Text = Register_Value[4].ToString();
        }

        private void Reg5_Button_Click(object sender, EventArgs e)
        {
            if (Register_Value[5] == 0)
            {
                Register_Value[5] = 1;
            }
            else if (Register_Value[5] == 1)
            {
                Register_Value[5] = 0;
            }

            Reg5_Button.Text = Register_Value[5].ToString();
        }

        private void Reg6_Button_Click(object sender, EventArgs e)
        {
            if (Register_Value[6] == 0)
            {
                Register_Value[6] = 1;
            }
            else if (Register_Value[6] == 1)
            {
                Register_Value[6] = 0;
            }

            Reg6_Button.Text = Register_Value[6].ToString();
        }

        private void Reg7_Button_Click(object sender, EventArgs e)
        {
            if (Register_Value[7] == 0)
            {
                Register_Value[7] = 1;
            }
            else if (Register_Value[7] == 1)
            {
                Register_Value[7] = 0;
            }

            Reg7_Button.Text = Register_Value[7].ToString();
        }

        public Form1()
        {
            InitializeComponent();

            int count = reg_conf.ReadAll();

            for (int i = 0; i < count; i++)
            {
                Reg_ListBox.Items.Add(reg_conf.Reg_datas[i].Reg_Name);
            }

        }

  
    }
}
