namespace PhoneConversation
{
    partial class Operators
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
            this.lbOperators = new System.Windows.Forms.ListBox();
            this.btnChangeOp = new System.Windows.Forms.Button();
            this.btnDelOp = new System.Windows.Forms.Button();
            this.btnAddOp = new System.Windows.Forms.Button();
            this.lbOperatorsTariffs = new System.Windows.Forms.ListBox();
            this.btnAddTar = new System.Windows.Forms.Button();
            this.btnDelTar = new System.Windows.Forms.Button();
            this.btnChangeTar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOperators
            // 
            this.lbOperators.FormattingEnabled = true;
            this.lbOperators.Location = new System.Drawing.Point(34, 28);
            this.lbOperators.Name = "lbOperators";
            this.lbOperators.Size = new System.Drawing.Size(218, 147);
            this.lbOperators.Sorted = true;
            this.lbOperators.TabIndex = 0;
            this.lbOperators.SelectedIndexChanged += new System.EventHandler(this.lbOperators_SelectedIndexChanged);
            // 
            // btnChangeOp
            // 
            this.btnChangeOp.Location = new System.Drawing.Point(298, 152);
            this.btnChangeOp.Name = "btnChangeOp";
            this.btnChangeOp.Size = new System.Drawing.Size(75, 23);
            this.btnChangeOp.TabIndex = 6;
            this.btnChangeOp.Text = "Change";
            this.btnChangeOp.UseVisualStyleBackColor = true;
            this.btnChangeOp.Click += new System.EventHandler(this.btnChangeOp_Click);
            // 
            // btnDelOp
            // 
            this.btnDelOp.Location = new System.Drawing.Point(298, 86);
            this.btnDelOp.Name = "btnDelOp";
            this.btnDelOp.Size = new System.Drawing.Size(75, 23);
            this.btnDelOp.TabIndex = 5;
            this.btnDelOp.Text = "Delete";
            this.btnDelOp.UseVisualStyleBackColor = true;
            this.btnDelOp.Click += new System.EventHandler(this.btnDelOp_Click);
            // 
            // btnAddOp
            // 
            this.btnAddOp.Location = new System.Drawing.Point(298, 28);
            this.btnAddOp.Name = "btnAddOp";
            this.btnAddOp.Size = new System.Drawing.Size(75, 23);
            this.btnAddOp.TabIndex = 4;
            this.btnAddOp.Text = "Add";
            this.btnAddOp.UseVisualStyleBackColor = true;
            this.btnAddOp.Click += new System.EventHandler(this.btnAddOp_Click);
            // 
            // lbOperatorsTariffs
            // 
            this.lbOperatorsTariffs.FormattingEnabled = true;
            this.lbOperatorsTariffs.Location = new System.Drawing.Point(34, 246);
            this.lbOperatorsTariffs.Name = "lbOperatorsTariffs";
            this.lbOperatorsTariffs.Size = new System.Drawing.Size(218, 147);
            this.lbOperatorsTariffs.TabIndex = 7;
            // 
            // btnAddTar
            // 
            this.btnAddTar.Location = new System.Drawing.Point(298, 246);
            this.btnAddTar.Name = "btnAddTar";
            this.btnAddTar.Size = new System.Drawing.Size(75, 23);
            this.btnAddTar.TabIndex = 8;
            this.btnAddTar.Text = "Add";
            this.btnAddTar.UseVisualStyleBackColor = true;
            this.btnAddTar.Click += new System.EventHandler(this.btnAddTar_Click);
            // 
            // btnDelTar
            // 
            this.btnDelTar.Location = new System.Drawing.Point(298, 307);
            this.btnDelTar.Name = "btnDelTar";
            this.btnDelTar.Size = new System.Drawing.Size(75, 23);
            this.btnDelTar.TabIndex = 9;
            this.btnDelTar.Text = "Delete";
            this.btnDelTar.UseVisualStyleBackColor = true;
            this.btnDelTar.Click += new System.EventHandler(this.btnDelTar_Click);
            // 
            // btnChangeTar
            // 
            this.btnChangeTar.Location = new System.Drawing.Point(298, 370);
            this.btnChangeTar.Name = "btnChangeTar";
            this.btnChangeTar.Size = new System.Drawing.Size(75, 23);
            this.btnChangeTar.TabIndex = 10;
            this.btnChangeTar.Text = "Change";
            this.btnChangeTar.UseVisualStyleBackColor = true;
            this.btnChangeTar.Click += new System.EventHandler(this.btnChangeTar_Click);
            // 
            // Operators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 438);
            this.Controls.Add(this.btnChangeTar);
            this.Controls.Add(this.btnDelTar);
            this.Controls.Add(this.btnAddTar);
            this.Controls.Add(this.lbOperatorsTariffs);
            this.Controls.Add(this.btnChangeOp);
            this.Controls.Add(this.btnDelOp);
            this.Controls.Add(this.btnAddOp);
            this.Controls.Add(this.lbOperators);
            this.Name = "Operators";
            this.Text = "Operators";
            this.Load += new System.EventHandler(this.Operators_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbOperators;
        private System.Windows.Forms.Button btnChangeOp;
        private System.Windows.Forms.Button btnDelOp;
        private System.Windows.Forms.Button btnAddOp;
        private System.Windows.Forms.ListBox lbOperatorsTariffs;
        private System.Windows.Forms.Button btnAddTar;
        private System.Windows.Forms.Button btnDelTar;
        private System.Windows.Forms.Button btnChangeTar;
    }
}