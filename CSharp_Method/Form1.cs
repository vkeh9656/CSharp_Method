using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tBoxNum1.Text);
            int iNumB = int.Parse(tBoxNum2.Text);

            //int iResult = iNumA + iNumB;

            //tBoxResult.Text = iResult.ToString();

            tBoxResult.Text = Plus(iNumA, iNumB).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tBoxNum1.Text);
            int iNumB = int.Parse(tBoxNum2.Text);

            //int iResult = iNumA - iNumB;

            //tBoxResult.Text = iResult.ToString();

            tBoxResult.Text = Minus(iNumA, iNumB).ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tBoxNum1.Text);
            int iNumB = int.Parse(tBoxNum2.Text);

            //int iResult = iNumA * iNumB;

            //tBoxResult.Text = iResult.ToString();
            tBoxResult.Text = Multi(iNumA, iNumB).ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tBoxNum1.Text);
            int iNumB = int.Parse(tBoxNum2.Text);

            //int iResult = iNumA / iNumB; // 몫
            ////int iResult2 = iNumA % iNumB;  // 나머지
            //tBoxResult.Text = iResult.ToString();

            tBoxResult.Text = Division(iNumA, iNumB).ToString();
        }


        private int Plus(int iA, int iB)
        {
            int iResult = 0;
            iResult = iA + iB;

            return iResult;
        }

        private int Minus(int iA, int iB)
        {
            int iResult = 0;
            iResult = iA - iB;

            return iResult;
        }
        private int Multi(int iA, int iB)
        {
            int iResult = 0;
            iResult = iA * iB;

            return iResult;
        }
        private int Division(int iA, int iB)
        {
            int iResult = 0;
            iResult = iA / iB;

            return iResult;
        }
    }
}
