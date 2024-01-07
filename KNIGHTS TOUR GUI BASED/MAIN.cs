using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KNIGHTS_TOUR_GUI_BASED
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }
        int counter = 0;
        int row = -1;
        int col = -1;
        Warnsdoff w = new Warnsdoff();
        backtracking b=new backtracking();

        public void getinput (int row, int col){
            textBox1.Text = row.ToString();
            textBox2.Text = col.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            row = 1;
            col = 1;
            getinput(row, col);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            row = 1;
            col = 2;
            getinput(row, col);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            row = 1;
            col = 3;
            getinput(row, col);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            row = 1;
            col = 4;
            getinput(row, col);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            row = 1;
            col = 5;
            getinput(row, col);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            row = 1;
            col = 6;
            getinput(row, col);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            row = 1;
            col = 7;
            getinput(row, col);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            row = 1;
            col = 8;
            getinput(row, col);
        }

        //_____________________________________________________________________________________________
        //+++++++++++++++++++++++++ ROW 2
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void button9_Click(object sender, EventArgs e)
        {
            row = 2;
            col = 1;
            getinput(row, col);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            row = 2;
            col = 2;
            getinput(row, col);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            row = 2;
            col = 3;
            getinput(row, col);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            row = 2;
            col = 4;
            getinput(row, col);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            row = 2;
            col = 5;
            getinput(row, col);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            row = 2;
            col = 6;
            getinput(row, col);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            row = 2;
            col = 7;
            getinput(row, col);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            row = 2;
            col = 8;
            getinput(row, col);
        }

        //_____________________________________________________________________________________________
        //+++++++++++++++++++++++++ ROW 3
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void button17_Click(object sender, EventArgs e)
        {
            row = 3;
            col = 1;
            getinput(row, col);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            row = 3;
            col = 2;
            getinput(row, col);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            row = 3;
            col = 3;
            getinput(row, col);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            row = 3;
            col = 4;
            getinput(row, col);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            row = 3;
            col = 5;
            getinput(row, col);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            row = 3;
            col = 6;
            getinput(row, col);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            row = 3;
            col = 7;
            getinput(row, col);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            row = 3;
            col = 8;
            getinput(row, col);
        }


        //_____________________________________________________________________________________________
        //+++++++++++++++++++++++++ ROW 4
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void button25_Click(object sender, EventArgs e)
        {
            row = 4;
            col = 1;
            getinput(row, col);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            row = 4;
            col = 2;
            getinput(row, col);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            row = 4;
            col = 3;
            getinput(row, col);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            row = 4;
            col = 4;
            getinput(row, col);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            row = 4;
            col = 5;
            getinput(row, col);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            row = 4;
            col = 6;
            getinput(row, col);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            row = 4;
            col = 7;
            getinput(row, col);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            row = 4;
            col = 8;
            getinput(row, col);
        }


        //_____________________________________________________________________________________________
        //+++++++++++++++++++++++++ ROW 5
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void button33_Click(object sender, EventArgs e)
        {
            row = 5;
            col = 1;
            getinput(row, col);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            row = 5;
            col = 2;
            getinput(row, col);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            row = 5;
            col = 3;
            getinput(row, col);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            row = 5;
            col = 4;
            getinput(row, col);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            row = 5;
            col = 5;
            getinput(row, col);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            row = 5;
            col = 6;
            getinput(row, col);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            row = 5;
            col = 7;
            getinput(row, col);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            row = 5;
            col = 8;
            getinput(row, col);
        }

        //_____________________________________________________________________________________________
        //+++++++++++++++++++++++++ ROW 6
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void button41_Click(object sender, EventArgs e)
        {
            row = 6;
            col = 1;
            getinput(row, col);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            row = 6;
            col = 2;
            getinput(row, col);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            row = 6;
            col = 3;
            getinput(row, col);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            row = 6;
            col = 4;
            getinput(row, col);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            row = 6;
            col = 5;
            getinput(row, col);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            row = 6;
            col = 6;
            getinput(row, col);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            row = 6;
            col = 7;
            getinput(row, col);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            row = 6;
            col = 8;
            getinput(row, col);
        }

        //_____________________________________________________________________________________________
        //+++++++++++++++++++++++++ ROW 7
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void button49_Click(object sender, EventArgs e)
        {
            row = 7;
            col = 1;
            getinput(row, col);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            row = 7;
            col = 2;
            getinput(row, col);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            row = 7;
            col = 3;
            getinput(row, col);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            row = 7;
            col = 4;
            getinput(row, col);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            row = 7;
            col = 5;
            getinput(row, col);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            row = 7;
            col = 6;
            getinput(row, col);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            row = 7;
            col = 7;
            getinput(row, col);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            row = 7;
            col = 8;
            getinput(row, col);
        }

        //_____________________________________________________________________________________________
        //+++++++++++++++++++++++++ ROW 8
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    
        private void button57_Click(object sender, EventArgs e)
        {
            row = 8;
            col = 1;
            getinput(row, col);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            row = 8;
            col = 2;
            getinput(row, col);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            row = 8;
            col = 3;
            getinput(row, col);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            row = 8;
            col = 4;
            getinput(row, col);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            row = 8;
            col = 5;
            getinput(row, col);
        }


        private void button62_Click(object sender, EventArgs e)
        {
            row = 8;
            col = 6;
            getinput(row, col);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            row = 8;
            col = 7;
            getinput(row, col);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            row = 8;
            col = 8;
            getinput(row, col);
        }
        //_____________________________________________________________________________________________
        //+++++++++++++++++++++++++ START BUTTON
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void button66_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                 row = int.Parse(textBox1.Text);
                 col = int.Parse(textBox2.Text); 
                if(row > 0 && col > 0 && row <= 8 && col <= 8)
                {
                    if (radioButton1.Checked == true)
                    {
                        w.reset();
                        w.move(row-1,col-1);
                        repaint(w.chess_Board);
                    }
                    else if (radioButton2.Checked==true) {
                        b.reset();
                        b.SolveTour(row-1,col-1);
                        repaint(b.board);
                    }
                }
                else
                {
                    string message = "PLEASE ENTER VALID ROW OR COLUMN\nPROGRAM CANT BE STARTED\nRESETTING THE POSITION OF THE KNIGHT ";
                    MessageBox.Show(message);
                }
            }
            else
            {
                string mess = "PLEASE SELECT ANY ONE ALGORITHM FOR KNIGHTS TOUR";
                MessageBox.Show(mess);  
            }
        }

        public void repaint(int[,] array)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    string buttonName = "button" + ((i * 8) + j + 1).ToString();
                    Button currentButton = Controls.Find(buttonName, true).FirstOrDefault() as Button;

                    if (currentButton != null)
                    {
                        currentButton.Text = array[i, j].ToString();
                        currentButton.Font = new Font("Arial", 20, FontStyle.Bold);
                        currentButton.ForeColor = Color.Red;
                    }
                }
            }

            // Move the reset calls outside of the loop
            w.reset();
            b.reset();
        }

        public void reset()
        {
            MessageBox.Show("Resetting...");
            for (int i = 0; i < 8; i++)
            {
                

                for (int j = 0; j < 8; j++)

                {
                    string buttonName = "button" + ((i * 8) + j + 1).ToString();
                    Button currentButton = Controls.Find(buttonName, true).FirstOrDefault() as Button;

                    if (currentButton != null)
                    {
                        currentButton.Text =null;

                        currentButton.Font = new Font("Arial", 20, FontStyle.Bold);
                        currentButton.ForeColor = Color.Red;
                    }
                }
            }
        }

  //      public async void repaint(int[,] array)
    //    {
      //      for (int i = 0; i < 8; i++)
        //    {
          //      for (int j = 0; j < 8; j++)
            //    {
           //         string buttonName = "button" + ((i * 8) + j + 1).ToString();
          //          Button currentButton = Controls.Find(buttonName, true).FirstOrDefault() as Button;
        //
            //        if (currentButton != null)
              //      {
          //              currentButton.Text = array[i, j].ToString();
            //            currentButton.Font = new Font("Arial", 20, FontStyle.Bold);
              //          currentButton.ForeColor = Color.Red;

                //        await Task.Delay(300); // Adjust the delay duration in milliseconds
 //                  }
  //             }
  //          }

    //        w.reset();
      //      b.reset();
//        }

        private void button65_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
