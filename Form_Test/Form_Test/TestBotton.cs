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
        /// <summary>onの時の色</summary>
        private Color _onColor = Color.HotPink;
        
        /// <summary>offの時の色</summary>
        private Color _offColor = Color.White;

        /// <summary>現在OnかOffか</summary>
        private bool _enable;


        /// <summary>onとoffの設定</summary>
        /// <param name="on"></param>
        public void Dolphin(bool on)
        {
            _enable = on;
            if (on)
            {
                BackColor = _onColor;
            }
            else
            {
                BackColor = _offColor;
            }
        }
        
        public TestBotton(Point position, Size size, string text)
        {
            //ボタンの位置を設定
            Location = position;
            //ボタンの大きさを設定
            Size = size;
            //ボタン内のテキストを設定
            Text = text;

            Dolphin(false);

            Click += kirakiraClick;
        }

        //自分で作成することも可能
        private void kirakiraClick(object sender, EventArgs e)
        {
            Dolphin(!_enable);
    　　}
    } 
}
