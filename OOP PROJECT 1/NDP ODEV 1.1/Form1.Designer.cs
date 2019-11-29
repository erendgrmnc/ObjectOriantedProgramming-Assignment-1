

namespace NDP_ODEV_1._1
{

   public class Personnel
    {

        //PERSONNEL VARRIABLES

        public string tc;
        public string name;
        public string surname;
        public string age;
        public double timeOfService;
        public string marriageStatus;
        public string isPartnerWorking;
        public double children = 0;
        public double baseSallary;
        public double spclPstnAllowance;
        public double admnstrvFnctAllowance;
        public double extraShiftTime;
        public double extraShiftPayment;
        public double taxAssessment;
        public string imageLink;
        public double grossSalary;
        public double stampTax;
        public double incomeTax;
        public double pensionDeduciton;
        public double NetSallary;

    }




    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblTimeOfService = new System.Windows.Forms.Label();
            this.lblMarriageStatus = new System.Windows.Forms.Label();
            this.lblPartnerWorking = new System.Windows.Forms.Label();
            this.lblChildren = new System.Windows.Forms.Label();
            this.lblBaseSallary = new System.Windows.Forms.Label();
            this.lblSpecialpstnAllowance = new System.Windows.Forms.Label();
            this.lblAdmnstFncAllowance = new System.Windows.Forms.Label();
            this.lblExtraShiftTime = new System.Windows.Forms.Label();
            this.lblExtraShiftPayment = new System.Windows.Forms.Label();
            this.lblTaxAssessment = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstShow = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lnklblPersonnel = new System.Windows.Forms.LinkLabel();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblNetSallary = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.lblincomeTax = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.lblPensionDeduction = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.lblStampTax = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.lblGrossSallary = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.picBoxPersonnel = new System.Windows.Forms.PictureBox();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(429, 354);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surname :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 591);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Age :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(31, 627);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Time Of Service :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(31, 665);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Marriage Status :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(31, 702);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Partner Working Status :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(31, 738);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Children :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(652, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Base Sallary :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(652, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(314, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "Special Position Allowance :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(652, 554);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(400, 29);
            this.label11.TabIndex = 11;
            this.label11.Text = "Administritive Function Allowance :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(652, 590);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 29);
            this.label12.TabIndex = 12;
            this.label12.Text = "Extra Shift Time :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(652, 626);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(244, 29);
            this.label13.TabIndex = 13;
            this.label13.Text = "Extra Shift Payment :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(652, 664);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(196, 29);
            this.label14.TabIndex = 14;
            this.label14.Text = "Tax Assessment :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(135, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(827, 398);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 30);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "ENTER FULL T.C ID NUMBER HERE";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(658, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 38);
            this.button2.TabIndex = 17;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Location = new System.Drawing.Point(420, 477);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(0, 29);
            this.lblTC.TabIndex = 18;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(420, 514);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 29);
            this.lblName.TabIndex = 19;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Location = new System.Drawing.Point(420, 555);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(0, 29);
            this.lblSurname.TabIndex = 20;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAge.Location = new System.Drawing.Point(420, 591);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(0, 29);
            this.lblAge.TabIndex = 21;
            // 
            // lblTimeOfService
            // 
            this.lblTimeOfService.AutoSize = true;
            this.lblTimeOfService.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimeOfService.Location = new System.Drawing.Point(420, 627);
            this.lblTimeOfService.Name = "lblTimeOfService";
            this.lblTimeOfService.Size = new System.Drawing.Size(0, 29);
            this.lblTimeOfService.TabIndex = 22;
            // 
            // lblMarriageStatus
            // 
            this.lblMarriageStatus.AutoSize = true;
            this.lblMarriageStatus.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarriageStatus.Location = new System.Drawing.Point(420, 665);
            this.lblMarriageStatus.Name = "lblMarriageStatus";
            this.lblMarriageStatus.Size = new System.Drawing.Size(0, 29);
            this.lblMarriageStatus.TabIndex = 23;
            // 
            // lblPartnerWorking
            // 
            this.lblPartnerWorking.AutoSize = true;
            this.lblPartnerWorking.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPartnerWorking.Location = new System.Drawing.Point(420, 702);
            this.lblPartnerWorking.Name = "lblPartnerWorking";
            this.lblPartnerWorking.Size = new System.Drawing.Size(0, 29);
            this.lblPartnerWorking.TabIndex = 24;
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChildren.Location = new System.Drawing.Point(420, 738);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(0, 29);
            this.lblChildren.TabIndex = 25;
            // 
            // lblBaseSallary
            // 
            this.lblBaseSallary.AutoSize = true;
            this.lblBaseSallary.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaseSallary.Location = new System.Drawing.Point(1185, 485);
            this.lblBaseSallary.Name = "lblBaseSallary";
            this.lblBaseSallary.Size = new System.Drawing.Size(0, 29);
            this.lblBaseSallary.TabIndex = 26;
            // 
            // lblSpecialpstnAllowance
            // 
            this.lblSpecialpstnAllowance.AutoSize = true;
            this.lblSpecialpstnAllowance.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSpecialpstnAllowance.Location = new System.Drawing.Point(1185, 523);
            this.lblSpecialpstnAllowance.Name = "lblSpecialpstnAllowance";
            this.lblSpecialpstnAllowance.Size = new System.Drawing.Size(0, 29);
            this.lblSpecialpstnAllowance.TabIndex = 27;
            // 
            // lblAdmnstFncAllowance
            // 
            this.lblAdmnstFncAllowance.AutoSize = true;
            this.lblAdmnstFncAllowance.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdmnstFncAllowance.Location = new System.Drawing.Point(1185, 563);
            this.lblAdmnstFncAllowance.Name = "lblAdmnstFncAllowance";
            this.lblAdmnstFncAllowance.Size = new System.Drawing.Size(0, 29);
            this.lblAdmnstFncAllowance.TabIndex = 28;
            // 
            // lblExtraShiftTime
            // 
            this.lblExtraShiftTime.AutoSize = true;
            this.lblExtraShiftTime.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExtraShiftTime.Location = new System.Drawing.Point(1185, 600);
            this.lblExtraShiftTime.Name = "lblExtraShiftTime";
            this.lblExtraShiftTime.Size = new System.Drawing.Size(0, 29);
            this.lblExtraShiftTime.TabIndex = 29;
            // 
            // lblExtraShiftPayment
            // 
            this.lblExtraShiftPayment.AutoSize = true;
            this.lblExtraShiftPayment.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExtraShiftPayment.Location = new System.Drawing.Point(1185, 636);
            this.lblExtraShiftPayment.Name = "lblExtraShiftPayment";
            this.lblExtraShiftPayment.Size = new System.Drawing.Size(0, 29);
            this.lblExtraShiftPayment.TabIndex = 30;
            // 
            // lblTaxAssessment
            // 
            this.lblTaxAssessment.AutoSize = true;
            this.lblTaxAssessment.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaxAssessment.Location = new System.Drawing.Point(1185, 674);
            this.lblTaxAssessment.Name = "lblTaxAssessment";
            this.lblTaxAssessment.Size = new System.Drawing.Size(0, 29);
            this.lblTaxAssessment.TabIndex = 31;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstShow
            // 
            this.lstShow.FormattingEnabled = true;
            this.lstShow.ItemHeight = 16;
            this.lstShow.Location = new System.Drawing.Point(644, -25);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(541, 356);
            this.lstShow.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(652, 702);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(261, 29);
            this.label15.TabIndex = 33;
            this.label15.Text = "Personnel Image Link :";
            // 
            // lnklblPersonnel
            // 
            this.lnklblPersonnel.AutoSize = true;
            this.lnklblPersonnel.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnklblPersonnel.Location = new System.Drawing.Point(1185, 710);
            this.lnklblPersonnel.Name = "lnklblPersonnel";
            this.lnklblPersonnel.Size = new System.Drawing.Size(0, 29);
            this.lnklblPersonnel.TabIndex = 34;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblNetSallary);
            this.grpInfo.Controls.Add(this.labelE);
            this.grpInfo.Controls.Add(this.lblincomeTax);
            this.grpInfo.Controls.Add(this.labelD);
            this.grpInfo.Controls.Add(this.lblPensionDeduction);
            this.grpInfo.Controls.Add(this.labelC);
            this.grpInfo.Controls.Add(this.lblStampTax);
            this.grpInfo.Controls.Add(this.labelB);
            this.grpInfo.Controls.Add(this.lblGrossSallary);
            this.grpInfo.Controls.Add(this.labelA);
            this.grpInfo.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.grpInfo.Location = new System.Drawing.Point(36, 797);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInfo.Size = new System.Drawing.Size(460, 247);
            this.grpInfo.TabIndex = 35;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Sallary Information";
            // 
            // lblNetSallary
            // 
            this.lblNetSallary.AutoSize = true;
            this.lblNetSallary.Location = new System.Drawing.Point(376, 202);
            this.lblNetSallary.Name = "lblNetSallary";
            this.lblNetSallary.Size = new System.Drawing.Size(0, 29);
            this.lblNetSallary.TabIndex = 9;
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Location = new System.Drawing.Point(14, 203);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(147, 29);
            this.labelE.TabIndex = 8;
            this.labelE.Text = "Net Sallary :";
            // 
            // lblincomeTax
            // 
            this.lblincomeTax.AutoSize = true;
            this.lblincomeTax.Location = new System.Drawing.Point(376, 167);
            this.lblincomeTax.Name = "lblincomeTax";
            this.lblincomeTax.Size = new System.Drawing.Size(0, 29);
            this.lblincomeTax.TabIndex = 7;
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(14, 167);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(149, 29);
            this.labelD.TabIndex = 6;
            this.labelD.Text = "Income Tax :";
            // 
            // lblPensionDeduction
            // 
            this.lblPensionDeduction.AutoSize = true;
            this.lblPensionDeduction.Location = new System.Drawing.Point(376, 130);
            this.lblPensionDeduction.Name = "lblPensionDeduction";
            this.lblPensionDeduction.Size = new System.Drawing.Size(0, 29);
            this.lblPensionDeduction.TabIndex = 5;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(14, 130);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(228, 29);
            this.labelC.TabIndex = 4;
            this.labelC.Text = "Pension Deduction :";
            // 
            // lblStampTax
            // 
            this.lblStampTax.AutoSize = true;
            this.lblStampTax.Location = new System.Drawing.Point(376, 90);
            this.lblStampTax.Name = "lblStampTax";
            this.lblStampTax.Size = new System.Drawing.Size(0, 29);
            this.lblStampTax.TabIndex = 3;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(14, 90);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(138, 29);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "Stamp Tax :";
            // 
            // lblGrossSallary
            // 
            this.lblGrossSallary.AutoSize = true;
            this.lblGrossSallary.Location = new System.Drawing.Point(376, 48);
            this.lblGrossSallary.Name = "lblGrossSallary";
            this.lblGrossSallary.Size = new System.Drawing.Size(0, 29);
            this.lblGrossSallary.TabIndex = 1;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(14, 48);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(170, 29);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "Gross Sallary :";
            // 
            // picBoxPersonnel
            // 
            this.picBoxPersonnel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picBoxPersonnel.Location = new System.Drawing.Point(658, 797);
            this.picBoxPersonnel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxPersonnel.Name = "picBoxPersonnel";
            this.picBoxPersonnel.Size = new System.Drawing.Size(283, 247);
            this.picBoxPersonnel.TabIndex = 36;
            this.picBoxPersonnel.TabStop = false;
            this.picBoxPersonnel.Click += new System.EventHandler(this.picBoxPersonnel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1364, 1055);
            this.Controls.Add(this.picBoxPersonnel);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.lnklblPersonnel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lstShow);
            this.Controls.Add(this.lblTaxAssessment);
            this.Controls.Add(this.lblExtraShiftPayment);
            this.Controls.Add(this.lblExtraShiftTime);
            this.Controls.Add(this.lblAdmnstFncAllowance);
            this.Controls.Add(this.lblSpecialpstnAllowance);
            this.Controls.Add(this.lblBaseSallary);
            this.Controls.Add(this.lblChildren);
            this.Controls.Add(this.lblPartnerWorking);
            this.Controls.Add(this.lblMarriageStatus);
            this.Controls.Add(this.lblTimeOfService);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "PROGRAM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblTimeOfService;
        private System.Windows.Forms.Label lblMarriageStatus;
        private System.Windows.Forms.Label lblPartnerWorking;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.Label lblBaseSallary;
        private System.Windows.Forms.Label lblSpecialpstnAllowance;
        private System.Windows.Forms.Label lblAdmnstFncAllowance;
        private System.Windows.Forms.Label lblExtraShiftTime;
        private System.Windows.Forms.Label lblExtraShiftPayment;
        private System.Windows.Forms.Label lblTaxAssessment;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lstShow;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel lnklblPersonnel;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblincomeTax;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label lblPensionDeduction;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label lblStampTax;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label lblGrossSallary;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label lblNetSallary;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.PictureBox picBoxPersonnel;
    }
}

