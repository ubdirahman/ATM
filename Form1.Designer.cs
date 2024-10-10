namespace ATM
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
            this.components = new System.ComponentModel.Container();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.depositbtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.balancetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.depositetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.withdrawbtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.widthrawtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // depositbtn
            // 
            this.depositbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.depositbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.depositbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.depositbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.depositbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.depositbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.depositbtn.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositbtn.ForeColor = System.Drawing.Color.White;
            this.depositbtn.Location = new System.Drawing.Point(107, 279);
            this.depositbtn.Name = "depositbtn";
            this.depositbtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.depositbtn.Size = new System.Drawing.Size(221, 201);
            this.depositbtn.TabIndex = 0;
            this.depositbtn.Text = "Deposite";
            this.depositbtn.Click += new System.EventHandler(this.depositbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "balance:";
            // 
            // balancetxt
            // 
            this.balancetxt.AutoRoundedCorners = true;
            this.balancetxt.BorderColor = System.Drawing.Color.Black;
            this.balancetxt.BorderRadius = 29;
            this.balancetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.balancetxt.DefaultText = "";
            this.balancetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.balancetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.balancetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.balancetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.balancetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.balancetxt.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancetxt.ForeColor = System.Drawing.Color.Black;
            this.balancetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.balancetxt.Location = new System.Drawing.Point(351, 14);
            this.balancetxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.balancetxt.Name = "balancetxt";
            this.balancetxt.PasswordChar = '\0';
            this.balancetxt.PlaceholderText = "";
            this.balancetxt.SelectedText = "";
            this.balancetxt.Size = new System.Drawing.Size(286, 60);
            this.balancetxt.TabIndex = 3;
            // 
            // depositetxt
            // 
            this.depositetxt.AutoRoundedCorners = true;
            this.depositetxt.BorderColor = System.Drawing.Color.Black;
            this.depositetxt.BorderRadius = 29;
            this.depositetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.depositetxt.DefaultText = "";
            this.depositetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.depositetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.depositetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.depositetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.depositetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.depositetxt.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.depositetxt.ForeColor = System.Drawing.Color.Black;
            this.depositetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.depositetxt.Location = new System.Drawing.Point(82, 156);
            this.depositetxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depositetxt.Name = "depositetxt";
            this.depositetxt.PasswordChar = '\0';
            this.depositetxt.PlaceholderText = "";
            this.depositetxt.SelectedText = "";
            this.depositetxt.Size = new System.Drawing.Size(301, 60);
            this.depositetxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(856, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // withdrawbtn
            // 
            this.withdrawbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.withdrawbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.withdrawbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.withdrawbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.withdrawbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.withdrawbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.withdrawbtn.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.withdrawbtn.ForeColor = System.Drawing.Color.White;
            this.withdrawbtn.Location = new System.Drawing.Point(552, 279);
            this.withdrawbtn.Name = "withdrawbtn";
            this.withdrawbtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.withdrawbtn.Size = new System.Drawing.Size(221, 201);
            this.withdrawbtn.TabIndex = 1;
            this.withdrawbtn.Text = "Withdraw";
            this.withdrawbtn.Click += new System.EventHandler(this.withdrawbtn_Click);
            // 
            // widthrawtxt
            // 
            this.widthrawtxt.AutoRoundedCorners = true;
            this.widthrawtxt.BorderColor = System.Drawing.Color.Black;
            this.widthrawtxt.BorderRadius = 29;
            this.widthrawtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.widthrawtxt.DefaultText = "";
            this.widthrawtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.widthrawtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.widthrawtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.widthrawtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.widthrawtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.widthrawtxt.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthrawtxt.ForeColor = System.Drawing.Color.Black;
            this.widthrawtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.widthrawtxt.Location = new System.Drawing.Point(512, 156);
            this.widthrawtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.widthrawtxt.Name = "widthrawtxt";
            this.widthrawtxt.PasswordChar = '\0';
            this.widthrawtxt.PlaceholderText = "";
            this.widthrawtxt.SelectedText = "";
            this.widthrawtxt.Size = new System.Drawing.Size(314, 60);
            this.widthrawtxt.TabIndex = 4;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.Red;
            this.guna2Button1.BorderRadius = 30;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(363, 510);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(154, 63);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "EXIT";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(889, 614);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depositetxt);
            this.Controls.Add(this.widthrawtxt);
            this.Controls.Add(this.balancetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.withdrawbtn);
            this.Controls.Add(this.depositbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2CircleButton depositbtn;
        private Guna.UI2.WinForms.Guna2TextBox balancetxt;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox depositetxt;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox widthrawtxt;
        private Guna.UI2.WinForms.Guna2CircleButton withdrawbtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

