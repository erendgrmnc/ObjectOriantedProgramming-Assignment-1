



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace NDP_ODEV_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Text = "Enter Full T.C ID Of Personnel";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GETTING THE TEXT FILE AND OPENING IT IN THE RICH TEXT BOX
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText);

                
                string text = richTextBox1.Text;
                //SPLITTING EVERY WORD FROM AN OTHER
                string[] rows = richTextBox1.Text.Split('\n');
                
                string[] words;
                foreach (string s in rows)
                {
                    words = s.Split(' ');
                    foreach (string k in words)
                    {
                        lstShow.Items.Add(k);
                    }


                }

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //CREATING THE PERSONNEL OBJECT
            Personnel p1 = new Personnel();

            string text = richTextBox1.Text;
            string[] rows = richTextBox1.Text.Split('\n');
            string[] words;
            foreach (string s in rows)
            {
                words = s.Split(' ');
            }


           if(textBox1.Text.Length == 11)
            { 
           for(int i = 0; i < lstShow.Items.Count; i++) //FOR SEARCHING THE ENTERED T.C ID IN THE TEXT DOCUMENT THEN ASSIGNING THE VARIABLES OF PERSONNEL CLAS
           { 
                if(textBox1.Text == Convert.ToString(lstShow.Items[i]))

                {
                    p1.tc = Convert.ToString(lstShow.Items[i]);
                    lblTC.Text = p1.tc;

                    p1.name = Convert.ToString(lstShow.Items[i + 1]);
                    lblName.Text = p1.name;

                    p1.surname = Convert.ToString(lstShow.Items[i + 2]);
                    lblSurname.Text = p1.surname;

                    p1.age = Convert.ToString(lstShow.Items[i + 3]);
                    lblAge.Text = p1.age;

                    p1.timeOfService = Convert.ToDouble(lstShow.Items[i + 4]);
                    lblTimeOfService.Text = Convert.ToString(p1.timeOfService);

                    p1.marriageStatus = Convert.ToString(lstShow.Items[i + 5]);
                    lblMarriageStatus.Text = p1.marriageStatus;

                    p1.isPartnerWorking = Convert.ToString(lstShow.Items[i + 6]);
                    lblPartnerWorking.Text = Convert.ToString(p1.isPartnerWorking);

                    p1.children = Convert.ToDouble(lstShow.Items[i + 7]);
                    lblChildren.Text = Convert.ToString(p1.children);

                    p1.baseSallary = Convert.ToDouble(lstShow.Items[i + 8]);
                    lblBaseSallary.Text = Convert.ToString(p1.baseSallary);

                    p1.spclPstnAllowance = Convert.ToDouble(lstShow.Items[i + 9]);
                    lblSpecialpstnAllowance.Text = Convert.ToString(p1.spclPstnAllowance);

                    p1.admnstrvFnctAllowance = Convert.ToDouble(lstShow.Items[i + 10]);
                    lblAdmnstFncAllowance.Text = Convert.ToString(p1.admnstrvFnctAllowance);

                    p1.extraShiftTime = Convert.ToDouble(lstShow.Items[i + 11]);
                    lblExtraShiftTime.Text = Convert.ToString(p1.extraShiftTime);

                    p1.extraShiftPayment = Convert.ToDouble(lstShow.Items[i + 12]);
                    lblExtraShiftPayment.Text = Convert.ToString(p1.extraShiftPayment);

                    p1.taxAssessment = Convert.ToDouble(lstShow.Items[i + 13]);
                    lblTaxAssessment.Text = Convert.ToString(p1.taxAssessment);

                    p1.imageLink = Convert.ToString(lstShow.Items[i + 14]);
                    lnklblPersonnel.Text = p1.imageLink;

                }

           }


           if(p1.marriageStatus == "E" && p1.isPartnerWorking == "E") //IF PERSONNEL IS MARRIED AND HIS/HER WIFE OR HUSBAND WORKS THIS METHODS WILL USE TO CALCULATE THE SALLARY INFOS
            {
                p1.grossSalary = p1.baseSallary + p1.spclPstnAllowance + p1.admnstrvFnctAllowance + (p1.children * 30) + (p1.extraShiftPayment * p1.extraShiftTime);
                p1.stampTax = (p1.grossSalary * 10) / 100;
                p1.pensionDeduciton = (p1.grossSalary * 15) / 100;

                if (p1.taxAssessment < 10000)
                {
                    p1.incomeTax = (p1.grossSalary * 15) / 100;
                }
                else if(p1.taxAssessment >= 10000 && p1.taxAssessment < 20000)
                {
                    p1.incomeTax = (p1.grossSalary * 20) / 100;
                }
                else if(p1.taxAssessment >= 20000 && p1.taxAssessment < 30000)
                {
                    p1.incomeTax = (p1.grossSalary * 25) / 100;
                }
                else if(p1.taxAssessment >= 30000)
                {
                    p1.incomeTax = (p1.grossSalary * 30) / 100;
                }

                p1.NetSallary = p1.grossSalary - (p1.pensionDeduciton + p1.incomeTax + p1.stampTax);

                lblGrossSallary.Text = Convert.ToString(p1.grossSalary);
                lblStampTax.Text = Convert.ToString(p1.stampTax);
                lblPensionDeduction.Text = Convert.ToString(p1.pensionDeduciton);
                lblincomeTax.Text = Convert.ToString(p1.incomeTax);
                lblNetSallary.Text = Convert.ToString(p1.NetSallary);
               

            }

           else if(p1.marriageStatus == "E" && p1.isPartnerWorking == "H") //IF PERSONNEL IS MARRIED AND HIS/HER WIFE OR HUSBAND NOT WORKS THIS METHODS WILL USE TO CALCULATE THE SALLARY INFOS
            {
                p1.grossSalary = p1.baseSallary + p1.spclPstnAllowance + p1.admnstrvFnctAllowance + 200 + (p1.children * 30) + (p1.extraShiftTime * p1.extraShiftPayment);
                p1.stampTax = (p1.grossSalary * 10) / 100;
                p1.pensionDeduciton = (p1.grossSalary * 15) / 100;

                if (p1.taxAssessment < 10000)
                {
                    p1.incomeTax = (p1.grossSalary * 15) / 100;
                }
                else if (p1.taxAssessment >= 10000 && p1.taxAssessment < 20000)
                {
                    p1.incomeTax = (p1.grossSalary * 20) / 100;
                }
                else if (p1.taxAssessment >= 20000 && p1.taxAssessment < 30000)
                {
                    p1.incomeTax = (p1.grossSalary * 25) / 100;
                }
                else if (p1.taxAssessment >= 30000)
                {
                    p1.incomeTax = (p1.grossSalary * 30) / 100;
                }

                p1.NetSallary = p1.grossSalary - (p1.pensionDeduciton + p1.incomeTax + p1.stampTax);

                lblGrossSallary.Text = Convert.ToString(p1.grossSalary);
                lblStampTax.Text = Convert.ToString(p1.stampTax);
                lblPensionDeduction.Text = Convert.ToString(p1.pensionDeduciton);
                lblincomeTax.Text = Convert.ToString(p1.incomeTax);
                lblNetSallary.Text = Convert.ToString(p1.NetSallary);
            }

           else if(p1.marriageStatus == "B") //IF PERSONNEL ISN'T MARRIED OR DIVORCED OR HIS/HER WIFE OR HUSBAND DIED THIS METHODS WILL USE TO CALCULATE THE SALLARY INFOS
            {
                p1.grossSalary = p1.baseSallary + p1.spclPstnAllowance + p1.admnstrvFnctAllowance + (p1.children * 30) + (p1.extraShiftPayment * p1.extraShiftTime);
                p1.stampTax = (p1.grossSalary * 10) / 100;
                p1.pensionDeduciton = (p1.grossSalary * 15) / 100;

                if (p1.taxAssessment < 10000)
                {
                    p1.incomeTax = (p1.grossSalary * 15) / 100;
                }
                else if (p1.taxAssessment >= 10000 && p1.taxAssessment < 20000)
                {
                    p1.incomeTax = (p1.grossSalary * 20) / 100;
                }
                else if (p1.taxAssessment >= 20000 && p1.taxAssessment < 30000)
                {
                    p1.incomeTax = (p1.grossSalary * 25) / 100;
                }
                else if (p1.taxAssessment >= 30000)
                {
                    p1.incomeTax = (p1.grossSalary * 30) / 100;
                }

                p1.NetSallary = p1.grossSalary - (p1.pensionDeduciton + p1.incomeTax + p1.stampTax);

                lblGrossSallary.Text = Convert.ToString(p1.grossSalary);
                lblStampTax.Text = Convert.ToString(p1.stampTax);
                lblPensionDeduction.Text = Convert.ToString(p1.pensionDeduciton);
                lblincomeTax.Text = Convert.ToString(p1.incomeTax);
                lblNetSallary.Text = Convert.ToString(p1.NetSallary);
                picBoxPersonnel.ImageLocation = Convert.ToString(p1.imageLink);
            }

            }
            else
            {
                MessageBox.Show("Please Enter Full T.C ID NUMBER","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picBoxPersonnel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "Enter Full T.C ID Of Personnel";
                textBox1.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Full T.C ID Of Personnel")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }
    }
}
