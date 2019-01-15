namespace PhoneConversation
{
    partial class Registration
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbOperatorsReg = new System.Windows.Forms.ListBox();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTariffs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.AllowDrop = true;
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textName.Location = new System.Drawing.Point(24, 54);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(164, 24);
            this.textName.TabIndex = 0;
            this.textName.WordWrap = false;
            // 
            // textSurname
            // 
            this.textSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSurname.Location = new System.Drawing.Point(231, 54);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(171, 24);
            this.textSurname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(227, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Registration);
            // 
            // lbOperatorsReg
            // 
            this.lbOperatorsReg.AllowDrop = true;
            this.lbOperatorsReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOperatorsReg.FormattingEnabled = true;
            this.lbOperatorsReg.ItemHeight = 16;
            this.lbOperatorsReg.Location = new System.Drawing.Point(24, 105);
            this.lbOperatorsReg.Name = "lbOperatorsReg";
            this.lbOperatorsReg.Size = new System.Drawing.Size(195, 116);
            this.lbOperatorsReg.Sorted = true;
            this.lbOperatorsReg.TabIndex = 6;
            this.lbOperatorsReg.SelectedIndexChanged += new System.EventHandler(this.lbOperatorsReg_SelectedIndexChanged);
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(219, 253);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(100, 20);
            this.tbBalance.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sum of replenishment:";
            // 
            // lbTariffs
            // 
            this.lbTariffs.AllowDrop = true;
            this.lbTariffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTariffs.FormattingEnabled = true;
            this.lbTariffs.ItemHeight = 16;
            this.lbTariffs.Location = new System.Drawing.Point(225, 105);
            this.lbTariffs.Name = "lbTariffs";
            this.lbTariffs.Size = new System.Drawing.Size(195, 116);
            this.lbTariffs.Sorted = true;
            this.lbTariffs.TabIndex = 9;
            // 
            // Registration
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 349);
            this.Controls.Add(this.lbTariffs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.lbOperatorsReg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbOperatorsReg;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbTariffs;
    }
}