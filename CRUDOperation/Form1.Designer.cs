namespace CRUDOperation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtid = new TextBox();
            txtname = new TextBox();
            txtaddress = new TextBox();
            txtsalary = new TextBox();
            txtsearch = new TextBox();
            Insert = new Button();
            Update = new Button();
            Delete = new Button();
            ShowAll = new Button();
            Find = new Button();
            Exit = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 30);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 65);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 106);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 147);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Salary";
            // 
            // txtid
            // 
            txtid.Location = new Point(87, 27);
            txtid.Name = "txtid";
            txtid.Size = new Size(162, 23);
            txtid.TabIndex = 4;
            // 
            // txtname
            // 
            txtname.Location = new Point(87, 62);
            txtname.Name = "txtname";
            txtname.Size = new Size(162, 23);
            txtname.TabIndex = 5;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(87, 103);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(162, 23);
            txtaddress.TabIndex = 6;
            // 
            // txtsalary
            // 
            txtsalary.Location = new Point(87, 144);
            txtsalary.Name = "txtsalary";
            txtsalary.Size = new Size(162, 23);
            txtsalary.TabIndex = 7;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(266, 27);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(288, 23);
            txtsearch.TabIndex = 8;
            // 
            // Insert
            // 
            Insert.Location = new Point(12, 196);
            Insert.Name = "Insert";
            Insert.Size = new Size(75, 23);
            Insert.TabIndex = 9;
            Insert.Text = "Insert";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Click;
            // 
            // Update
            // 
            Update.Location = new Point(93, 196);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 10;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(174, 196);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 11;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // ShowAll
            // 
            ShowAll.Location = new Point(12, 237);
            ShowAll.Name = "ShowAll";
            ShowAll.Size = new Size(75, 29);
            ShowAll.TabIndex = 12;
            ShowAll.Text = "Show All";
            ShowAll.UseVisualStyleBackColor = true;
            ShowAll.Click += ShowAll_Click;
            // 
            // Find
            // 
            Find.BackColor = Color.Green;
            Find.ForeColor = Color.White;
            Find.Location = new Point(560, 27);
            Find.Name = "Find";
            Find.Size = new Size(75, 23);
            Find.TabIndex = 13;
            Find.Text = "Find";
            Find.UseVisualStyleBackColor = false;
            Find.Click += Find_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Red;
            Exit.ForeColor = Color.White;
            Exit.Location = new Point(174, 237);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 29);
            Exit.TabIndex = 14;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(266, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(368, 210);
            dataGridView1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 289);
            Controls.Add(dataGridView1);
            Controls.Add(Exit);
            Controls.Add(Find);
            Controls.Add(ShowAll);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Insert);
            Controls.Add(txtsearch);
            Controls.Add(txtsalary);
            Controls.Add(txtaddress);
            Controls.Add(txtname);
            Controls.Add(txtid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtid;
        private TextBox txtname;
        private TextBox txtaddress;
        private TextBox txtsalary;
        private TextBox txtsearch;
        private Button Insert;
        private Button Update;
        private Button Delete;
        private Button ShowAll;
        private Button Find;
        private Button Exit;
        private DataGridView dataGridView1;
    }
}