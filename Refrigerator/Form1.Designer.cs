namespace Refrigerator
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
            this.enterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maximumWeightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.noOfItemsEntryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weightEntryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currentWeightTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.remainingWeightTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(517, 103);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maximum Weight It Can Take";
            // 
            // maximumWeightTextBox
            // 
            this.maximumWeightTextBox.Location = new System.Drawing.Point(232, 41);
            this.maximumWeightTextBox.Name = "maximumWeightTextBox";
            this.maximumWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.maximumWeightTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No Of Items";
            // 
            // noOfItemsEntryTextBox
            // 
            this.noOfItemsEntryTextBox.Location = new System.Drawing.Point(142, 103);
            this.noOfItemsEntryTextBox.Name = "noOfItemsEntryTextBox";
            this.noOfItemsEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.noOfItemsEntryTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Weight (KG) /Unit";
            // 
            // weightEntryTextBox
            // 
            this.weightEntryTextBox.Location = new System.Drawing.Point(367, 103);
            this.weightEntryTextBox.Name = "weightEntryTextBox";
            this.weightEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightEntryTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Current  (Weight)";
            // 
            // currentWeightTextBox
            // 
            this.currentWeightTextBox.Location = new System.Drawing.Point(142, 140);
            this.currentWeightTextBox.Name = "currentWeightTextBox";
            this.currentWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentWeightTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Remaining (Weight)";
            // 
            // remainingWeightTextBox
            // 
            this.remainingWeightTextBox.Location = new System.Drawing.Point(367, 140);
            this.remainingWeightTextBox.Name = "remainingWeightTextBox";
            this.remainingWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.remainingWeightTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(354, 39);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 305);
            this.Controls.Add(this.remainingWeightTextBox);
            this.Controls.Add(this.weightEntryTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentWeightTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noOfItemsEntryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maximumWeightTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.enterButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maximumWeightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noOfItemsEntryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox weightEntryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currentWeightTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox remainingWeightTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}

