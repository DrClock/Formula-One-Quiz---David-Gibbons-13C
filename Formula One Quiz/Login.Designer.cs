namespace Formula_One_Quiz
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ColourButton1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.TwoPlayerButton = new System.Windows.Forms.Button();
            this.UserCreateTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ColourButton2 = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.UserListBox1 = new System.Windows.Forms.ListBox();
            this.UserListBox2 = new System.Windows.Forms.ListBox();
            this.OnePlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ColourButton1
            // 
            this.ColourButton1.BackColor = System.Drawing.Color.White;
            this.ColourButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ColourButton1.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColourButton1.Location = new System.Drawing.Point(185, 53);
            this.ColourButton1.Name = "ColourButton1";
            this.ColourButton1.Size = new System.Drawing.Size(75, 23);
            this.ColourButton1.TabIndex = 0;
            this.ColourButton1.Text = "Colour";
            this.ColourButton1.UseVisualStyleBackColor = false;
            this.ColourButton1.Click += new System.EventHandler(this.ColourButton1_Click);
            // 
            // TwoPlayerButton
            // 
            this.TwoPlayerButton.BackColor = System.Drawing.Color.White;
            this.TwoPlayerButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.TwoPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TwoPlayerButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoPlayerButton.Location = new System.Drawing.Point(160, 12);
            this.TwoPlayerButton.Name = "TwoPlayerButton";
            this.TwoPlayerButton.Size = new System.Drawing.Size(120, 23);
            this.TwoPlayerButton.TabIndex = 7;
            this.TwoPlayerButton.Text = "Start 2 Player Game";
            this.TwoPlayerButton.UseVisualStyleBackColor = false;
            this.TwoPlayerButton.Visible = false;
            this.TwoPlayerButton.Click += new System.EventHandler(this.TwoPlayerButton_Click);
            // 
            // UserCreateTextBox
            // 
            this.UserCreateTextBox.Location = new System.Drawing.Point(30, 239);
            this.UserCreateTextBox.MaxLength = 20;
            this.UserCreateTextBox.Name = "UserCreateTextBox";
            this.UserCreateTextBox.Size = new System.Drawing.Size(135, 20);
            this.UserCreateTextBox.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(185, 237);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add User";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "New? Create an account!";
            // 
            // ColourButton2
            // 
            this.ColourButton2.BackColor = System.Drawing.Color.White;
            this.ColourButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ColourButton2.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColourButton2.Location = new System.Drawing.Point(185, 139);
            this.ColourButton2.Name = "ColourButton2";
            this.ColourButton2.Size = new System.Drawing.Size(75, 23);
            this.ColourButton2.TabIndex = 2;
            this.ColourButton2.Text = "Colour";
            this.ColourButton2.UseVisualStyleBackColor = false;
            this.ColourButton2.Click += new System.EventHandler(this.ColourButton2_Click);
            // 
            // UserListBox1
            // 
            this.UserListBox1.FormattingEnabled = true;
            this.UserListBox1.Location = new System.Drawing.Point(160, 82);
            this.UserListBox1.Name = "UserListBox1";
            this.UserListBox1.ScrollAlwaysVisible = true;
            this.UserListBox1.Size = new System.Drawing.Size(120, 43);
            this.UserListBox1.TabIndex = 1;
            this.UserListBox1.SelectedValueChanged += new System.EventHandler(this.UserListBox_SelectedValueChanged);
            // 
            // UserListBox2
            // 
            this.UserListBox2.FormattingEnabled = true;
            this.UserListBox2.Location = new System.Drawing.Point(160, 168);
            this.UserListBox2.Name = "UserListBox2";
            this.UserListBox2.ScrollAlwaysVisible = true;
            this.UserListBox2.Size = new System.Drawing.Size(120, 43);
            this.UserListBox2.TabIndex = 3;
            this.UserListBox2.SelectedValueChanged += new System.EventHandler(this.UserListBox_SelectedValueChanged);
            // 
            // OnePlayerButton
            // 
            this.OnePlayerButton.BackColor = System.Drawing.Color.White;
            this.OnePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OnePlayerButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnePlayerButton.Location = new System.Drawing.Point(16, 12);
            this.OnePlayerButton.Name = "OnePlayerButton";
            this.OnePlayerButton.Size = new System.Drawing.Size(132, 23);
            this.OnePlayerButton.TabIndex = 6;
            this.OnePlayerButton.Text = "Start 1 Player Time Trial";
            this.OnePlayerButton.UseVisualStyleBackColor = false;
            this.OnePlayerButton.Visible = false;
            this.OnePlayerButton.Click += new System.EventHandler(this.OnePlayerButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.OnePlayerButton);
            this.Controls.Add(this.UserListBox2);
            this.Controls.Add(this.UserListBox1);
            this.Controls.Add(this.ColourButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.UserCreateTextBox);
            this.Controls.Add(this.TwoPlayerButton);
            this.Controls.Add(this.ColourButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ColourButton1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button TwoPlayerButton;
        private System.Windows.Forms.TextBox UserCreateTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ColourButton2;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ListBox UserListBox1;
        private System.Windows.Forms.ListBox UserListBox2;
        private System.Windows.Forms.Button OnePlayerButton;
    }
}