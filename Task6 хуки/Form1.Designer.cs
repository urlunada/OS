namespace Task6_dll
{
    partial class Form1
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
            btnInstall = new Button();
            btnUninstall = new Button();
            lblInfo = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // btnInstall
            // 
            btnInstall.Location = new Point(65, 108);
            btnInstall.Name = "btnInstall";
            btnInstall.Size = new Size(185, 34);
            btnInstall.TabIndex = 0;
            btnInstall.Text = "Установить хук";
            btnInstall.UseVisualStyleBackColor = true;
            btnInstall.Click += btnInstall_Click;
            // 
            // btnUninstall
            // 
            btnUninstall.Location = new Point(65, 217);
            btnUninstall.Name = "btnUninstall";
            btnUninstall.Size = new Size(185, 34);
            btnUninstall.TabIndex = 1;
            btnUninstall.Text = "Удалить хук";
            btnUninstall.UseVisualStyleBackColor = true;
            btnUninstall.Click += btnUninstall_Click;
            // 
            // lblInfo
            // 
            lblInfo.BackColor = SystemColors.ActiveCaption;
            lblInfo.Location = new Point(298, 96);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(220, 62);
            lblInfo.TabIndex = 2;
            lblInfo.Text = " ";
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(298, 222);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(233, 37);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Статус: Хук не установлен";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 482);
            Controls.Add(lblStatus);
            Controls.Add(lblInfo);
            Controls.Add(btnUninstall);
            Controls.Add(btnInstall);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInstall;
        private Button btnUninstall;
        private Label lblInfo;
        private Label lblStatus;
    }
}
