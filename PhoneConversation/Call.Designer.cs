namespace PhoneConversation
{
    partial class CallForm
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
            this.lbContacts = new System.Windows.Forms.ListBox();
            this.btnStartCall = new System.Windows.Forms.Button();
            this.EndCall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbContacts
            // 
            this.lbContacts.FormattingEnabled = true;
            this.lbContacts.Location = new System.Drawing.Point(22, 34);
            this.lbContacts.Name = "lbContacts";
            this.lbContacts.Size = new System.Drawing.Size(246, 264);
            this.lbContacts.TabIndex = 0;
            // 
            // btnStartCall
            // 
            this.btnStartCall.Location = new System.Drawing.Point(39, 324);
            this.btnStartCall.Name = "btnStartCall";
            this.btnStartCall.Size = new System.Drawing.Size(80, 30);
            this.btnStartCall.TabIndex = 1;
            this.btnStartCall.Text = "Call";
            this.btnStartCall.UseVisualStyleBackColor = true;
            this.btnStartCall.Click += new System.EventHandler(this.btnStartCall_Click);
            // 
            // EndCall
            // 
            this.EndCall.Location = new System.Drawing.Point(144, 324);
            this.EndCall.Name = "EndCall";
            this.EndCall.Size = new System.Drawing.Size(80, 30);
            this.EndCall.TabIndex = 2;
            this.EndCall.Text = "End";
            this.EndCall.UseVisualStyleBackColor = true;
            this.EndCall.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contacts";
            // 
            // CallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 371);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndCall);
            this.Controls.Add(this.btnStartCall);
            this.Controls.Add(this.lbContacts);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CallForm";
            this.Text = "Call";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbContacts;
        private System.Windows.Forms.Button btnStartCall;
        private System.Windows.Forms.Button EndCall;
        private System.Windows.Forms.Label label1;
    }
}