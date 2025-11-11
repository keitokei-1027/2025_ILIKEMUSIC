using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public partial class Form1 : Form
    {
        // ctrl + Rキー2回をやると、効率よく名前をまとめて変更できる。

        // constをつけると初期化時のみ値の変更が可能になる。
        
        /// <summary>
        /// ボタンの横幅
        /// </summary>
        const int BUTTON_SIZE_X = 100;

        /// <summary>
        /// ボタンの縦幅
        /// </summary>
        const int BUTTON_SIZE_Y = 100;

        /// <summary>
        /// ボタンが横に何個並ぶか
        /// </summary>
        const int BOARD_SIZE_X = 3;

        /// <summary>
        /// ボタンが縦に何個並ぶか
        /// </summary>
        const int BOARD_SIZE_Y = 3;

        private TestBotton[,] _ButtonArray;
        private Random rand = new Random();



        public Form1()
        {
            InitializeComponent();
            
            _ButtonArray = new TestBotton[BOARD_SIZE_X, BOARD_SIZE_Y];

            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {
                    // インスタンスの生成
                    TestBotton testBotton =
                        new TestBotton(
                            this,
                            i, j,
                            new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y),
                            "");

                    // 配列にボタンの参照を追加
                    _ButtonArray[j, i] = testBotton;

                    // コントロールにボタンを追加
                    Controls.Add(testBotton);
                }
            }

            this.ClientSize = new Size(BUTTON_SIZE_X * BOARD_SIZE_X, BUTTON_SIZE_Y * BOARD_SIZE_Y);
            RandomizeBoard();
        }
        public TestBotton GetTestButton(int x, int y)
        {
            //配列外参照対策
            if (x < 0 || x >= BOARD_SIZE_X) return null;
            if (y < 0 || y >= BOARD_SIZE_Y) return null;

            return _ButtonArray[y, x];
        }

        //ボード全体をランダムな状態に初期化する
        public void RandomizeBoard()
        {
            for (int x = 0; x <  BOARD_SIZE_X; x++)
            {
                for(int y = 0; y < BOARD_SIZE_Y; y++)
                {
                    bool state = rand.Next(2) == 0;
                    GetTestButton(x, y)?.SetEnable(state);
                }
            }
        }

        // 盤面の状態をチェックして、全てのボタンが同じ状態(ONまたはOFF)ならクリアと判定する。
        // クリアしたらメッセージを表示、盤面をランダムに再生成する。
        public void CheckClearAndRestart()
        {
            bool first = _ButtonArray[0, 0].IsOn;
            // 全てのボタンをループで確認し、1つでも基準と異なる状態があれば、クリアしていないと判断して処理を終了する。
            foreach (var btn in _ButtonArray)
            {
                if (btn.IsOn != first)
                    return;
            }
            // 全てのボタンが同じだった場合、クリアメッセージを表示する。
            MessageBox.Show("クリア！おめでとう！", "Lights Out", MessageBoxButtons.OK);
            // 盤面をランダムに再生成して、次のゲームを開始する。
            RandomizeBoard();
        }
    }
}
