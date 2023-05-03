namespace GuiBuilder_week2
{
    partial class RegistrationForm
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
            openingLabel = new Label();
            buttonRegister = new Button();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            pictureBox1 = new PictureBox();
            labelUsername = new Label();
            labelPassword = new Label();
            labelRegistered = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // openingLabel
            // 
            openingLabel.AutoSize = true;
            openingLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            openingLabel.Location = new Point(394, 66);
            openingLabel.Name = "openingLabel";
            openingLabel.Size = new Size(214, 26);
            openingLabel.TabIndex = 0;
            openingLabel.Text = "Welcome to the Site.";
            // 
            // buttonRegister
            // 
            buttonRegister.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegister.Location = new Point(450, 241);
            buttonRegister.Margin = new Padding(3, 2, 3, 2);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(174, 25);
            buttonRegister.TabIndex = 1;
            buttonRegister.Text = "register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click_1;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(422, 141);
            textBoxUsername.Margin = new Padding(3, 2, 3, 2);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(203, 23);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(422, 186);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(203, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new Point(33, 66);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(422, 124);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(63, 15);
            labelUsername.TabIndex = 5;
            labelUsername.Text = "username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(422, 169);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(60, 15);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "password";
            // 
            // labelRegistered
            // 
            labelRegistered.AutoSize = true;
            labelRegistered.BackColor = SystemColors.Control;
            labelRegistered.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegistered.ForeColor = SystemColors.ActiveCaptionText;
            labelRegistered.Location = new Point(450, 283);
            labelRegistered.Name = "labelRegistered";
            labelRegistered.Size = new Size(175, 17);
            labelRegistered.TabIndex = 7;
            labelRegistered.Text = "you are not registered yet.";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(labelRegistered);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonRegister);
            Controls.Add(openingLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistrationForm";
            Text = "Registration Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label openingLabel;
        private Button buttonRegister;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private PictureBox pictureBox1;
        private Label labelUsername;
        private Label labelPassword;
        private Label labelRegistered;
    }
}