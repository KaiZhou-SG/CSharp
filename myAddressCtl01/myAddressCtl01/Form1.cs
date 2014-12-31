using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FM.FMSystem.BLL;

namespace myAddressCtl01
{
    public partial class Form1 : Form
    {
        public List<CustomerDTO> lstCustomerDTO;

        public Form1()
        {
            InitializeComponent();

            lstCustomerDTO =  new List<CustomerDTO>();
            myAddressCtl1.OnInitializeCodes += Initialize;
        }

        private void Initialize(object sender, EventArgs e)
        {
            CustomerDTO c1 = new CustomerDTO();
            c1.Code = "c1";
            c1.Name = "c1_name";
            c1.address1 = "a1";
            c1.address2 = "a2";
            c1.address3 = "a3";
            c1.address4 = "a4";
            c1.city = "a_city";

            CustomerDTO c2 = new CustomerDTO();
            c2.Code = "c2";
            c2.Name = "c2_name";
            c2.address1 = "a1";
            c2.address2 = "a2";
            c2.address3 = "a3";
            c2.address4 = "a4";
            c2.city = "a_city";

            CustomerDTO c3 = new CustomerDTO();
            c3.Code = "c3";
            c3.Name = "c3_name";
            c3.address1 = "a1";
            c3.address2 = "a2";
            c3.address3 = "a3";
            c3.address4 = "a4";
            c3.city = "a_city";
            CustomerDTO c4 = new CustomerDTO();
            c4.Code = "c4";
            c4.Name = "c4_name";
            c4.address1 = "a1";
            c4.address2 = "a2";
            c4.address3 = "a3";
            c4.address4 = "a4";
            c4.city = "a_city";
            CustomerDTO c5 = new CustomerDTO();
            c5.Code = "c5";
            c5.Name = "c5_name";
            c5.address1 = "a1";
            c5.address2 = "a2";
            c5.address3 = "a3";
            c5.address4 = "a4";
            c5.city = "a_city";

            lstCustomerDTO.Add(c1);
            lstCustomerDTO.Add(c2);
            lstCustomerDTO.Add(c3);
            lstCustomerDTO.Add(c4);
            lstCustomerDTO.Add(c5);

            myAddressCtl1.bdsAddresses.DataSource = lstCustomerDTO;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Initialize(this, EventArgs.Empty);   
        }
    }
}
