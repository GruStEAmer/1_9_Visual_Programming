namespace Ind_1_9
{
    partial class User_informations
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
            logout_button = new Button();
            label1 = new Label();
            exit_button = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            name_textBox = new TextBox();
            last_name_textBox = new TextBox();
            email_textBox = new TextBox();
            name_button = new Button();
            last_name_button = new Button();
            email_button = new Button();
            SuspendLayout();
            // 
            // logout_button
            // 
            logout_button.Font = new Font("Segoe UI", 14F);
            logout_button.Location = new Point(58, 201);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(115, 37);
            logout_button.TabIndex = 1;
            logout_button.Text = "Loguot";
            logout_button.UseVisualStyleBackColor = true;
            logout_button.Click += logout_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 40);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // exit_button
            // 
            exit_button.Font = new Font("Segoe UI", 14F);
            exit_button.Location = new Point(274, 201);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(115, 37);
            exit_button.TabIndex = 4;
            exit_button.Text = "Exit";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(59, 66);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 5;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(58, 101);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 6;
            label3.Text = "Last name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(59, 140);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 7;
            label4.Text = "email:";
            // 
            // name_textBox
            // 
            name_textBox.Location = new Point(186, 68);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(203, 23);
            name_textBox.TabIndex = 8;
            // 
            // last_name_textBox
            // 
            last_name_textBox.Location = new Point(186, 106);
            last_name_textBox.Name = "last_name_textBox";
            last_name_textBox.Size = new Size(203, 23);
            last_name_textBox.TabIndex = 9;
            // 
            // email_textBox
            // 
            email_textBox.Location = new Point(186, 145);
            email_textBox.Name = "email_textBox";
            email_textBox.Size = new Size(203, 23);
            email_textBox.TabIndex = 10;
            // 
            // name_button
            // 
            name_button.Font = new Font("Segoe UI", 10F);
            name_button.Location = new Point(404, 68);
            name_button.Name = "name_button";
            name_button.Size = new Size(63, 23);
            name_button.TabIndex = 11;
            name_button.Text = "<-Edit";
            name_button.UseVisualStyleBackColor = true;
            name_button.Click += name_button_Click;
            // 
            // last_name_button
            // 
            last_name_button.Font = new Font("Segoe UI", 10F);
            last_name_button.Location = new Point(404, 106);
            last_name_button.Name = "last_name_button";
            last_name_button.Size = new Size(63, 23);
            last_name_button.TabIndex = 12;
            last_name_button.Text = "<-Edit";
            last_name_button.UseVisualStyleBackColor = true;
            last_name_button.Click += last_name_button_Click;
            // 
            // email_button
            // 
            email_button.Font = new Font("Segoe UI", 10F);
            email_button.Location = new Point(404, 145);
            email_button.Name = "email_button";
            email_button.Size = new Size(63, 23);
            email_button.TabIndex = 13;
            email_button.Text = "<-Edit";
            email_button.UseVisualStyleBackColor = true;
            email_button.Click += email_button_Click;
            // 
            // User_informations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(491, 267);
            Controls.Add(email_button);
            Controls.Add(last_name_button);
            Controls.Add(name_button);
            Controls.Add(email_textBox);
            Controls.Add(last_name_textBox);
            Controls.Add(name_textBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit_button);
            Controls.Add(label1);
            Controls.Add(logout_button);
            Name = "User_informations";
            Text = "User informations";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button logout_button;
        private Label label1;
        private Button exit_button;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox name_textBox;
        private TextBox last_name_textBox;
        private TextBox email_textBox;
        private Button name_button;
        private Button last_name_button;
        private Button email_button;
    }
}