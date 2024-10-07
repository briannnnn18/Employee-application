namespace Employee_application
{
    partial class frmEmployeeDatabase
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
            dataGridView1 = new DataGridView();
            EmployeeId = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            TextEmployeeId = new TextBox();
            TextFirstName = new TextBox();
            TextLastName = new TextBox();
            TextPosition = new TextBox();
            btnAddEmployee = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SlateGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeId, FirstName, LastName, Position });
            dataGridView1.Location = new Point(270, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(641, 320);
            dataGridView1.TabIndex = 0;
            // 
            // EmployeeId
            // 
            EmployeeId.HeaderText = "ID";
            EmployeeId.Name = "EmployeeId";
            EmployeeId.Width = 150;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "FirstName";
            FirstName.Name = "FirstName";
            FirstName.Width = 150;
            // 
            // LastName
            // 
            LastName.HeaderText = "LastName";
            LastName.Name = "LastName";
            LastName.Width = 150;
            // 
            // Position
            // 
            Position.HeaderText = "Position";
            Position.Name = "Position";
            Position.Width = 150;
            // 
            // TextEmployeeId
            // 
            TextEmployeeId.Location = new Point(12, 82);
            TextEmployeeId.Name = "TextEmployeeId";
            TextEmployeeId.Size = new Size(252, 23);
            TextEmployeeId.TabIndex = 1;
            // 
            // TextFirstName
            // 
            TextFirstName.Location = new Point(12, 130);
            TextFirstName.Name = "TextFirstName";
            TextFirstName.Size = new Size(252, 23);
            TextFirstName.TabIndex = 2;
            // 
            // TextLastName
            // 
            TextLastName.Location = new Point(12, 178);
            TextLastName.Name = "TextLastName";
            TextLastName.Size = new Size(252, 23);
            TextLastName.TabIndex = 3;
            // 
            // TextPosition
            // 
            TextPosition.Location = new Point(12, 226);
            TextPosition.Name = "TextPosition";
            TextPosition.Size = new Size(252, 23);
            TextPosition.TabIndex = 4;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.SlateGray;
            btnAddEmployee.FlatStyle = FlatStyle.Popup;
            btnAddEmployee.Location = new Point(57, 268);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(147, 32);
            btnAddEmployee.TabIndex = 5;
            btnAddEmployee.Text = "Submit";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(155, 22);
            label1.TabIndex = 6;
            label1.Text = "Add Employee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(114, 19);
            label2.TabIndex = 7;
            label2.Text = "Employee ID *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(110, 19);
            label3.TabIndex = 8;
            label3.Text = "First Name * ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 156);
            label4.Name = "label4";
            label4.Size = new Size(106, 19);
            label4.TabIndex = 9;
            label4.Text = "Last Name * ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 204);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 10;
            label5.Text = "Position * ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(270, 21);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 11;
            label6.Text = "Employee List";
            // 
            // frmEmployeeDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(917, 370);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddEmployee);
            Controls.Add(TextPosition);
            Controls.Add(TextLastName);
            Controls.Add(TextFirstName);
            Controls.Add(TextEmployeeId);
            Controls.Add(dataGridView1);
            Name = "frmEmployeeDatabase";
            Text = "Employee Database";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Position;
        private TextBox TextEmployeeId;
        private TextBox TextFirstName;
        private TextBox TextLastName;
        private TextBox TextPosition;
        private Button btnAddEmployee;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
