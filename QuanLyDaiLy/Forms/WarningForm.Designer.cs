namespace QuanLyDaiLy.Forms
{
    partial class WarningForm
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
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitle.SuspendLayout();
            this.panelDescription.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(539, 5);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(139, 46);
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.Text = "Xác nhận";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // panelTitle
            // 
            this.panelTitle.AutoSize = true;
            this.panelTitle.Controls.Add(this.Title);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(690, 33);
            this.panelTitle.TabIndex = 3;
            // 
            // panelDescription
            // 
            this.panelDescription.AutoSize = true;
            this.panelDescription.Controls.Add(this.label1);
            this.panelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDescription.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDescription.Location = new System.Drawing.Point(0, 33);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(690, 270);
            this.panelDescription.TabIndex = 4;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title.Location = new System.Drawing.Point(39, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(121, 33);
            this.Title.TabIndex = 0;
            this.Title.Text = "Cảnh báo";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xác nhận xóa đại lý này?";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.ConfirmButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 54);
            this.panel1.TabIndex = 5;
            // 
            // WarningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 303);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDescription);
            this.Controls.Add(this.panelTitle);
            this.Name = "WarningForm";
            this.Text = "WarningForm";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}