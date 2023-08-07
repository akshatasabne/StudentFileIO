namespace StudentFileIO
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
            this.labelNo = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labPercentage = new System.Windows.Forms.Label();
            this.textNo = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPercentage = new System.Windows.Forms.TextBox();
            this.butWrite = new System.Windows.Forms.Button();
            this.butRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.Location = new System.Drawing.Point(75, 69);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(52, 16);
            this.labelNo.TabIndex = 0;
            this.labelNo.Text = "Roll No";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(75, 139);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labPercentage
            // 
            this.labPercentage.AutoSize = true;
            this.labPercentage.Location = new System.Drawing.Point(75, 203);
            this.labPercentage.Name = "labPercentage";
            this.labPercentage.Size = new System.Drawing.Size(77, 16);
            this.labPercentage.TabIndex = 2;
            this.labPercentage.Text = "Percentage";
            // 
            // textNo
            // 
            this.textNo.Location = new System.Drawing.Point(208, 69);
            this.textNo.Name = "textNo";
            this.textNo.Size = new System.Drawing.Size(159, 22);
            this.textNo.TabIndex = 3;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(208, 139);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(159, 22);
            this.textName.TabIndex = 4;
            // 
            // textPercentage
            // 
            this.textPercentage.Location = new System.Drawing.Point(208, 203);
            this.textPercentage.Name = "textPercentage";
            this.textPercentage.Size = new System.Drawing.Size(159, 22);
            this.textPercentage.TabIndex = 5;
            // 
            // butWrite
            // 
            this.butWrite.Location = new System.Drawing.Point(77, 306);
            this.butWrite.Name = "butWrite";
            this.butWrite.Size = new System.Drawing.Size(75, 40);
            this.butWrite.TabIndex = 6;
            this.butWrite.Text = "Write";
            this.butWrite.UseVisualStyleBackColor = true;
            this.butWrite.Click += new System.EventHandler(this.butWrite_Click);
            // 
            // butRead
            // 
            this.butRead.Location = new System.Drawing.Point(241, 306);
            this.butRead.Name = "butRead";
            this.butRead.Size = new System.Drawing.Size(75, 40);
            this.butRead.TabIndex = 7;
            this.butRead.Text = "Read";
            this.butRead.UseVisualStyleBackColor = true;
            this.butRead.Click += new System.EventHandler(this.butRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butRead);
            this.Controls.Add(this.butWrite);
            this.Controls.Add(this.textPercentage);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textNo);
            this.Controls.Add(this.labPercentage);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelNo);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labPercentage;
        private System.Windows.Forms.TextBox textNo;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPercentage;
        private System.Windows.Forms.Button butWrite;
        private System.Windows.Forms.Button butRead;
    }
}

