using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nsMyRecord;

namespace databinding_to_BindingList
{
    public partial class Form1 : Form
    {
        
        private BindingList<MyRecord> lstMyRecord;
        private int rand;
        private string country;
        private string name;

        public Form1()
        {
            InitializeComponent();
            lstMyRecord = new BindingList<MyRecord>();
            DoBind();
            country = @"China";
            name = @"Zhou Kai";
        }

        private void DoBind()
        {
            listBox1.DataSource = lstMyRecord;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rand = new Random().Next();
            MyRecord record = new MyRecord(rand, name, country);
            lstMyRecord.Add(record);

        }
    }
}
