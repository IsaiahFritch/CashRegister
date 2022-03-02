namespace CashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.feralCatsLabel = new System.Windows.Forms.Label();
            this.feralCatInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.jellyBeanLabel = new System.Windows.Forms.Label();
            this.rockLabel = new System.Windows.Forms.Label();
            this.jellyInput = new System.Windows.Forms.TextBox();
            this.rockInput = new System.Windows.Forms.TextBox();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.receiptOutput2 = new System.Windows.Forms.Label();
            this.previousSaleOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 511);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // feralCatsLabel
            // 
            this.feralCatsLabel.AutoSize = true;
            this.feralCatsLabel.BackColor = System.Drawing.Color.Transparent;
            this.feralCatsLabel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feralCatsLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.feralCatsLabel.Location = new System.Drawing.Point(29, 64);
            this.feralCatsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.feralCatsLabel.Name = "feralCatsLabel";
            this.feralCatsLabel.Size = new System.Drawing.Size(69, 18);
            this.feralCatsLabel.TabIndex = 1;
            this.feralCatsLabel.Text = "Feral Cat";
            this.feralCatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // feralCatInput
            // 
            this.feralCatInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.feralCatInput.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feralCatInput.ForeColor = System.Drawing.Color.Snow;
            this.feralCatInput.Location = new System.Drawing.Point(158, 64);
            this.feralCatInput.Margin = new System.Windows.Forms.Padding(2);
            this.feralCatInput.Name = "feralCatInput";
            this.feralCatInput.Size = new System.Drawing.Size(34, 20);
            this.feralCatInput.TabIndex = 2;
            this.feralCatInput.Text = "0";
            this.feralCatInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.DarkGray;
            this.calculateButton.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateButton.Location = new System.Drawing.Point(57, 153);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(102, 22);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // jellyBeanLabel
            // 
            this.jellyBeanLabel.AutoSize = true;
            this.jellyBeanLabel.BackColor = System.Drawing.Color.Transparent;
            this.jellyBeanLabel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jellyBeanLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.jellyBeanLabel.Location = new System.Drawing.Point(29, 115);
            this.jellyBeanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jellyBeanLabel.Name = "jellyBeanLabel";
            this.jellyBeanLabel.Size = new System.Drawing.Size(104, 18);
            this.jellyBeanLabel.TabIndex = 4;
            this.jellyBeanLabel.Text = "Jelly Bean (1)";
            this.jellyBeanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rockLabel
            // 
            this.rockLabel.AutoSize = true;
            this.rockLabel.BackColor = System.Drawing.Color.Transparent;
            this.rockLabel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.rockLabel.Location = new System.Drawing.Point(29, 90);
            this.rockLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rockLabel.Name = "rockLabel";
            this.rockLabel.Size = new System.Drawing.Size(127, 18);
            this.rockLabel.TabIndex = 5;
            this.rockLabel.Text = "Shiny White Rock";
            this.rockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // jellyInput
            // 
            this.jellyInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.jellyInput.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jellyInput.ForeColor = System.Drawing.Color.Snow;
            this.jellyInput.Location = new System.Drawing.Point(158, 114);
            this.jellyInput.Margin = new System.Windows.Forms.Padding(2);
            this.jellyInput.Name = "jellyInput";
            this.jellyInput.Size = new System.Drawing.Size(34, 20);
            this.jellyInput.TabIndex = 6;
            this.jellyInput.Text = "0";
            this.jellyInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rockInput
            // 
            this.rockInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rockInput.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockInput.ForeColor = System.Drawing.Color.Snow;
            this.rockInput.Location = new System.Drawing.Point(158, 89);
            this.rockInput.Margin = new System.Windows.Forms.Padding(2);
            this.rockInput.Name = "rockInput";
            this.rockInput.Size = new System.Drawing.Size(34, 20);
            this.rockInput.TabIndex = 7;
            this.rockInput.Text = "0";
            this.rockInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.subTotalLabel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.subTotalLabel.Location = new System.Drawing.Point(28, 197);
            this.subTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(73, 18);
            this.subTotalLabel.TabIndex = 8;
            this.subTotalLabel.Text = "Sub Total";
            this.subTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.totalLabel.Location = new System.Drawing.Point(28, 245);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(42, 18);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxLabel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.taxLabel.Location = new System.Drawing.Point(28, 220);
            this.taxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(31, 18);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.IndianRed;
            this.changeButton.Enabled = false;
            this.changeButton.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeButton.Location = new System.Drawing.Point(56, 336);
            this.changeButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(102, 22);
            this.changeButton.TabIndex = 11;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenderedLabel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.tenderedLabel.Location = new System.Drawing.Point(27, 313);
            this.tenderedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(68, 18);
            this.tenderedLabel.TabIndex = 12;
            this.tenderedLabel.Text = "Tendered";
            this.tenderedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tenderedInput
            // 
            this.tenderedInput.BackColor = System.Drawing.Color.IndianRed;
            this.tenderedInput.Enabled = false;
            this.tenderedInput.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.ForeColor = System.Drawing.Color.Snow;
            this.tenderedInput.Location = new System.Drawing.Point(156, 313);
            this.tenderedInput.Margin = new System.Windows.Forms.Padding(2);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(34, 20);
            this.tenderedInput.TabIndex = 13;
            this.tenderedInput.Text = "0";
            this.tenderedInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.BackColor = System.Drawing.Color.Transparent;
            this.subTotalOutput.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutput.ForeColor = System.Drawing.Color.LavenderBlush;
            this.subTotalOutput.Location = new System.Drawing.Point(99, 197);
            this.subTotalOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(93, 18);
            this.subTotalOutput.TabIndex = 14;
            this.subTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.Transparent;
            this.taxOutput.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.ForeColor = System.Drawing.Color.LavenderBlush;
            this.taxOutput.Location = new System.Drawing.Point(96, 220);
            this.taxOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(96, 18);
            this.taxOutput.TabIndex = 15;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.Transparent;
            this.totalOutput.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.ForeColor = System.Drawing.Color.LavenderBlush;
            this.totalOutput.Location = new System.Drawing.Point(74, 245);
            this.totalOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(118, 18);
            this.totalOutput.TabIndex = 16;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeLabel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.changeLabel.Location = new System.Drawing.Point(27, 363);
            this.changeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(85, 18);
            this.changeLabel.TabIndex = 17;
            this.changeLabel.Text = "Change Due";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.Transparent;
            this.changeOutput.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.ForeColor = System.Drawing.Color.LavenderBlush;
            this.changeOutput.Location = new System.Drawing.Point(116, 363);
            this.changeOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(76, 18);
            this.changeOutput.TabIndex = 18;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.DarkGray;
            this.resetButton.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetButton.Location = new System.Drawing.Point(65, 410);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(76, 22);
            this.resetButton.TabIndex = 19;
            this.resetButton.Text = "Restart";
            this.resetButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.IndianRed;
            this.receiptButton.Enabled = false;
            this.receiptButton.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.receiptButton.Location = new System.Drawing.Point(417, 417);
            this.receiptButton.Margin = new System.Windows.Forms.Padding(2);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(131, 22);
            this.receiptButton.TabIndex = 20;
            this.receiptButton.Text = "Don\'t Let Anyone See";
            this.receiptButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // receiptOutput
            // 
            this.receiptOutput.BackColor = System.Drawing.Color.Transparent;
            this.receiptOutput.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput.ForeColor = System.Drawing.Color.LavenderBlush;
            this.receiptOutput.Location = new System.Drawing.Point(387, 69);
            this.receiptOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(172, 292);
            this.receiptOutput.TabIndex = 21;
            this.receiptOutput.Visible = false;
            // 
            // receiptOutput2
            // 
            this.receiptOutput2.BackColor = System.Drawing.Color.Transparent;
            this.receiptOutput2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.receiptOutput2.Location = new System.Drawing.Point(495, 70);
            this.receiptOutput2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.receiptOutput2.Name = "receiptOutput2";
            this.receiptOutput2.Size = new System.Drawing.Size(64, 191);
            this.receiptOutput2.TabIndex = 23;
            this.receiptOutput2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.receiptOutput2.Visible = false;
            // 
            // previousSaleOutput
            // 
            this.previousSaleOutput.AutoSize = true;
            this.previousSaleOutput.BackColor = System.Drawing.Color.Transparent;
            this.previousSaleOutput.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousSaleOutput.ForeColor = System.Drawing.Color.LavenderBlush;
            this.previousSaleOutput.Location = new System.Drawing.Point(424, 52);
            this.previousSaleOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.previousSaleOutput.Name = "previousSaleOutput";
            this.previousSaleOutput.Size = new System.Drawing.Size(96, 18);
            this.previousSaleOutput.TabIndex = 24;
            this.previousSaleOutput.Text = "Previous Sale";
            this.previousSaleOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.previousSaleOutput.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.receiptOutput2);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.previousSaleOutput);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.rockInput);
            this.Controls.Add(this.jellyInput);
            this.Controls.Add(this.rockLabel);
            this.Controls.Add(this.jellyBeanLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.feralCatInput);
            this.Controls.Add(this.feralCatsLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Drug Deal Cash Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label feralCatsLabel;
        private System.Windows.Forms.TextBox feralCatInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label jellyBeanLabel;
        private System.Windows.Forms.Label rockLabel;
        private System.Windows.Forms.TextBox jellyInput;
        private System.Windows.Forms.TextBox rockInput;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Label receiptOutput2;
        private System.Windows.Forms.Label previousSaleOutput;
    }
}

