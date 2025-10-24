using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    //インスタンスの生成
                    TestBotton testBotton = new TestBotton();

                    //ボタンの位置を設定
                    testBotton.Location = new Point(50 * i, 50 * j);

                    //ボタンの大きさを設定
                    testBotton.Size = new Size(50, 50);

                    //ボタン内のテキストを設定
                    testBotton.Text = "絶対に押すな";

                    //コントロールにボタンを追加
                    Controls.Add(testBotton);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ようこそ！C#の世界へ！");
        }
    }
}
