namespace Multi_Threading_Race
{
    partial class mainForm
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
            this.grpRacers = new System.Windows.Forms.GroupBox();
            this.radOne = new System.Windows.Forms.RadioButton();
            this.radTwo = new System.Windows.Forms.RadioButton();
            this.radThree = new System.Windows.Forms.RadioButton();
            this.btnStartRace = new System.Windows.Forms.Button();
            this.lstRacerOne = new System.Windows.Forms.ListBox();
            this.lstRacerTwo = new System.Windows.Forms.ListBox();
            this.lstRacerThree = new System.Windows.Forms.ListBox();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpRacers.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRacers
            // 
            this.grpRacers.Controls.Add(this.radThree);
            this.grpRacers.Controls.Add(this.radTwo);
            this.grpRacers.Controls.Add(this.radOne);
            this.grpRacers.Location = new System.Drawing.Point(9, 12);
            this.grpRacers.Name = "grpRacers";
            this.grpRacers.Size = new System.Drawing.Size(125, 100);
            this.grpRacers.TabIndex = 0;
            this.grpRacers.TabStop = false;
            this.grpRacers.Text = "Choose Racer Count!";
            // 
            // radOne
            // 
            this.radOne.AutoSize = true;
            this.radOne.Location = new System.Drawing.Point(6, 26);
            this.radOne.Name = "radOne";
            this.radOne.Size = new System.Drawing.Size(45, 17);
            this.radOne.TabIndex = 1;
            this.radOne.TabStop = true;
            this.radOne.Text = "One";
            this.radOne.UseVisualStyleBackColor = true;
            // 
            // radTwo
            // 
            this.radTwo.AutoSize = true;
            this.radTwo.Location = new System.Drawing.Point(6, 51);
            this.radTwo.Name = "radTwo";
            this.radTwo.Size = new System.Drawing.Size(46, 17);
            this.radTwo.TabIndex = 2;
            this.radTwo.TabStop = true;
            this.radTwo.Text = "Two";
            this.radTwo.UseVisualStyleBackColor = true;
            // 
            // radThree
            // 
            this.radThree.AutoSize = true;
            this.radThree.Location = new System.Drawing.Point(6, 76);
            this.radThree.Name = "radThree";
            this.radThree.Size = new System.Drawing.Size(53, 17);
            this.radThree.TabIndex = 3;
            this.radThree.TabStop = true;
            this.radThree.Text = "Three";
            this.radThree.UseVisualStyleBackColor = true;
            // 
            // btnStartRace
            // 
            this.btnStartRace.Location = new System.Drawing.Point(201, 120);
            this.btnStartRace.Name = "btnStartRace";
            this.btnStartRace.Size = new System.Drawing.Size(158, 41);
            this.btnStartRace.TabIndex = 4;
            this.btnStartRace.Text = "Start Race!";
            this.btnStartRace.UseVisualStyleBackColor = true;
            this.btnStartRace.Click += new System.EventHandler(this.btnStartRace_Click);
            // 
            // lstRacerOne
            // 
            this.lstRacerOne.FormattingEnabled = true;
            this.lstRacerOne.Location = new System.Drawing.Point(144, 17);
            this.lstRacerOne.Name = "lstRacerOne";
            this.lstRacerOne.Size = new System.Drawing.Size(125, 95);
            this.lstRacerOne.TabIndex = 5;
            this.lstRacerOne.TabStop = false;
            // 
            // lstRacerTwo
            // 
            this.lstRacerTwo.FormattingEnabled = true;
            this.lstRacerTwo.Location = new System.Drawing.Point(279, 17);
            this.lstRacerTwo.Name = "lstRacerTwo";
            this.lstRacerTwo.Size = new System.Drawing.Size(125, 95);
            this.lstRacerTwo.TabIndex = 6;
            this.lstRacerTwo.TabStop = false;
            // 
            // lstRacerThree
            // 
            this.lstRacerThree.FormattingEnabled = true;
            this.lstRacerThree.Location = new System.Drawing.Point(414, 17);
            this.lstRacerThree.Name = "lstRacerThree";
            this.lstRacerThree.Size = new System.Drawing.Size(125, 95);
            this.lstRacerThree.TabIndex = 7;
            this.lstRacerThree.TabStop = false;
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(145, 130);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(45, 20);
            this.txtRange.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Target #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Range from 0-100";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(368, 120);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(158, 41);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 173);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRange);
            this.Controls.Add(this.lstRacerThree);
            this.Controls.Add(this.lstRacerTwo);
            this.Controls.Add(this.lstRacerOne);
            this.Controls.Add(this.btnStartRace);
            this.Controls.Add(this.grpRacers);
            this.Name = "mainForm";
            this.Text = "Multi-Thread Racing";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.grpRacers.ResumeLayout(false);
            this.grpRacers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRacers;
        private System.Windows.Forms.RadioButton radThree;
        private System.Windows.Forms.RadioButton radTwo;
        private System.Windows.Forms.RadioButton radOne;
        private System.Windows.Forms.Button btnStartRace;
        private System.Windows.Forms.ListBox lstRacerOne;
        private System.Windows.Forms.ListBox lstRacerTwo;
        private System.Windows.Forms.ListBox lstRacerThree;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
    }
}

