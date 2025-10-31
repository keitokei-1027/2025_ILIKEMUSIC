using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //インスタンスの生成
                    TestBotton testBotton = new TestBotton(new Point(50 * i, 50 * j), new Size(50, 50), "当選ボタン");
                    
                    //コントロールにボタンを追加
                    Controls.Add(testBotton);
                }
            }
        }


        
        //自動生成
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ようこそ！C#の世界へ！");
        }
    }
}
