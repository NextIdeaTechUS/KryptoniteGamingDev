namespace KryptoniteGaming_BatchGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPos1 = new System.Windows.Forms.NumericUpDown();
            this.txtPos2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPos3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutcome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddSpin = new System.Windows.Forms.Button();
            this.btnGenerateBatch = new System.Windows.Forms.Button();
            this.txtBatchSize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnProcessAllSpins = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPos3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchSize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddSpin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtOutcome);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPos3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPos2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPos1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manually Create Batch";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerateBatch);
            this.groupBox2.Controls.Add(this.txtBatchSize);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Automatically Create Random Batch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pos 1:";
            // 
            // txtPos1
            // 
            this.txtPos1.Location = new System.Drawing.Point(160, 127);
            this.txtPos1.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.txtPos1.Name = "txtPos1";
            this.txtPos1.Size = new System.Drawing.Size(185, 31);
            this.txtPos1.TabIndex = 2;
            // 
            // txtPos2
            // 
            this.txtPos2.Location = new System.Drawing.Point(160, 164);
            this.txtPos2.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.txtPos2.Name = "txtPos2";
            this.txtPos2.Size = new System.Drawing.Size(185, 31);
            this.txtPos2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pos 2:";
            // 
            // txtPos3
            // 
            this.txtPos3.Location = new System.Drawing.Point(160, 201);
            this.txtPos3.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.txtPos3.Name = "txtPos3";
            this.txtPos3.Size = new System.Drawing.Size(185, 31);
            this.txtPos3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pos 3:";
            // 
            // txtAmount
            // 
            this.txtAmount.DecimalPlaces = 2;
            this.txtAmount.Location = new System.Drawing.Point(160, 90);
            this.txtAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(185, 31);
            this.txtAmount.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount:";
            // 
            // txtOutcome
            // 
            this.txtOutcome.Location = new System.Drawing.Point(160, 53);
            this.txtOutcome.Name = "txtOutcome";
            this.txtOutcome.Size = new System.Drawing.Size(185, 31);
            this.txtOutcome.TabIndex = 0;
            this.txtOutcome.Text = "L";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Outcome:";
            // 
            // btnAddSpin
            // 
            this.btnAddSpin.Location = new System.Drawing.Point(410, 183);
            this.btnAddSpin.Name = "btnAddSpin";
            this.btnAddSpin.Size = new System.Drawing.Size(153, 49);
            this.btnAddSpin.TabIndex = 8;
            this.btnAddSpin.Text = "Add Spin";
            this.btnAddSpin.UseVisualStyleBackColor = true;
            this.btnAddSpin.Click += new System.EventHandler(this.btnAddSpin_Click);
            // 
            // btnGenerateBatch
            // 
            this.btnGenerateBatch.Location = new System.Drawing.Point(410, 40);
            this.btnGenerateBatch.Name = "btnGenerateBatch";
            this.btnGenerateBatch.Size = new System.Drawing.Size(153, 49);
            this.btnGenerateBatch.TabIndex = 11;
            this.btnGenerateBatch.Text = "Generate";
            this.btnGenerateBatch.UseVisualStyleBackColor = true;
            this.btnGenerateBatch.Click += new System.EventHandler(this.btnGenerateBatch_Click);
            // 
            // txtBatchSize
            // 
            this.txtBatchSize.Location = new System.Drawing.Point(160, 48);
            this.txtBatchSize.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.txtBatchSize.Name = "txtBatchSize";
            this.txtBatchSize.Size = new System.Drawing.Size(185, 31);
            this.txtBatchSize.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Batch Size:";
            // 
            // btnProcessAllSpins
            // 
            this.btnProcessAllSpins.Location = new System.Drawing.Point(45, 441);
            this.btnProcessAllSpins.Name = "btnProcessAllSpins";
            this.btnProcessAllSpins.Size = new System.Drawing.Size(530, 49);
            this.btnProcessAllSpins.TabIndex = 12;
            this.btnProcessAllSpins.Text = "Mark All Spins as \"Processed\"";
            this.btnProcessAllSpins.UseVisualStyleBackColor = true;
            this.btnProcessAllSpins.Click += new System.EventHandler(this.btnProcessAllSpins_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 504);
            this.Controls.Add(this.btnProcessAllSpins);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Kryptonite Gaming Batch Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPos3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddSpin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutcome;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtPos3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtPos2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtPos1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerateBatch;
        private System.Windows.Forms.NumericUpDown txtBatchSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnProcessAllSpins;
    }
}

