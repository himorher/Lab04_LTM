namespace ltm_lab4
{
    partial class Bai5
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
            label_page = new Label();
            label_usr_page = new Label();
            label_tol_page = new Label();
            label_tol_user = new Label();
            label1 = new Label();
            button_back = new Button();
            button_next = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label_page
            // 
            label_page.AutoSize = true;
            label_page.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_page.Location = new Point(12, 10);
            label_page.Name = "label_page";
            label_page.Size = new Size(59, 19);
            label_page.TabIndex = 1;
            label_page.Text = "Page: ";
            // 
            // label_usr_page
            // 
            label_usr_page.AutoSize = true;
            label_usr_page.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_usr_page.Location = new Point(12, 39);
            label_usr_page.Name = "label_usr_page";
            label_usr_page.Size = new Size(117, 21);
            label_usr_page.TabIndex = 2;
            label_usr_page.Text = "User/ Page: ";
            // 
            // label_tol_page
            // 
            label_tol_page.AutoSize = true;
            label_tol_page.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_tol_page.Location = new Point(178, 10);
            label_tol_page.Name = "label_tol_page";
            label_tol_page.Size = new Size(113, 21);
            label_tol_page.TabIndex = 3;
            label_tol_page.Text = "Total Page: ";
            // 
            // label_tol_user
            // 
            label_tol_user.AutoSize = true;
            label_tol_user.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_tol_user.Location = new Point(178, 39);
            label_tol_user.Name = "label_tol_user";
            label_tol_user.Size = new Size(120, 21);
            label_tol_user.TabIndex = 4;
            label_tol_user.Text = "Total Users: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(854, 18);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 5;
            label1.Text = "User List";
            // 
            // button_back
            // 
            button_back.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_back.Location = new Point(801, 10);
            button_back.Name = "button_back";
            button_back.Size = new Size(47, 38);
            button_back.TabIndex = 6;
            button_back.Text = "<<";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_next
            // 
            button_next.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_next.Location = new Point(947, 10);
            button_next.Name = "button_next";
            button_next.Size = new Size(47, 38);
            button_next.TabIndex = 7;
            button_next.Text = ">>";
            button_next.UseVisualStyleBackColor = true;
            button_next.Click += button_next_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 71);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(982, 601);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 684);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button_next);
            Controls.Add(button_back);
            Controls.Add(label1);
            Controls.Add(label_tol_user);
            Controls.Add(label_tol_page);
            Controls.Add(label_usr_page);
            Controls.Add(label_page);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Bai5";
            Text = "Bai5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_page;
        private Label label_usr_page;
        private Label label_tol_page;
        private Label label_tol_user;
        private Label label1;
        private Button button_back;
        private Button button_next;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}