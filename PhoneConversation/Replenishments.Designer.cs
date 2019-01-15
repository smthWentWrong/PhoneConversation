namespace PhoneConversation
{
    partial class Replenishments
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
            this.btOkReplenish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbReplenishments = new System.Windows.Forms.ListBox();
            this.numericReplenishmentSum = new System.Windows.Forms.NumericUpDown();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericReplenishmentSum)).BeginInit();
            this.SuspendLayout();
            // 
            // btOkReplenish
            // 
            this.btOkReplenish.Location = new System.Drawing.Point(26, 94);
            this.btOkReplenish.Name = "btOkReplenish";
            this.btOkReplenish.Size = new System.Drawing.Size(78, 26);
            this.btOkReplenish.TabIndex = 0;
            this.btOkReplenish.Text = "Ok";
            this.btOkReplenish.UseVisualStyleBackColor = true;
            this.btOkReplenish.Click += new System.EventHandler(this.btOkReplenish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sum of replenishment:";
            // 
            // lbReplenishments
            // 
            this.lbReplenishments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbReplenishments.FormattingEnabled = true;
            this.lbReplenishments.ItemHeight = 15;
            this.lbReplenishments.Location = new System.Drawing.Point(177, 51);
            this.lbReplenishments.Name = "lbReplenishments";
            this.lbReplenishments.Size = new System.Drawing.Size(230, 244);
            this.lbReplenishments.TabIndex = 3;
            // 
            // numericReplenishmentSum
            // 
            this.numericReplenishmentSum.Location = new System.Drawing.Point(26, 51);
            this.numericReplenishmentSum.Name = "numericReplenishmentSum";
            this.numericReplenishmentSum.Size = new System.Drawing.Size(128, 20);
            this.numericReplenishmentSum.TabIndex = 4;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(26, 153);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(78, 26);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Replenishments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 335);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.numericReplenishmentSum);
            this.Controls.Add(this.lbReplenishments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOkReplenish);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Replenishments";
            this.Text = "Replenishments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Replenishments_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericReplenishmentSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOkReplenish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbReplenishments;
        private System.Windows.Forms.NumericUpDown numericReplenishmentSum;
        private System.Windows.Forms.Button btCancel;
    }
}