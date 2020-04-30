namespace ClientTajmi
{
    partial class FrmSyncTable
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSrvUrl = new Telerik.WinControls.UI.RadTextBox();
            this.TxtSrvDatabaseCnn = new Telerik.WinControls.UI.RadTextBox();
            this.TxtSrvTableName = new Telerik.WinControls.UI.RadTextBox();
            this.TxtSrvPrimaryKey = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.TxtCliTable = new Telerik.WinControls.UI.RadTextBox();
            this.TxtCliDataBase = new Telerik.WinControls.UI.RadTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSrvUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSrvDatabaseCnn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSrvTableName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSrvPrimaryKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCliTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCliDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radGridView1);
            this.tabPage1.Controls.Add(this.radGroupBox1);
            this.tabPage1.Controls.Add(this.radGroupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "تجمیع";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage2.Size = new System.Drawing.Size(760, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "تنظیمات";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "آدرس سرور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "آدرس دیتابیس سرور";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "نام جدول";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "نام فیلد کلید";
            // 
            // TxtSrvUrl
            // 
            this.TxtSrvUrl.Location = new System.Drawing.Point(21, 17);
            this.TxtSrvUrl.Name = "TxtSrvUrl";
            this.TxtSrvUrl.Size = new System.Drawing.Size(244, 20);
            this.TxtSrvUrl.TabIndex = 8;
            // 
            // TxtSrvDatabaseCnn
            // 
            this.TxtSrvDatabaseCnn.Location = new System.Drawing.Point(21, 44);
            this.TxtSrvDatabaseCnn.Name = "TxtSrvDatabaseCnn";
            this.TxtSrvDatabaseCnn.Size = new System.Drawing.Size(244, 20);
            this.TxtSrvDatabaseCnn.TabIndex = 9;
            // 
            // TxtSrvTableName
            // 
            this.TxtSrvTableName.Location = new System.Drawing.Point(21, 71);
            this.TxtSrvTableName.Name = "TxtSrvTableName";
            this.TxtSrvTableName.Size = new System.Drawing.Size(244, 20);
            this.TxtSrvTableName.TabIndex = 10;
            // 
            // TxtSrvPrimaryKey
            // 
            this.TxtSrvPrimaryKey.Location = new System.Drawing.Point(21, 98);
            this.TxtSrvPrimaryKey.Name = "TxtSrvPrimaryKey";
            this.TxtSrvPrimaryKey.Size = new System.Drawing.Size(244, 20);
            this.TxtSrvPrimaryKey.TabIndex = 9;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(21, 124);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(131, 35);
            this.radButton1.TabIndex = 11;
            this.radButton1.Text = "دریافت رکورد های جدید";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(8, 184);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(746, 230);
            this.radGridView1.TabIndex = 12;
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(11, 124);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(131, 35);
            this.radButton2.TabIndex = 21;
            this.radButton2.Text = "بروزرسانی";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // TxtCliTable
            // 
            this.TxtCliTable.Location = new System.Drawing.Point(11, 48);
            this.TxtCliTable.Name = "TxtCliTable";
            this.TxtCliTable.Size = new System.Drawing.Size(238, 20);
            this.TxtCliTable.TabIndex = 20;
            // 
            // TxtCliDataBase
            // 
            this.TxtCliDataBase.Location = new System.Drawing.Point(11, 21);
            this.TxtCliDataBase.Name = "TxtCliDataBase";
            this.TxtCliDataBase.Size = new System.Drawing.Size(238, 20);
            this.TxtCliDataBase.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "نام جدول";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "آدرس دیتابیس";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.label3);
            this.radGroupBox1.Controls.Add(this.label4);
            this.radGroupBox1.Controls.Add(this.TxtSrvUrl);
            this.radGroupBox1.Controls.Add(this.TxtSrvDatabaseCnn);
            this.radGroupBox1.Controls.Add(this.radButton1);
            this.radGroupBox1.Controls.Add(this.TxtSrvTableName);
            this.radGroupBox1.Controls.Add(this.TxtSrvPrimaryKey);
            this.radGroupBox1.HeaderText = "مبداء";
            this.radGroupBox1.Location = new System.Drawing.Point(377, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(377, 172);
            this.radGroupBox1.TabIndex = 22;
            this.radGroupBox1.Text = "مبداء";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radButton2);
            this.radGroupBox2.Controls.Add(this.radProgressBar1);
            this.radGroupBox2.Controls.Add(this.TxtCliDataBase);
            this.radGroupBox2.Controls.Add(this.TxtCliTable);
            this.radGroupBox2.Controls.Add(this.label7);
            this.radGroupBox2.Controls.Add(this.label6);
            this.radGroupBox2.HeaderText = "مقصد";
            this.radGroupBox2.Location = new System.Drawing.Point(6, 6);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(365, 172);
            this.radGroupBox2.TabIndex = 23;
            this.radGroupBox2.Text = "مقصد";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.Location = new System.Drawing.Point(11, 94);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.ShowProgressIndicators = true;
            this.radProgressBar1.Size = new System.Drawing.Size(340, 24);
            this.radProgressBar1.TabIndex = 1;
            this.radProgressBar1.Text = "0 %";
            // 
            // FrmSyncTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 449);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmSyncTable";
            this.Text = "نرم افزار کلاینت تجمیع";
            this.Load += new System.EventHandler(this.FrmSyncTable_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSrvUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSrvDatabaseCnn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSrvTableName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSrvPrimaryKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCliTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCliDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadTextBox TxtSrvUrl;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadTextBox TxtSrvPrimaryKey;
        private Telerik.WinControls.UI.RadTextBox TxtSrvTableName;
        private Telerik.WinControls.UI.RadTextBox TxtSrvDatabaseCnn;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadTextBox TxtCliTable;
        private Telerik.WinControls.UI.RadTextBox TxtCliDataBase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

