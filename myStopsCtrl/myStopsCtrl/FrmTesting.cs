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

namespace myStopsCtrl
{
    public partial class FrmTesting : Form
    {
        public List<CustomerDTO> lstCustomerDTOs;

        public FrmTesting()
        {
            InitializeComponent();

            lstCustomerDTOs = new List<CustomerDTO>();
        }

        public static void Main(string[] args)
        {
            Application.Run(new FrmTesting());
        }

        private void FrmTesting_Load(object sender, EventArgs e)
        {

        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            CustomerDTO c1 = new CustomerDTO()
            {
                Code = "c1",
                Name = "c1_name",
                address1 = "c1_add1",
                address2 = "c1_add2",
                address3 = "c1_add3",
                address4 = "c1_add4",
                city = "c1_city"
            };

            CustomerDTO c2 = new CustomerDTO()
            {
                Code = "c2",
                Name = "c2_name",
                address1 = "c2_add1",
                address2 = "c2_add2",
                address3 = "c2_add3",
                address4 = "c2_add4",
                city = "c2_city"
            };
            

            CustomerDTO c3 = new CustomerDTO()
            {
                Code = "c3",
                Name = "c3_name",
                address1 = "c3_add1",
                address2 = "c3_add2",
                address3 = "c3_add3",
                address4 = "c3_add4",
                city = "c3_city"
            };

            CustomerDTO c4 = new CustomerDTO();
            c4.Code = "c4";
            c4.Name = "c4_name";
            c4.address1 = "c4_add1";
            c4.address2 = "c4_add2";
            c4.address3 = "c4_add3";
            c4.address4 = "c4_add4";
            c4.city = "c4_city";

            CustomerDTO c5 = new CustomerDTO();
            c5.Code = "c5";
            c5.Name = "c5_name";
            c5.address1 = "c5_add1";
            c5.address2 = "c5_add2";
            c5.address3 = "c5_add3";
            c5.address4 = "c5_add4";
            c5.city = "c5_city";

            CustomerDTO c6 = new CustomerDTO();
            c6.Code = "c6";
            c6.Name = "c6_name";
            c6.address1 = "c6_add1";
            c6.address2 = "c6_add2";
            c6.address3 = "c6_add3";
            c6.address4 = "c6_add4";
            c6.city = "c6_city";

            lstCustomerDTOs.Add(c1);
            lstCustomerDTOs.Add(c2);
            lstCustomerDTOs.Add(c3);
            lstCustomerDTOs.Add(c4);
            lstCustomerDTOs.Add(c5);
            lstCustomerDTOs.Add(c6);

            BindingSource bdsStops = new BindingSource();
            bdsStops.DataSource = lstCustomerDTOs;
            myStopsCtrl1.BdsStops = bdsStops;
        }
    }
}
