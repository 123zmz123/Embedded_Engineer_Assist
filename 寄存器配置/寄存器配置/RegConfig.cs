using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace 寄存器配置
{
    class RegConfig
    {
        StreamReader Reg_Conf = new StreamReader("RegConfig.csv");

        public struct Each_Reg
        {
            public string Reg_Name;
            public string Bit7_Des;
            public string Bit6_Des;
            public string Bit5_Des;
            public string Bit4_Des;
            public string Bit3_Des;
            public string Bit2_Des;
            public string Bit1_Des;
            public string Bit0_Des;
        }

        //public Each_Reg[] reg_list = new Each_Reg[];

        public Each_Reg[] Reg_datas = new Each_Reg[1000];

        public string ReadLine()
        {
          return  Reg_Conf.ReadLine();
        }

        public int ReadAll() //  read all the lines in .csv format file.
        {
            string line;
            int count = 0;
            Each_Reg r_temp;
        
            while ((line = Reg_Conf.ReadLine()) != null)
            {
                r_temp = Analyze_data(line);

                Reg_datas[count] = r_temp;

                count++;
            }

            Reg_Conf.Close();

            return count;
        }

        private Each_Reg Analyze_data(string s)
        {
            
            char separateword = ',';
            string[] temp =s.Split(separateword);

            Each_Reg d;

            d.Reg_Name = temp[0];
            d.Bit7_Des = temp[1];
            d.Bit6_Des = temp[2];
            d.Bit5_Des = temp[3];
            d.Bit4_Des = temp[4];
            d.Bit3_Des = temp[5];
            d.Bit2_Des = temp[6];
            d.Bit1_Des = temp[7];
            d.Bit0_Des = temp[8];

            return d;


        }

    }
}
