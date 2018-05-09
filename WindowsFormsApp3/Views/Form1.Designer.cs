namespace Manager.Views
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSort = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.radioOrderByName = new System.Windows.Forms.RadioButton();
            this.radioOrderByAge = new System.Windows.Forms.RadioButton();
            this.grpUpdateDelete = new System.Windows.Forms.GroupBox();
            this.labelDelete = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
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
            this.radioOrderBySalary = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUpdateDelete.SuspendLayout();
            this.grpCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(32, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(905, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(965, 55);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(94, 23);
            this.buttonSort.TabIndex = 1;
            this.buttonSort.Text = "Hent og Sorter";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(965, 249);
            this.txtFilter.MaxLength = 8;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(140, 20);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.textFilter_TextChanged);
            // 
            // radioOrderByName
            // 
            this.radioOrderByName.AutoSize = true;
            this.radioOrderByName.BackColor = System.Drawing.Color.DimGray;
            this.radioOrderByName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioOrderByName.Location = new System.Drawing.Point(970, 84);
            this.radioOrderByName.Name = "radioOrderByName";
            this.radioOrderByName.Padding = new System.Windows.Forms.Padding(7, 2, 2, 2);
            this.radioOrderByName.Size = new System.Drawing.Size(145, 21);
            this.radioOrderByName.TabIndex = 3;
            this.radioOrderByName.TabStop = true;
            this.radioOrderByName.Text = "Sorter på EFTERNAVN";
            this.radioOrderByName.UseVisualStyleBackColor = false;
            // 
            // radioOrderByAge
            // 
            this.radioOrderByAge.AutoSize = true;
            this.radioOrderByAge.BackColor = System.Drawing.Color.DimGray;
            this.radioOrderByAge.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioOrderByAge.Location = new System.Drawing.Point(970, 111);
            this.radioOrderByAge.Name = "radioOrderByAge";
            this.radioOrderByAge.Padding = new System.Windows.Forms.Padding(7, 2, 2, 2);
            this.radioOrderByAge.Size = new System.Drawing.Size(113, 21);
            this.radioOrderByAge.TabIndex = 4;
            this.radioOrderByAge.TabStop = true;
            this.radioOrderByAge.Text = "Soter på ALDER";
            this.radioOrderByAge.UseVisualStyleBackColor = false;
            // 
            // grpUpdateDelete
            // 
            this.grpUpdateDelete.Controls.Add(this.labelDelete);
            this.grpUpdateDelete.Controls.Add(this.buttonDelete);
            this.grpUpdateDelete.Controls.Add(this.labelError);
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
            this.labelDelete.Location = new System.Drawing.Point(105, 172);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(75, 13);
            this.labelDelete.TabIndex = 6;
            this.labelDelete.Text = "Slet en person";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(10, 167);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Slet Person";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(7, 117);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(216, 13);
            this.labelError.TabIndex = 4;
            this.labelError.Text = "Klik på en persons egenskab for at opdatere";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(214, 84);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Opdater";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelPersonInfo
            // 
            this.labelPersonInfo.AutoSize = true;
            this.labelPersonInfo.Location = new System.Drawing.Point(6, 28);
            this.labelPersonInfo.Name = "labelPersonInfo";
            this.labelPersonInfo.Size = new System.Drawing.Size(112, 13);
            this.labelPersonInfo.TabIndex = 2;
            this.labelPersonInfo.Text = "Person to be updated:";
            // 
            // txtUpdateProperty
            // 
            this.txtUpdateProperty.Location = new System.Drawing.Point(9, 84);
            this.txtUpdateProperty.Name = "txtUpdateProperty";
            this.txtUpdateProperty.Size = new System.Drawing.Size(183, 20);
            this.txtUpdateProperty.TabIndex = 1;
            this.txtUpdateProperty.TextChanged += new System.EventHandler(this.txtUpdateProperty_TextChanged);
            // 
            // labelUpdateProperty
            // 
            this.labelUpdateProperty.AutoSize = true;
            this.labelUpdateProperty.Location = new System.Drawing.Point(7, 55);
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
            this.grpCreate.Location = new System.Drawing.Point(44, 414);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Size = new System.Drawing.Size(567, 206);
            this.grpCreate.TabIndex = 6;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Opret Person";
            // 
            // labelCreate
            // 
            this.labelCreate.AutoSize = true;
            this.labelCreate.Location = new System.Drawing.Point(448, 172);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(83, 13);
            this.labelCreate.TabIndex = 17;
            this.labelCreate.Text = "Opret en person";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(329, 167);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(103, 23);
            this.buttonCreate.TabIndex = 16;
            this.buttonCreate.Text = "Opret";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelCreateMajor
            // 
            this.labelCreateMajor.AutoSize = true;
            this.labelCreateMajor.Location = new System.Drawing.Point(445, 131);
            this.labelCreateMajor.Name = "labelCreateMajor";
            this.labelCreateMajor.Size = new System.Drawing.Size(60, 13);
            this.labelCreateMajor.TabIndex = 15;
            this.labelCreateMajor.Text = "Indtast Fag";
            // 
            // labelCreateSalary
            // 
            this.labelCreateSalary.AutoSize = true;
            this.labelCreateSalary.Location = new System.Drawing.Point(445, 81);
            this.labelCreateSalary.Name = "labelCreateSalary";
            this.labelCreateSalary.Size = new System.Drawing.Size(60, 13);
            this.labelCreateSalary.TabIndex = 14;
            this.labelCreateSalary.Text = "Indtast Løn";
            // 
            // labelCreateCompany
            // 
            this.labelCreateCompany.AutoSize = true;
            this.labelCreateCompany.Location = new System.Drawing.Point(445, 55);
            this.labelCreateCompany.Name = "labelCreateCompany";
            this.labelCreateCompany.Size = new System.Drawing.Size(67, 13);
            this.labelCreateCompany.TabIndex = 13;
            this.labelCreateCompany.Text = "Indtast Firma";
            // 
            // labelCreateTlf
            // 
            this.labelCreateTlf.AutoSize = true;
            this.labelCreateTlf.Location = new System.Drawing.Point(135, 154);
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
            this.labelCreateLastName.Location = new System.Drawing.Point(135, 86);
            this.labelCreateLastName.Name = "labelCreateLastName";
            this.labelCreateLastName.Size = new System.Drawing.Size(87, 13);
            this.labelCreateLastName.TabIndex = 10;
            this.labelCreateLastName.Text = "Indtast efternavn";
            // 
            // labelCreateFirstName
            // 
            this.labelCreateFirstName.AutoSize = true;
            this.labelCreateFirstName.Location = new System.Drawing.Point(135, 55);
            this.labelCreateFirstName.Name = "labelCreateFirstName";
            this.labelCreateFirstName.Size = new System.Drawing.Size(78, 13);
            this.labelCreateFirstName.TabIndex = 9;
            this.labelCreateFirstName.Text = "Indtast fornavn";
            // 
            // txtCreateTlf
            // 
            this.txtCreateTlf.Location = new System.Drawing.Point(18, 151);
            this.txtCreateTlf.Name = "txtCreateTlf";
            this.txtCreateTlf.Size = new System.Drawing.Size(100, 20);
            this.txtCreateTlf.TabIndex = 8;
            this.txtCreateTlf.TextChanged += new System.EventHandler(this.createText_TextChanged);
            // 
            // txtCreateAge
            // 
            this.txtCreateAge.Location = new System.Drawing.Point(18, 117);
            this.txtCreateAge.Name = "txtCreateAge";
            this.txtCreateAge.Size = new System.Drawing.Size(100, 20);
            this.txtCreateAge.TabIndex = 7;
            this.txtCreateAge.TextChanged += new System.EventHandler(this.createText_TextChanged);
            // 
            // radioCreateEmployed
            // 
            this.radioCreateEmployed.AutoSize = true;
            this.radioCreateEmployed.Location = new System.Drawing.Point(329, 29);
            this.radioCreateEmployed.Name = "radioCreateEmployed";
            this.radioCreateEmployed.Size = new System.Drawing.Size(71, 17);
            this.radioCreateEmployed.TabIndex = 6;
            this.radioCreateEmployed.TabStop = true;
            this.radioCreateEmployed.Text = "Employed";
            this.radioCreateEmployed.UseVisualStyleBackColor = true;
            // 
            // radioCreateStudent
            // 
            this.radioCreateStudent.AutoSize = true;
            this.radioCreateStudent.Location = new System.Drawing.Point(329, 105);
            this.radioCreateStudent.Name = "radioCreateStudent";
            this.radioCreateStudent.Size = new System.Drawing.Size(62, 17);
            this.radioCreateStudent.TabIndex = 5;
            this.radioCreateStudent.TabStop = true;
            this.radioCreateStudent.Text = "Student";
            this.radioCreateStudent.UseVisualStyleBackColor = true;
            // 
            // txtCreateMajor
            // 
            this.txtCreateMajor.Location = new System.Drawing.Point(329, 128);
            this.txtCreateMajor.Name = "txtCreateMajor";
            this.txtCreateMajor.Size = new System.Drawing.Size(100, 20);
            this.txtCreateMajor.TabIndex = 4;
            this.txtCreateMajor.TextChanged += new System.EventHandler(this.createText_TextChanged);
            // 
            // txtCreateLastName
            // 
            this.txtCreateLastName.Location = new System.Drawing.Point(18, 84);
            this.txtCreateLastName.Name = "txtCreateLastName";
            this.txtCreateLastName.Size = new System.Drawing.Size(100, 20);
            this.txtCreateLastName.TabIndex = 3;
            this.txtCreateLastName.TextChanged += new System.EventHandler(this.createText_TextChanged);
            // 
            // txtCreateFirstName
            // 
            this.txtCreateFirstName.Location = new System.Drawing.Point(18, 52);
            this.txtCreateFirstName.Name = "txtCreateFirstName";
            this.txtCreateFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtCreateFirstName.TabIndex = 2;
            this.txtCreateFirstName.TextChanged += new System.EventHandler(this.createText_TextChanged);
            // 
            // txtCreateSalary
            // 
            this.txtCreateSalary.Location = new System.Drawing.Point(329, 79);
            this.txtCreateSalary.Name = "txtCreateSalary";
            this.txtCreateSalary.Size = new System.Drawing.Size(100, 20);
            this.txtCreateSalary.TabIndex = 1;
            this.txtCreateSalary.TextChanged += new System.EventHandler(this.createText_TextChanged);
            // 
            // txtCreateCompany
            // 
            this.txtCreateCompany.Location = new System.Drawing.Point(329, 52);
            this.txtCreateCompany.Name = "txtCreateCompany";
            this.txtCreateCompany.Size = new System.Drawing.Size(100, 20);
            this.txtCreateCompany.TabIndex = 0;
            this.txtCreateCompany.TextChanged += new System.EventHandler(this.createText_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(972, 224);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(107, 13);
            this.labelSearch.TabIndex = 7;
            this.labelSearch.Text = "Søg på Tlf eller Navn";
            // 
            // chkStudent
            // 
            this.chkStudent.AutoSize = true;
            this.chkStudent.Location = new System.Drawing.Point(975, 165);
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
            this.chkEmployed.Location = new System.Drawing.Point(975, 188);
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
            this.chkSortDirection.Location = new System.Drawing.Point(1065, 55);
            this.chkSortDirection.MaximumSize = new System.Drawing.Size(40, 0);
            this.chkSortDirection.MinimumSize = new System.Drawing.Size(40, 0);
            this.chkSortDirection.Name = "chkSortDirection";
            this.chkSortDirection.Size = new System.Drawing.Size(40, 23);
            this.chkSortDirection.TabIndex = 10;
            this.chkSortDirection.Text = "Desc";
            this.chkSortDirection.UseVisualStyleBackColor = true;
            this.chkSortDirection.CheckedChanged += new System.EventHandler(this.chkSortDirection_CheckedChanged);
            // 
            // radioOrderBySalary
            // 
            this.radioOrderBySalary.AutoSize = true;
            this.radioOrderBySalary.BackColor = System.Drawing.Color.DimGray;
            this.radioOrderBySalary.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioOrderBySalary.Location = new System.Drawing.Point(970, 138);
            this.radioOrderBySalary.Name = "radioOrderBySalary";
            this.radioOrderBySalary.Padding = new System.Windows.Forms.Padding(7, 2, 2, 2);
            this.radioOrderBySalary.Size = new System.Drawing.Size(108, 21);
            this.radioOrderBySalary.TabIndex = 11;
            this.radioOrderBySalary.TabStop = true;
            this.radioOrderBySalary.Text = "Sorter på TYPE";
            this.radioOrderBySalary.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 632);
            this.Controls.Add(this.radioOrderBySalary);
            this.Controls.Add(this.chkSortDirection);
            this.Controls.Add(this.chkEmployed);
            this.Controls.Add(this.chkStudent);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.grpCreate);
            this.Controls.Add(this.grpUpdateDelete);
            this.Controls.Add(this.radioOrderByAge);
            this.Controls.Add(this.radioOrderByName);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUpdateDelete.ResumeLayout(false);
            this.grpUpdateDelete.PerformLayout();
            this.grpCreate.ResumeLayout(false);
            this.grpCreate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.CheckBox chkStudent;
        private System.Windows.Forms.CheckBox chkEmployed;
        private System.Windows.Forms.CheckBox chkSortDirection;
        private System.Windows.Forms.RadioButton radioOrderBySalary;
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
    }
}

