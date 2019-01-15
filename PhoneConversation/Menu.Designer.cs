namespace PhoneConversation
{
    partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbClient = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.btnReplenishment = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.lbCalls = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBlocks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Contacts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Operators";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnOperators_Click);
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbClient.Location = new System.Drawing.Point(187, 17);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(0, 16);
            this.lbClient.TabIndex = 2;
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBalance.Location = new System.Drawing.Point(22, 17);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(0, 16);
            this.lbBalance.TabIndex = 3;
            // 
            // btnReplenishment
            // 
            this.btnReplenishment.Location = new System.Drawing.Point(12, 215);
            this.btnReplenishment.Name = "btnReplenishment";
            this.btnReplenishment.Size = new System.Drawing.Size(104, 49);
            this.btnReplenishment.TabIndex = 4;
            this.btnReplenishment.Text = "Replenish";
            this.btnReplenishment.UseVisualStyleBackColor = true;
            this.btnReplenishment.Click += new System.EventHandler(this.btnReplenishment_Click);
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(12, 294);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(104, 48);
            this.btnCall.TabIndex = 5;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // lbCalls
            // 
            this.lbCalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCalls.FormattingEnabled = true;
            this.lbCalls.HorizontalScrollbar = true;
            this.lbCalls.ItemHeight = 16;
            this.lbCalls.Location = new System.Drawing.Point(122, 82);
            this.lbCalls.Name = "lbCalls";
            this.lbCalls.Size = new System.Drawing.Size(288, 260);
            this.lbCalls.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(238, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "List of calls:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(458, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "List of blocks:";
            // 
            // lbBlocks
            // 
            this.lbBlocks.FormattingEnabled = true;
            this.lbBlocks.HorizontalScrollbar = true;
            this.lbBlocks.Location = new System.Drawing.Point(416, 82);
            this.lbBlocks.Name = "lbBlocks";
            this.lbBlocks.Size = new System.Drawing.Size(244, 186);
            this.lbBlocks.TabIndex = 9;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 368);
            this.Controls.Add(this.lbBlocks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCalls);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.btnReplenishment);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Button btnReplenishment;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.ListBox lbCalls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbBlocks;
    }
}

