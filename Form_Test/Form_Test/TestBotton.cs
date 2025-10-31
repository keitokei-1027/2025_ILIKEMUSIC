using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    //Bottonクラスを継承したTestButton
    internal class TestBotton : Button
    {
        public TestBotton(Point position, Size size, string text)
        {
            //ボタンの位置を設定
            Location = position;
            //ボタンの大きさを設定
            Size = size;
            //ボタン内のテキストを設定
            Text = text;

            Click += kirakiraClick;
        }

        //自分で作成することも可能
        private void kirakiraClick(object sender, EventArgs e)
        {
            MessageBox.Show("おめでとうございます。貴方は15億円に当選しました。");
    　　}

    

    } 
}
