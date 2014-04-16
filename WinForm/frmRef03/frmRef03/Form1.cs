using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmRef03
{
    /// <summary>
    /// 2014-04-16 Zhou Kai writes this program to test a feature of reference:
    /// 1. Define a new class: MyRefType
    /// 2. Define two variables MyRefType myRefType1, myRefType2;
    /// 3. myRefType1  = myRefType2
    /// 4. Modify myRefType1 to see what happens to myRefType2
    /// 5. Modify myRefType2 to see what happens to myRefType1
    /// 6. The results are very different from what happened on string reference copy:
    /// The class object MyRefType is totally referenced to the new object after
    /// the ref1 = ref2 assignment
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// The default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);
            this.btnMakeAChange.Click += new EventHandler(btnMakeAChange_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myRefType1 = new MyRefType(1, 1, "str11", "str12", "var1");
            myRefType2 = new MyRefType(2, 2, "str21", "str22", "var2");

            myRefType1 = myRefType2;
        }

        private void btnMakeAChange_Click(object sender, EventArgs e)
        {
            myRefType1.Str1 = "I'm var1.Str1, now I'm changed, see var2";
            myRefType1.Str2 = "I'm var1.Str2, now I'm changed, see var2";
            myRefType1.Num1 = 1111;
            myRefType1.Num2 = 1222;
            myRefType1.TalkAboutMySelf();
            myRefType2.TalkAboutMySelf();

            //myRefType2.Str1 = "I'm var2.Str1, now I'm changed, see var1";
            //myRefType1.Str1 = "I'm var1.Str1, now I'm changed, see var2";
            //myRefType1.Num1 = 1111;
            //myRefType1.Num2 = 1222;
        }

        #region "Privae member variables"
        private MyRefType myRefType1, myRefType2;
        #endregion
    }

    public class MyRefType
    {
        private int num1;
        private int num2;
        private string str1;
        private string str2;
        private string name;

        public MyRefType()
        {
            num1 = 0;
            num2 = 0;
            str1 = String.Empty;
            str2 = String.Empty;
            name = String.Empty;
        }

        public MyRefType(int num1, int num2, string str1, string str2, string name)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.str1 = str1;
            this.str2 = str2;
            this.name = name;
        }

        public int Num1
        {
            get {return num1;}
            set {num1 = value;}
        }

        public int Num2 
        {
            get {return num2;}
            set {num2 = value;}
        }

        public string Str1
        {
            get { return str1; }
            set { str1 = value; }
        }

        public string Str2
        {
            get { return str2; }
            set { str2 = value; }
        }

        public void TalkAboutMySelf()
        {
            MessageBox.Show(String.Format("num1 = {0}\nnum2 = {1}\nstr1 = {2}\nstr2 = {3}", 
                this.num1, this.num2, this.str1, this.str2), this.ToString());
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
