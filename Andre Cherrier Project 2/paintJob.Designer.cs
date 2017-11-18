namespace Andre_Cherrier_Project_2
{
    partial class paintJob
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
            this.wallSpaceLabel = new System.Windows.Forms.Label();
            this.paintPriceLabel = new System.Windows.Forms.Label();
            this.paintAmountLabel = new System.Windows.Forms.Label();
            this.totalPaintCostLabel = new System.Windows.Forms.Label();
            this.wallSpaceTextbox = new System.Windows.Forms.TextBox();
            this.paintPriceTextbox = new System.Windows.Forms.TextBox();
            this.paintAmountTextbox = new System.Windows.Forms.TextBox();
            this.laborHoursLabel = new System.Windows.Forms.Label();
            this.laborCostLabel = new System.Windows.Forms.Label();
            this.totalJobCostLabel = new System.Windows.Forms.Label();
            this.laborCostTextbox = new System.Windows.Forms.TextBox();
            this.totalPaintCostTextbox = new System.Windows.Forms.TextBox();
            this.laborhoursTextbox = new System.Windows.Forms.TextBox();
            this.totalJobCostTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.messageButton = new System.Windows.Forms.Button();
            this.doNotPushButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wallSpaceLabel
            // 
            this.wallSpaceLabel.AccessibleName = "";
            this.wallSpaceLabel.AutoSize = true;
            this.wallSpaceLabel.Location = new System.Drawing.Point(24, 55);
            this.wallSpaceLabel.Name = "wallSpaceLabel";
            this.wallSpaceLabel.Size = new System.Drawing.Size(201, 13);
            this.wallSpaceLabel.TabIndex = 0;
            this.wallSpaceLabel.Text = "Wall space (in square feet) to be painted:";
            // 
            // paintPriceLabel
            // 
            this.paintPriceLabel.AutoSize = true;
            this.paintPriceLabel.Location = new System.Drawing.Point(80, 99);
            this.paintPriceLabel.Name = "paintPriceLabel";
            this.paintPriceLabel.Size = new System.Drawing.Size(145, 13);
            this.paintPriceLabel.TabIndex = 1;
            this.paintPriceLabel.Text = "Price of the paint (per gallon):";
            // 
            // paintAmountLabel
            // 
            this.paintAmountLabel.AutoSize = true;
            this.paintAmountLabel.Location = new System.Drawing.Point(51, 143);
            this.paintAmountLabel.Name = "paintAmountLabel";
            this.paintAmountLabel.Size = new System.Drawing.Size(174, 13);
            this.paintAmountLabel.TabIndex = 2;
            this.paintAmountLabel.Text = "Number of gallons of paint required:";
            // 
            // totalPaintCostLabel
            // 
            this.totalPaintCostLabel.AutoSize = true;
            this.totalPaintCostLabel.Location = new System.Drawing.Point(141, 231);
            this.totalPaintCostLabel.Name = "totalPaintCostLabel";
            this.totalPaintCostLabel.Size = new System.Drawing.Size(84, 13);
            this.totalPaintCostLabel.TabIndex = 3;
            this.totalPaintCostLabel.Text = "Cost of paint ($):";
            // 
            // wallSpaceTextbox
            // 
            this.wallSpaceTextbox.Location = new System.Drawing.Point(231, 52);
            this.wallSpaceTextbox.Name = "wallSpaceTextbox";
            this.wallSpaceTextbox.Size = new System.Drawing.Size(100, 20);
            this.wallSpaceTextbox.TabIndex = 4;
            // 
            // paintPriceTextbox
            // 
            this.paintPriceTextbox.Location = new System.Drawing.Point(231, 96);
            this.paintPriceTextbox.Name = "paintPriceTextbox";
            this.paintPriceTextbox.Size = new System.Drawing.Size(100, 20);
            this.paintPriceTextbox.TabIndex = 5;
            // 
            // paintAmountTextbox
            // 
            this.paintAmountTextbox.Enabled = false;
            this.paintAmountTextbox.Location = new System.Drawing.Point(231, 140);
            this.paintAmountTextbox.Name = "paintAmountTextbox";
            this.paintAmountTextbox.Size = new System.Drawing.Size(100, 20);
            this.paintAmountTextbox.TabIndex = 6;
            // 
            // laborHoursLabel
            // 
            this.laborHoursLabel.AutoSize = true;
            this.laborHoursLabel.Location = new System.Drawing.Point(108, 187);
            this.laborHoursLabel.Name = "laborHoursLabel";
            this.laborHoursLabel.Size = new System.Drawing.Size(117, 13);
            this.laborHoursLabel.TabIndex = 7;
            this.laborHoursLabel.Text = "Hours of labor required:";
            // 
            // laborCostLabel
            // 
            this.laborCostLabel.AutoSize = true;
            this.laborCostLabel.Location = new System.Drawing.Point(156, 275);
            this.laborCostLabel.Name = "laborCostLabel";
            this.laborCostLabel.Size = new System.Drawing.Size(69, 13);
            this.laborCostLabel.TabIndex = 8;
            this.laborCostLabel.Text = "Cost of labor:";
            // 
            // totalJobCostLabel
            // 
            this.totalJobCostLabel.AutoSize = true;
            this.totalJobCostLabel.Location = new System.Drawing.Point(95, 319);
            this.totalJobCostLabel.Name = "totalJobCostLabel";
            this.totalJobCostLabel.Size = new System.Drawing.Size(130, 13);
            this.totalJobCostLabel.TabIndex = 9;
            this.totalJobCostLabel.Text = "Total cost of the paint job:";
            // 
            // laborCostTextbox
            // 
            this.laborCostTextbox.Enabled = false;
            this.laborCostTextbox.Location = new System.Drawing.Point(231, 272);
            this.laborCostTextbox.Name = "laborCostTextbox";
            this.laborCostTextbox.Size = new System.Drawing.Size(100, 20);
            this.laborCostTextbox.TabIndex = 12;
            // 
            // totalPaintCostTextbox
            // 
            this.totalPaintCostTextbox.Enabled = false;
            this.totalPaintCostTextbox.Location = new System.Drawing.Point(231, 228);
            this.totalPaintCostTextbox.Name = "totalPaintCostTextbox";
            this.totalPaintCostTextbox.Size = new System.Drawing.Size(100, 20);
            this.totalPaintCostTextbox.TabIndex = 13;
            // 
            // laborhoursTextbox
            // 
            this.laborhoursTextbox.Enabled = false;
            this.laborhoursTextbox.Location = new System.Drawing.Point(231, 184);
            this.laborhoursTextbox.Name = "laborhoursTextbox";
            this.laborhoursTextbox.Size = new System.Drawing.Size(100, 20);
            this.laborhoursTextbox.TabIndex = 14;
            // 
            // totalJobCostTextbox
            // 
            this.totalJobCostTextbox.Enabled = false;
            this.totalJobCostTextbox.Location = new System.Drawing.Point(231, 316);
            this.totalJobCostTextbox.Name = "totalJobCostTextbox";
            this.totalJobCostTextbox.Size = new System.Drawing.Size(100, 20);
            this.totalJobCostTextbox.TabIndex = 15;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(231, 366);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 16;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(231, 405);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 23);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(231, 444);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(99, 40);
            this.messageButton.TabIndex = 19;
            this.messageButton.Text = "Show in new window";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // doNotPushButton
            // 
            this.doNotPushButton.BackColor = System.Drawing.Color.Red;
            this.doNotPushButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doNotPushButton.Location = new System.Drawing.Point(27, 429);
            this.doNotPushButton.Name = "doNotPushButton";
            this.doNotPushButton.Size = new System.Drawing.Size(74, 55);
            this.doNotPushButton.TabIndex = 20;
            this.doNotPushButton.Text = "DO NOT CLICK!";
            this.doNotPushButton.UseVisualStyleBackColor = false;
            this.doNotPushButton.Click += new System.EventHandler(this.doNotPushButton_Click);
            // 
            // paintJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 519);
            this.Controls.Add(this.doNotPushButton);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalJobCostTextbox);
            this.Controls.Add(this.laborhoursTextbox);
            this.Controls.Add(this.totalPaintCostTextbox);
            this.Controls.Add(this.laborCostTextbox);
            this.Controls.Add(this.totalJobCostLabel);
            this.Controls.Add(this.laborCostLabel);
            this.Controls.Add(this.laborHoursLabel);
            this.Controls.Add(this.paintAmountTextbox);
            this.Controls.Add(this.paintPriceTextbox);
            this.Controls.Add(this.wallSpaceTextbox);
            this.Controls.Add(this.totalPaintCostLabel);
            this.Controls.Add(this.paintAmountLabel);
            this.Controls.Add(this.paintPriceLabel);
            this.Controls.Add(this.wallSpaceLabel);
            this.Name = "paintJob";
            this.Text = "Paint Job Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wallSpaceLabel;
        private System.Windows.Forms.Label paintPriceLabel;
        private System.Windows.Forms.Label paintAmountLabel;
        private System.Windows.Forms.Label totalPaintCostLabel;
        private System.Windows.Forms.TextBox wallSpaceTextbox;
        private System.Windows.Forms.TextBox paintPriceTextbox;
        private System.Windows.Forms.TextBox paintAmountTextbox;
        private System.Windows.Forms.Label laborHoursLabel;
        private System.Windows.Forms.Label laborCostLabel;
        private System.Windows.Forms.Label totalJobCostLabel;
        private System.Windows.Forms.TextBox laborCostTextbox;
        private System.Windows.Forms.TextBox totalPaintCostTextbox;
        private System.Windows.Forms.TextBox laborhoursTextbox;
        private System.Windows.Forms.TextBox totalJobCostTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Button doNotPushButton;
    }
}

