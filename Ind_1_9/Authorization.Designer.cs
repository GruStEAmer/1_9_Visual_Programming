namespace Ind_1_9
{
    partial class Authorization
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
            user_text = new TextBox();
            label2 = new Label();
            password_text = new TextBox();
            ok_button = new Button();
            exit_button = new Button();
            label3 = new Label();
            create_user_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(33, 25);
            label1.Name = "label1";
            label1.Size = new Size(55, 28);
            label1.TabIndex = 0;
            label1.Text = "User:";
            // 
            // user_text
            // 
            user_text.Location = new Point(122, 33);
            user_text.Name = "user_text";
            user_text.Size = new Size(135, 23);
            user_text.TabIndex = 1;
            user_text.Click += user_text_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // password_text
            // 
            password_text.Location = new Point(122, 89);
            password_text.Name = "password_text";
            password_text.PasswordChar = '$';
            password_text.Size = new Size(135, 23);
            password_text.TabIndex = 3;
            password_text.UseSystemPasswordChar = true;
            // 
            // ok_button
            // 
            ok_button.Cursor = Cursors.Hand;
            ok_button.Location = new Point(33, 139);
            ok_button.Name = "ok_button";
            ok_button.Size = new Size(83, 40);
            ok_button.TabIndex = 4;
            ok_button.Text = "OK";
            ok_button.UseVisualStyleBackColor = true;
            ok_button.Click += ok_button_Click;
            // 
            // exit_button
            // 
            exit_button.Cursor = Cursors.Hand;
            exit_button.Location = new Point(150, 139);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(83, 40);
            exit_button.TabIndex = 5;
            exit_button.Text = "Exit";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 211);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 6;
            label3.Text = "Are you new here?";
            // 
            // create_user_button
            // 
            create_user_button.Cursor = Cursors.Hand;
            create_user_button.Location = new Point(92, 243);
            create_user_button.Name = "create_user_button";
            create_user_button.Size = new Size(104, 33);
            create_user_button.TabIndex = 7;
            create_user_button.Text = "Create user";
            create_user_button.UseVisualStyleBackColor = true;
            create_user_button.Click += create_user_button_Click;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(282, 327);
            Controls.Add(create_user_button);
            Controls.Add(label3);
            Controls.Add(exit_button);
            Controls.Add(ok_button);
            Controls.Add(password_text);
            Controls.Add(label2);
            Controls.Add(user_text);
            Controls.Add(label1);
            Name = "Authorization";
            Text = "Authorization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox password_text;
        private Button ok_button;
        private Button exit_button;
        private Label label3;
        private Button create_user_button;
        public TextBox user_text;
    }
}
