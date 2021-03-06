﻿namespace Manager.Views
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSort = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.radioOrderByName = new System.Windows.Forms.RadioButton();
            this.radioOrderByAge = new System.Windows.Forms.RadioButton();
            this.grpUpdateDelete = new System.Windows.Forms.GroupBox();
            this.labelDelete = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelUpdateResponse = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelPersonInfo = new System.Windows.Forms.Label();
            this.txtUpdateProperty = new System.Windows.Forms.TextBox();
            this.labelUpdateProperty = new System.Windows.Forms.Label();
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.labelCreate = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelCreateMajor = new System.Windows.Forms.Label();
            this.labelCreateSalary = new System.Windows.Forms.Label();
            this.labelCreateCompany = new System.Windows.Forms.Label();
            this.labelCreateTlf = new System.Windows.Forms.Label();
            this.labelCreateAge = new System.Windows.Forms.Label();
            this.labelCreateLastName = new System.Windows.Forms.Label();
            this.labelCreateFirstName = new System.Windows.Forms.Label();
            this.txtCreateTlf = new System.Windows.Forms.TextBox();
            this.txtCreateAge = new System.Windows.Forms.TextBox();
            this.radioCreateEmployed = new System.Windows.Forms.RadioButton();
            this.radioCreateStudent = new System.Windows.Forms.RadioButton();
            this.txtCreateMajor = new System.Windows.Forms.TextBox();
            this.txtCreateLastName = new System.Windows.Forms.TextBox();
            this.txtCreateFirstName = new System.Windows.Forms.TextBox();
            this.txtCreateSalary = new System.Windows.Forms.TextBox();
            this.txtCreateCompany = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.chkStudent = new System.Windows.Forms.CheckBox();
            this.chkEmployed = new System.Windows.Forms.CheckBox();
            this.chkSortDirection = new System.Windows.Forms.CheckBox();
            this.radioOrderByVarious = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpResult = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUpdateDelete.SuspendLayout();
            this.grpCreate.SuspendLayout();
            this.grpSort.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(32, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(905, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(16, 30);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(100, 23);
            this.buttonSort.TabIndex = 1;
            this.buttonSort.Text = "Sorter";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(16, 67);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(140, 20);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.textFilter_TextChanged);
            // 
            // radioOrderByName
            // 
            this.radioOrderByName.AutoSize = true;
            this.radioOrderByName.BackColor = System.Drawing.Color.DimGray;
            this.radioOrderByName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioOrderByName.Location = new System.Drawing.Point(16, 69);
            this.radioOrderByName.MinimumSize = new System.Drawing.Size(140, 0);
            this.radioOrderByName.Name = "radioOrderByName";
            this.radioOrderByName.Padding = new System.Windows.Forms.Padding(7, 2, 2, 2);
            this.radioOrderByName.Size = new System.Drawing.Size(140, 21);
            this.radioOrderByName.TabIndex = 3;
            this.radioOrderByName.TabStop = true;
            this.radioOrderByName.Text = "Sorter efter FORnavn";
            this.radioOrderByName.UseVisualStyleBackColor = false;
            // 
            // radioOrderByAge
            // 
            this.radioOrderByAge.AutoSize = true;
            this.radioOrderByAge.BackColor = System.Drawing.Color.DimGray;
            this.radioOrderByAge.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioOrderByAge.Location = new System.Drawing.Point(16, 96);
            this.radioOrderByAge.MinimumSize = new System.Drawing.Size(140, 0);
            this.radioOrderByAge.Name = "radioOrderByAge";
            this.radioOrderByAge.Padding = new System.Windows.Forms.Padding(7, 2, 2, 2);
            this.radioOrderByAge.Size = new System.Drawing.Size(140, 21);
            this.radioOrderByAge.TabIndex = 4;
            this.radioOrderByAge.TabStop = true;
            this.radioOrderByAge.Text = "Soter efter ALDER";
            this.radioOrderByAge.UseVisualStyleBackColor = false;
            // 
            // grpUpdateDelete
            // 
            this.grpUpdateDelete.Controls.Add(this.labelDelete);
            this.grpUpdateDelete.Controls.Add(this.buttonDelete);
            this.grpUpdateDelete.Controls.Add(this.labelUpdateResponse);
            this.grpUpdateDelete.Controls.Add(this.buttonUpdate);
            this.grpUpdateDelete.Controls.Add(this.labelPersonInfo);
            this.grpUpdateDelete.Controls.Add(this.txtUpdateProperty);
            this.grpUpdateDelete.Controls.Add(this.labelUpdateProperty);
            this.grpUpdateDelete.Location = new System.Drawing.Point(630, 414);
            this.grpUpdateDelete.Name = "grpUpdateDelete";
            this.grpUpdateDelete.Size = new System.Drawing.Size(307, 206);
            this.grpUpdateDelete.TabIndex = 5;
            this.grpUpdateDelete.TabStop = false;
            this.grpUpdateDelete.Text = "Opdater/Slet Person";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(126, 172);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(75, 13);
            this.labelDelete.TabIndex = 6;
            this.labelDelete.Text = "Slet en person";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(11, 167);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Slet Person";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelUpdateResponse
            // 
            this.labelUpdateResponse.AutoSize = true;
            this.labelUpdateResponse.Location = new System.Drawing.Point(9, 117);
            this.labelUpdateResponse.Name = "labelUpdateResponse";
            this.labelUpdateResponse.Size = new System.Drawing.Size(216, 13);
            this.labelUpdateResponse.TabIndex = 4;
            this.labelUpdateResponse.Text = "Klik på en persons egenskab for at opdatere";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(187, 84);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(101, 22);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Opdater";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelPersonInfo
            // 
            this.labelPersonInfo.AutoSize = true;
            this.labelPersonInfo.Location = new System.Drawing.Point(9, 28);
            this.labelPersonInfo.Name = "labelPersonInfo";
            this.labelPersonInfo.Size = new System.Drawing.Size(112, 13);
            this.labelPersonInfo.TabIndex = 2;
            this.labelPersonInfo.Text = "Person to be updated:";
            // 
            // txtUpdateProperty
            // 
            this.txtUpdateProperty.Location = new System.Drawing.Point(10, 84);
            this.txtUpdateProperty.Name = "txtUpdateProperty";
            this.txtUpdateProperty.Size = new System.Drawing.Size(163, 20);
            this.txtUpdateProperty.TabIndex = 8;
            this.txtUpdateProperty.TextChanged += new System.EventHandler(this.txtUpdateProperty_TextChanged);
            // 
            // labelUpdateProperty
            // 
            this.labelUpdateProperty.AutoSize = true;
            this.labelUpdateProperty.Location = new System.Drawing.Point(8, 55);
            this.labelUpdateProperty.Name = "labelUpdateProperty";
            this.labelUpdateProperty.Size = new System.Drawing.Size(86, 13);
            this.labelUpdateProperty.TabIndex = 0;
            this.labelUpdateProperty.Text = "Update property:";
            // 
            // grpCreate
            // 
            this.grpCreate.Controls.Add(this.labelCreate);
            this.grpCreate.Controls.Add(this.buttonCreate);
            this.grpCreate.Controls.Add(this.labelCreateMajor);
            this.grpCreate.Controls.Add(this.labelCreateSalary);
            this.grpCreate.Controls.Add(this.labelCreateCompany);
            this.grpCreate.Controls.Add(this.labelCreateTlf);
            this.grpCreate.Controls.Add(this.labelCreateAge);
            this.grpCreate.Controls.Add(this.labelCreateLastName);
            this.grpCreate.Controls.Add(this.labelCreateFirstName);
            this.grpCreate.Controls.Add(this.txtCreateTlf);
            this.grpCreate.Controls.Add(this.txtCreateAge);
            this.grpCreate.Controls.Add(this.radioCreateEmployed);
            this.grpCreate.Controls.Add(this.radioCreateStudent);
            this.grpCreate.Controls.Add(this.txtCreateMajor);
            this.grpCreate.Controls.Add(this.txtCreateLastName);
            this.grpCreate.Controls.Add(this.txtCreateFirstName);
            this.grpCreate.Controls.Add(this.txtCreateSalary);
            this.grpCreate.Controls.Add(this.txtCreateCompany);
            this.grpCreate.Location = new System.Drawing.Point(32, 414);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Size = new System.Drawing.Size(579, 206);
            this.grpCreate.TabIndex = 6;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Opret Person";
            // 
            // labelCreate
            // 
            this.labelCreate.AutoSize = true;
            this.labelCreate.Location = new System.Drawing.Point(446, 171);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(83, 13);
            this.labelCreate.TabIndex = 17;
            this.labelCreate.Text = "Opret en person";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(329, 167);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 23);
            this.buttonCreate.TabIndex = 16;
            this.buttonCreate.Text = "Opret";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelCreateMajor
            // 
            this.labelCreateMajor.AutoSize = true;
            this.labelCreateMajor.Location = new System.Drawing.Point(445, 132);
            this.labelCreateMajor.Name = "labelCreateMajor";
            this.labelCreateMajor.Size = new System.Drawing.Size(60, 13);
            this.labelCreateMajor.TabIndex = 15;
            this.labelCreateMajor.Text = "Indtast Fag";
            // 
            // labelCreateSalary
            // 
            this.labelCreateSalary.AutoSize = true;
            this.labelCreateSalary.Location = new System.Drawing.Point(445, 82);
            this.labelCreateSalary.Name = "labelCreateSalary";
            this.labelCreateSalary.Size = new System.Drawing.Size(60, 13);
            this.labelCreateSalary.TabIndex = 14;
            this.labelCreateSalary.Text = "Indtast Løn";
            // 
            // labelCreateCompany
            // 
            this.labelCreateCompany.AutoSize = true;
            this.labelCreateCompany.Location = new System.Drawing.Point(445, 50);
            this.labelCreateCompany.Name = "labelCreateCompany";
            this.labelCreateCompany.Size = new System.Drawing.Size(67, 13);
            this.labelCreateCompany.TabIndex = 13;
            this.labelCreateCompany.Text = "Indtast Firma";
            // 
            // labelCreateTlf
            // 
            this.labelCreateTlf.AutoSize = true;
            this.labelCreateTlf.Location = new System.Drawing.Point(135, 155);
            this.labelCreateTlf.Name = "labelCreateTlf";
            this.labelCreateTlf.Size = new System.Drawing.Size(115, 13);
            this.labelCreateTlf.TabIndex = 12;
            this.labelCreateTlf.Text = "Indtast Telefonnummer";
            // 
            // labelCreateAge
            // 
            this.labelCreateAge.AutoSize = true;
            this.labelCreateAge.Location = new System.Drawing.Point(135, 120);
            this.labelCreateAge.Name = "labelCreateAge";
            this.labelCreateAge.Size = new System.Drawing.Size(65, 13);
            this.labelCreateAge.TabIndex = 11;
            this.labelCreateAge.Text = "Indtast alder";
            // 
            // labelCreateLastName
            // 
            this.labelCreateLastName.AutoSize = true;
            this.labelCreateLastName.Location = new System.Drawing.Point(135, 84);
            this.labelCreateLastName.Name = "labelCreateLastName";
            this.labelCreateLastName.Size = new System.Drawing.Size(101, 13);
            this.labelCreateLastName.TabIndex = 10;
            this.labelCreateLastName.Text = "Indtast EFTERnavn";
            // 
            // labelCreateFirstName
            // 
            this.labelCreateFirstName.AutoSize = true;
            this.labelCreateFirstName.Location = new System.Drawing.Point(135, 46);
            this.labelCreateFirstName.Name = "labelCreateFirstName";
            this.labelCreateFirstName.Size = new System.Drawing.Size(88, 13);
            this.labelCreateFirstName.TabIndex = 9;
            this.labelCreateFirstName.Text = "Indtast FORnavn";
            // 
            // txtCreateTlf
            // 
            this.txtCreateTlf.Location = new System.Drawing.Point(18, 152);
            this.txtCreateTlf.Name = "txtCreateTlf";
            this.txtCreateTlf.Size = new System.Drawing.Size(100, 20);
            this.txtCreateTlf.TabIndex = 4;
            this.txtCreateTlf.TextChanged += new System.EventHandler(this.createText_TextChanged);
            // 
            // txtCreateAge
            // 
            this.txtCreateAge.Location = new System.Drawing.Point(18, 116);
            this.txtCreateAge.Name = "txtCreateAge";
            this.txtCreateAge.Size = new System.Drawing.Size(100, 20);
            this.txtCreateAge.TabIndex = 3;
            this.txtCreateAge.TextChanged += new System.EventHandler(this.createText_TextChanged);
            // 
            // radioCreateEmployed
            // 
            this.radioCreateEmployed.AutoSize = true;
            this.radioCreateEmployed.Location = new System.Drawing.Point(329, 26);
            this.radioCreateEmployed.Name = "radioCreateEmployed";
            this.radioCreateEmployed.Size = new System.Drawing.Size(71, 17);
            this.radioCreateEmployed.TabIndex = 0;
            this.radioCreateEmployed.TabStop = true;
            this.radioCreateEmployed.Text = "Employed";
            this.radioCreateEmployed.UseVisualStyleBackColor = true;
            // 
            // radioCreateStudent
            // 
            this.radioCreateStudent.AutoSize = true;
            this.radioCreateStudent.Location = new System.Drawing.Point(329, 109);
            this.radioCreateStudent.Name = "radioCreateStudent";
            this.radioCreateStudent.Size = new System.Drawing.Size(62, 17);
            this.radioCreateStudent.TabIndex = 0;
            this.radioCreateStudent.TabStop = true;
            this.radioCreateStudent.Text = "Student";
            this.radioCreateStudent.UseVisualStyleBackColor = true;
            // 
            // txtCreateMajor
            // 
            this.txtCreateMajor.Location = new System.Drawing.Point(329, 130);
            this.txtCreateMajor.Name = "txtCreateMajor";
            this.txtCreateMajor.Size = new System.Drawing.Size(100, 20);
            this.txtCreateMajor.TabIndex = 7;
            this.txtCreateMajor.TextChanged += new System.EventHandler(this.createText_TextChanged);
            // 
            // txtCreateLastName
            // 
            this.txtCreateLastName.Location = new System.Drawing.Point(18, 79);
            this.txtCreateLastName.Name = "txtCreateLastName";
            this.txtCreateLastName.Size = new System.Drawing.Size(100, 20);
            this.txtCreateLastName.TabIndex = 2;
            this.txtCreateLastName.TextChanged += new System.EventHandler(this.createText_TextChanged);
            // 
            // txtCreateFirstName
            // 
            this.txtCreateFirstName.Location = new System.Drawing.Point(18, 43);
            this.txtCreateFirstName.Name = "txtCreateFirstName";
            this.txtCreateFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtCreateFirstName.TabIndex = 1;
            this.txtCreateFirstName.TextChanged += new System.EventHandler(this.createText_TextChanged);
            // 
            // txtCreateSalary
            // 
            this.txtCreateSalary.Location = new System.Drawing.Point(329, 76);
            this.txtCreateSalary.Name = "txtCreateSalary";
            this.txtCreateSalary.Size = new System.Drawing.Size(100, 20);
            this.txtCreateSalary.TabIndex = 6;
            this.txtCreateSalary.TextChanged += new System.EventHandler(this.createText_TextChanged);
            // 
            // txtCreateCompany
            // 
            this.txtCreateCompany.Location = new System.Drawing.Point(329, 47);
            this.txtCreateCompany.Name = "txtCreateCompany";
            this.txtCreateCompany.Size = new System.Drawing.Size(100, 20);
            this.txtCreateCompany.TabIndex = 5;
            this.txtCreateCompany.TextChanged += new System.EventHandler(this.createText_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(14, 29);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(155, 13);
            this.labelSearch.TabIndex = 7;
            this.labelSearch.Text = "Filtrer og Sorter på EFTERnavn";
            // 
            // chkStudent
            // 
            this.chkStudent.AutoSize = true;
            this.chkStudent.Location = new System.Drawing.Point(20, 105);
            this.chkStudent.Name = "chkStudent";
            this.chkStudent.Size = new System.Drawing.Size(98, 17);
            this.chkStudent.TabIndex = 8;
            this.chkStudent.Text = "Show Students";
            this.chkStudent.UseVisualStyleBackColor = true;
            this.chkStudent.CheckedChanged += new System.EventHandler(this.chkStudentEmployed_CheckedChanged);
            // 
            // chkEmployed
            // 
            this.chkEmployed.AutoSize = true;
            this.chkEmployed.Location = new System.Drawing.Point(20, 124);
            this.chkEmployed.Name = "chkEmployed";
            this.chkEmployed.Size = new System.Drawing.Size(102, 17);
            this.chkEmployed.TabIndex = 9;
            this.chkEmployed.Text = "Show Employed";
            this.chkEmployed.UseVisualStyleBackColor = true;
            this.chkEmployed.CheckedChanged += new System.EventHandler(this.chkStudentEmployed_CheckedChanged);
            // 
            // chkSortDirection
            // 
            this.chkSortDirection.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSortDirection.AutoSize = true;
            this.chkSortDirection.Location = new System.Drawing.Point(122, 30);
            this.chkSortDirection.MaximumSize = new System.Drawing.Size(50, 0);
            this.chkSortDirection.MinimumSize = new System.Drawing.Size(50, 0);
            this.chkSortDirection.Name = "chkSortDirection";
            this.chkSortDirection.Size = new System.Drawing.Size(50, 23);
            this.chkSortDirection.TabIndex = 10;
            this.chkSortDirection.Text = "Desc";
            this.chkSortDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSortDirection.UseVisualStyleBackColor = true;
            this.chkSortDirection.CheckedChanged += new System.EventHandler(this.chkSortDirection_CheckedChanged);
            // 
            // radioOrderByVarious
            // 
            this.radioOrderByVarious.AutoSize = true;
            this.radioOrderByVarious.BackColor = System.Drawing.Color.DimGray;
            this.radioOrderByVarious.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioOrderByVarious.Location = new System.Drawing.Point(16, 123);
            this.radioOrderByVarious.MinimumSize = new System.Drawing.Size(140, 0);
            this.radioOrderByVarious.Name = "radioOrderByVarious";
            this.radioOrderByVarious.Padding = new System.Windows.Forms.Padding(7, 2, 2, 2);
            this.radioOrderByVarious.Size = new System.Drawing.Size(140, 21);
            this.radioOrderByVarious.TabIndex = 11;
            this.radioOrderByVarious.TabStop = true;
            this.radioOrderByVarious.Text = "Sorter efter STATUS";
            this.radioOrderByVarious.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(905, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Student/Employee Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSort
            // 
            this.grpSort.Controls.Add(this.chkSortDirection);
            this.grpSort.Controls.Add(this.radioOrderByVarious);
            this.grpSort.Controls.Add(this.buttonSort);
            this.grpSort.Controls.Add(this.radioOrderByName);
            this.grpSort.Controls.Add(this.radioOrderByAge);
            this.grpSort.Location = new System.Drawing.Point(954, 236);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(185, 156);
            this.grpSort.TabIndex = 13;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "Sorter";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(13, 25);
            this.labelResult.MaximumSize = new System.Drawing.Size(160, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 12;
            this.labelResult.Text = "Antal :";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.label2);
            this.grpFilter.Controls.Add(this.labelSearch);
            this.grpFilter.Controls.Add(this.chkEmployed);
            this.grpFilter.Controls.Add(this.txtFilter);
            this.grpFilter.Controls.Add(this.chkStudent);
            this.grpFilter.Location = new System.Drawing.Point(954, 9);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(185, 151);
            this.grpFilter.TabIndex = 14;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filtrer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = " - eller tlf.(kræver 8 cifre)";
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.labelResult);
            this.grpResult.Location = new System.Drawing.Point(954, 171);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(185, 59);
            this.grpResult.TabIndex = 15;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Filtreringsresultat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 632);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.grpSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpCreate);
            this.Controls.Add(this.grpUpdateDelete);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUpdateDelete.ResumeLayout(false);
            this.grpUpdateDelete.PerformLayout();
            this.grpCreate.ResumeLayout(false);
            this.grpCreate.PerformLayout();
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.RadioButton radioOrderByName;
        private System.Windows.Forms.RadioButton radioOrderByAge;
        private System.Windows.Forms.GroupBox grpUpdateDelete;
        private System.Windows.Forms.GroupBox grpCreate;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox txtUpdateProperty;
        private System.Windows.Forms.Label labelUpdateProperty;
        private System.Windows.Forms.Label labelPersonInfo;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelUpdateResponse;
        private System.Windows.Forms.CheckBox chkStudent;
        private System.Windows.Forms.CheckBox chkEmployed;
        private System.Windows.Forms.CheckBox chkSortDirection;
        private System.Windows.Forms.RadioButton radioOrderByVarious;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioCreateEmployed;
        private System.Windows.Forms.RadioButton radioCreateStudent;
        private System.Windows.Forms.TextBox txtCreateMajor;
        private System.Windows.Forms.TextBox txtCreateLastName;
        private System.Windows.Forms.TextBox txtCreateFirstName;
        private System.Windows.Forms.TextBox txtCreateSalary;
        private System.Windows.Forms.TextBox txtCreateCompany;
        private System.Windows.Forms.TextBox txtCreateTlf;
        private System.Windows.Forms.TextBox txtCreateAge;
        private System.Windows.Forms.Label labelCreateTlf;
        private System.Windows.Forms.Label labelCreateAge;
        private System.Windows.Forms.Label labelCreateLastName;
        private System.Windows.Forms.Label labelCreateFirstName;
        private System.Windows.Forms.Label labelCreateMajor;
        private System.Windows.Forms.Label labelCreateSalary;
        private System.Windows.Forms.Label labelCreateCompany;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.GroupBox grpResult;
    }
}

