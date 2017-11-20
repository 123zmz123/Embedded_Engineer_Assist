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

        Each_Reg[] reg_list = new Each_Reg[1000];

        ArrayList original_data = new ArrayList();

        public string ReadLine()
        {
          return  Reg_Conf.ReadLine();
        }

        private void ReadAll()
        {
            string line;
            while ((line = Reg_Conf.ReadLine()) != null)
            {
                original_data.Add(line);
            }
        }

        private void Analyze_data(string s)
        {
            
            char[] separateword = { ',' };
            string[] temp =s.Split(separateword);

            Each_Reg d;

            d.Reg_Name = temp[0];

            

        }

    }
}
