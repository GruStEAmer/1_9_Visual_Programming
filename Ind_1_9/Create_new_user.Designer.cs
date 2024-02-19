namespace Ind_1_9
{
    partial class Create_new_user
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            user_textBox = new TextBox();
            password_textBox = new TextBox();
            Confirm_password_textBox = new TextBox();
            create_button = new Button();
            cancel_button = new Button();
            password_checkBox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(44, 48);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(12, 152);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
            label2.TabIndex = 1;
            label2.Text = "Confirm password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(48, 104);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // user_textBox
            // 
            user_textBox.Location = new Point(181, 48);
            user_textBox.Name = "user_textBox";
            user_textBox.Size = new Size(173, 23);
            user_textBox.TabIndex = 3;
            user_textBox.Click += user_textBox_Click;
            // 
            // password_textBox
            // 
            password_textBox.Location = new Point(181, 107);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(173, 23);
            password_textBox.TabIndex = 4;
            password_textBox.UseSystemPasswordChar = true;
            // 
            // Confirm_password_textBox
            // 
            Confirm_password_textBox.Location = new Point(181, 155);
            Confirm_password_textBox.Name = "Confirm_password_textBox";
            Confirm_password_textBox.Size = new Size(173, 23);
            Confirm_password_textBox.TabIndex = 5;
            Confirm_password_textBox.UseSystemPasswordChar = true;
            // 
            // create_button
            // 
            create_button.Font = new Font("Segoe UI", 13F);
            create_button.Location = new Point(48, 222);
            create_button.Name = "create_button";
            create_button.Size = new Size(114, 30);
            create_button.TabIndex = 6;
            create_button.Text = "Create";
            create_button.UseVisualStyleBackColor = true;
            create_button.Click += create_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Font = new Font("Segoe UI", 13F);
            cancel_button.Location = new Point(204, 222);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(114, 30);
            cancel_button.TabIndex = 7;
            cancel_button.Text = "Cancel";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // password_checkBox
            // 
            password_checkBox.AutoSize = true;
            password_checkBox.Location = new Point(181, 184);
            password_checkBox.Name = "password_checkBox";
            password_checkBox.Size = new Size(119, 19);
            password_checkBox.TabIndex = 8;
            password_checkBox.Text = "Показать пароль";
            password_checkBox.UseVisualStyleBackColor = true;
            password_checkBox.CheckedChanged += password_checkBox_CheckedChanged;
            // 
            // Create_new_user
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(388, 277);
            Controls.Add(password_checkBox);
            Controls.Add(cancel_button);
            Controls.Add(create_button);
            Controls.Add(Confirm_password_textBox);
            Controls.Add(password_textBox);
            Controls.Add(user_textBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Create_new_user";
            Text = "Create New User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox user_textBox;
        private TextBox password_textBox;
        private TextBox Confirm_password_textBox;
        private Button create_button;
        private Button cancel_button;
        private CheckBox password_checkBox;
    }
}