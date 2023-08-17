
namespace Liquor_Store
{
    partial class User
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UnameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.FullnameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.PwdTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.TeleTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HomeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UserDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 56);
            this.panel1.TabIndex = 0;
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UnameTb
            // 
            this.UnameTb.BackColor = System.Drawing.Color.Transparent;
            this.UnameTb.BorderColor = System.Drawing.Color.White;
            this.UnameTb.BorderRadius = 10;
            this.UnameTb.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.UnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UnameTb.DefaultText = "";
            this.UnameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UnameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UnameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UnameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UnameTb.FillColor = System.Drawing.Color.Black;
            this.UnameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UnameTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.UnameTb.ForeColor = System.Drawing.Color.White;
            this.UnameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UnameTb.Location = new System.Drawing.Point(28, 73);
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.PasswordChar = '\0';
            this.UnameTb.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.UnameTb.PlaceholderText = "User Name";
            this.UnameTb.SelectedText = "";
            this.UnameTb.Size = new System.Drawing.Size(173, 35);
            this.UnameTb.TabIndex = 3;
            // 
            // FullnameTb
            // 
            this.FullnameTb.BackColor = System.Drawing.Color.Transparent;
            this.FullnameTb.BorderColor = System.Drawing.Color.White;
            this.FullnameTb.BorderRadius = 10;
            this.FullnameTb.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.FullnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FullnameTb.DefaultText = "";
            this.FullnameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FullnameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FullnameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FullnameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FullnameTb.FillColor = System.Drawing.Color.Black;
            this.FullnameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FullnameTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.FullnameTb.ForeColor = System.Drawing.Color.White;
            this.FullnameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FullnameTb.Location = new System.Drawing.Point(230, 73);
            this.FullnameTb.Name = "FullnameTb";
            this.FullnameTb.PasswordChar = '\0';
            this.FullnameTb.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.FullnameTb.PlaceholderText = "Full Name";
            this.FullnameTb.SelectedText = "";
            this.FullnameTb.Size = new System.Drawing.Size(173, 35);
            this.FullnameTb.TabIndex = 4;
            // 
            // PwdTb
            // 
            this.PwdTb.BackColor = System.Drawing.Color.Transparent;
            this.PwdTb.BorderColor = System.Drawing.Color.White;
            this.PwdTb.BorderRadius = 10;
            this.PwdTb.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.PwdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PwdTb.DefaultText = "";
            this.PwdTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PwdTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PwdTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PwdTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PwdTb.FillColor = System.Drawing.Color.Black;
            this.PwdTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PwdTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.PwdTb.ForeColor = System.Drawing.Color.White;
            this.PwdTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PwdTb.Location = new System.Drawing.Point(427, 73);
            this.PwdTb.Name = "PwdTb";
            this.PwdTb.PasswordChar = '\0';
            this.PwdTb.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.PwdTb.PlaceholderText = "Password";
            this.PwdTb.SelectedText = "";
            this.PwdTb.Size = new System.Drawing.Size(173, 35);
            this.PwdTb.TabIndex = 5;
            // 
            // TeleTb
            // 
            this.TeleTb.BackColor = System.Drawing.Color.Transparent;
            this.TeleTb.BorderColor = System.Drawing.Color.White;
            this.TeleTb.BorderRadius = 10;
            this.TeleTb.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.TeleTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TeleTb.DefaultText = "";
            this.TeleTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TeleTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TeleTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TeleTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TeleTb.FillColor = System.Drawing.Color.Black;
            this.TeleTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TeleTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TeleTb.ForeColor = System.Drawing.Color.White;
            this.TeleTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TeleTb.Location = new System.Drawing.Point(628, 73);
            this.TeleTb.Name = "TeleTb";
            this.TeleTb.PasswordChar = '\0';
            this.TeleTb.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TeleTb.PlaceholderText = "Mobile No";
            this.TeleTb.SelectedText = "";
            this.TeleTb.Size = new System.Drawing.Size(173, 35);
            this.TeleTb.TabIndex = 6;
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
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "ADD";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
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
            this.EditBtn.TabIndex = 9;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
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
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            this.HomeBtn.TabIndex = 11;
            this.HomeBtn.Text = "HOME";
            // 
            // UserDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.UserDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDGV.BackgroundColor = System.Drawing.Color.White;
            this.UserDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserDGV.ColumnHeadersHeight = 20;
            this.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserDGV.EnableHeadersVisualStyles = false;
            this.UserDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDGV.Location = new System.Drawing.Point(28, 237);
            this.UserDGV.Name = "UserDGV";
            this.UserDGV.RowHeadersVisible = false;
            this.UserDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UserDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDGV.Size = new System.Drawing.Size(788, 310);
            this.UserDGV.TabIndex = 12;
            this.UserDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.UserDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UserDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UserDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UserDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UserDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UserDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.UserDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UserDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UserDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UserDGV.ThemeStyle.HeaderStyle.Height = 20;
            this.UserDGV.ThemeStyle.ReadOnly = false;
            this.UserDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UserDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.UserDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UserDGV.ThemeStyle.RowsStyle.Height = 22;
            this.UserDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UserDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDGV_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 561);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 10);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 505);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(834, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 505);
            this.panel4.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "Users List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(844, 571);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UserDGV);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.TeleTb);
            this.Controls.Add(this.PwdTb);
            this.Controls.Add(this.FullnameTb);
            this.Controls.Add(this.UnameTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox UnameTb;
        private Guna.UI2.WinForms.Guna2TextBox FullnameTb;
        private Guna.UI2.WinForms.Guna2TextBox PwdTb;
        private Guna.UI2.WinForms.Guna2TextBox TeleTb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button HomeBtn;
        private Guna.UI2.WinForms.Guna2DataGridView UserDGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
    }
}