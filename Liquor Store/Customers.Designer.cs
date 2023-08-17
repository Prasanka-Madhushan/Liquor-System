
namespace Liquor_Store
{
    partial class CustomerTbl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CustomerDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.HomeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 56);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(824, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 34);
            this.label3.TabIndex = 30;
            this.label3.Text = "Customer List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(834, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 561);
            this.panel4.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 561);
            this.panel3.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 561);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 10);
            this.panel2.TabIndex = 27;
            // 
            // CustomerDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.CustomerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CustomerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDGV.BackgroundColor = System.Drawing.Color.White;
            this.CustomerDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CustomerDGV.ColumnHeadersHeight = 20;
            this.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.CustomerDGV.EnableHeadersVisualStyles = false;
            this.CustomerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDGV.Location = new System.Drawing.Point(28, 237);
            this.CustomerDGV.Name = "CustomerDGV";
            this.CustomerDGV.RowHeadersVisible = false;
            this.CustomerDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CustomerDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerDGV.Size = new System.Drawing.Size(788, 310);
            this.CustomerDGV.TabIndex = 26;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomerDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CustomerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CustomerDGV.ThemeStyle.HeaderStyle.Height = 20;
            this.CustomerDGV.ThemeStyle.ReadOnly = false;
            this.CustomerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerDGV.ThemeStyle.RowsStyle.Height = 22;
            this.CustomerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.BorderRadius = 20;
            this.HomeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeBtn.FillColor = System.Drawing.Color.White;
            this.HomeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.HomeBtn.ForeColor = System.Drawing.Color.Red;
            this.HomeBtn.Location = new System.Drawing.Point(662, 134);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.PressedColor = System.Drawing.Color.Red;
            this.HomeBtn.PressedDepth = 50;
            this.HomeBtn.Size = new System.Drawing.Size(114, 39);
            this.HomeBtn.TabIndex = 25;
            this.HomeBtn.Text = "HOME";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.BorderRadius = 20;
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.FillColor = System.Drawing.Color.White;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.ForeColor = System.Drawing.Color.Red;
            this.DeleteBtn.Location = new System.Drawing.Point(453, 134);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.PressedColor = System.Drawing.Color.Red;
            this.DeleteBtn.PressedDepth = 50;
            this.DeleteBtn.Size = new System.Drawing.Size(114, 39);
            this.DeleteBtn.TabIndex = 24;
            this.DeleteBtn.Text = "DELETE";
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditBtn.BorderRadius = 20;
            this.EditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditBtn.FillColor = System.Drawing.Color.White;
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.EditBtn.ForeColor = System.Drawing.Color.Red;
            this.EditBtn.Location = new System.Drawing.Point(261, 134);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.PressedColor = System.Drawing.Color.Red;
            this.EditBtn.PressedDepth = 50;
            this.EditBtn.Size = new System.Drawing.Size(114, 39);
            this.EditBtn.TabIndex = 23;
            this.EditBtn.Text = "EDIT";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.BorderRadius = 20;
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.FillColor = System.Drawing.Color.White;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.AddBtn.ForeColor = System.Drawing.Color.Red;
            this.AddBtn.Location = new System.Drawing.Point(55, 134);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.PressedColor = System.Drawing.Color.Red;
            this.AddBtn.PressedDepth = 50;
            this.AddBtn.Size = new System.Drawing.Size(114, 39);
            this.AddBtn.TabIndex = 22;
            this.AddBtn.Text = "ADD";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.BackColor = System.Drawing.Color.Transparent;
            this.CustomerPhone.BorderColor = System.Drawing.Color.White;
            this.CustomerPhone.BorderRadius = 10;
            this.CustomerPhone.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.CustomerPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerPhone.DefaultText = "";
            this.CustomerPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerPhone.FillColor = System.Drawing.Color.Black;
            this.CustomerPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CustomerPhone.ForeColor = System.Drawing.Color.White;
            this.CustomerPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerPhone.Location = new System.Drawing.Point(628, 73);
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.PasswordChar = '\0';
            this.CustomerPhone.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.CustomerPhone.PlaceholderText = "Customer Phone";
            this.CustomerPhone.SelectedText = "";
            this.CustomerPhone.Size = new System.Drawing.Size(173, 35);
            this.CustomerPhone.TabIndex = 21;
            // 
            // CustomerName
            // 
            this.CustomerName.BackColor = System.Drawing.Color.Transparent;
            this.CustomerName.BorderColor = System.Drawing.Color.White;
            this.CustomerName.BorderRadius = 10;
            this.CustomerName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.CustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerName.DefaultText = "";
            this.CustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerName.FillColor = System.Drawing.Color.Black;
            this.CustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CustomerName.ForeColor = System.Drawing.Color.White;
            this.CustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerName.Location = new System.Drawing.Point(328, 73);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.PasswordChar = '\0';
            this.CustomerName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.CustomerName.PlaceholderText = "Customer Name";
            this.CustomerName.SelectedText = "";
            this.CustomerName.Size = new System.Drawing.Size(173, 35);
            this.CustomerName.TabIndex = 19;
            // 
            // CustomerID
            // 
            this.CustomerID.BackColor = System.Drawing.Color.Transparent;
            this.CustomerID.BorderColor = System.Drawing.Color.White;
            this.CustomerID.BorderRadius = 10;
            this.CustomerID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.CustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerID.DefaultText = "";
            this.CustomerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerID.FillColor = System.Drawing.Color.Black;
            this.CustomerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CustomerID.ForeColor = System.Drawing.Color.White;
            this.CustomerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerID.Location = new System.Drawing.Point(28, 73);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.PasswordChar = '\0';
            this.CustomerID.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.CustomerID.PlaceholderText = "Customer ID";
            this.CustomerID.SelectedText = "";
            this.CustomerID.Size = new System.Drawing.Size(173, 35);
            this.CustomerID.TabIndex = 18;
            // 
            // CustomerTbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CustomerDGV);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CustomerPhone);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.CustomerID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerTbl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerDGV;
        private Guna.UI2.WinForms.Guna2Button HomeBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2TextBox CustomerPhone;
        private Guna.UI2.WinForms.Guna2TextBox CustomerName;
        private Guna.UI2.WinForms.Guna2TextBox CustomerID;
    }
}