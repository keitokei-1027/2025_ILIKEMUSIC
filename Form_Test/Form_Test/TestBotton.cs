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
    public class TestBotton : Button
    {
        /// <summary>onの時の色</summary>
        private Color _onColor = Color.Blue;
        
        /// <summary>offの時の色</summary>
        private Color _offColor = Color.White;

        /// <summary>現在OnかOffか</summary>
        private bool _enable;

        /// <summary>Form1の参照</summary>
        private Form1 _form1;

        /// <summary>横位置</summary>
        private int _x;

        /// <summary>縦位置</summary>
        private int _y;
        
        public TestBotton(Form1 form1,　int x , int y, Point position, Size size, string text)
        {
            //Form1の参照を保管
            _form1 = form1;
            
            //横位置を保管
            _x = x;
            
            //縦位置を保管
            _y = y;

            //ボタンの位置を設定
            Location = position;

            //ボタンの大きさを設定
            Size = size;

            //ボタン内のテキストを設定
            Text = text;

            SetEnable(false);

            Click += kirakiraClick;
        }

        /// <summary>onとoffの設定</summary>
        /// <param name="on"></param>
        public void SetEnable(bool on)
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

        //自分で作成することも可能
        /// <summary>
        /// 各ボタンがクリックされたときに呼び出される関数
        /// クリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kirakiraClick(object sender, EventArgs e)
        {
            _form1.GetTestButton(_x, _y).SetEnable(true);
    　　}
    } 
}
