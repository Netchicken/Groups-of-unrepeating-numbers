namespace CounsellingTriads
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
            this.txtSessionlength = new System.Windows.Forms.TextBox();
            this.txtStudentCount = new System.Windows.Forms.TextBox();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbUniques = new System.Windows.Forms.RadioButton();
            this.rbNonUnique = new System.Windows.Forms.RadioButton();
            this.gbTypes = new System.Windows.Forms.GroupBox();
            this.rbnRnd = new System.Windows.Forms.RadioButton();
            this.gbTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSessionlength
            // 
            this.txtSessionlength.Location = new System.Drawing.Point(798, 206);
            this.txtSessionlength.Name = "txtSessionlength";
            this.txtSessionlength.Size = new System.Drawing.Size(372, 49);
            this.txtSessionlength.TabIndex = 0;
            // 
            // txtStudentCount
            // 
            this.txtStudentCount.Location = new System.Drawing.Point(1288, 206);
            this.txtStudentCount.Name = "txtStudentCount";
            this.txtStudentCount.Size = new System.Drawing.Size(403, 49);
            this.txtStudentCount.TabIndex = 1;
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.ItemHeight = 42;
            this.lbxOutput.Location = new System.Drawing.Point(110, 169);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.ScrollAlwaysVisible = true;
            this.lbxOutput.Size = new System.Drawing.Size(589, 886);
            this.lbxOutput.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(81, 61);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(607, 83);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "button1";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1301, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // rbUniques
            // 
            this.rbUniques.AutoSize = true;
            this.rbUniques.Checked = true;
            this.rbUniques.Location = new System.Drawing.Point(45, 86);
            this.rbUniques.Name = "rbUniques";
            this.rbUniques.Size = new System.Drawing.Size(319, 48);
            this.rbUniques.TabIndex = 6;
            this.rbUniques.TabStop = true;
            this.rbUniques.Text = "Unique Groups";
            this.rbUniques.UseVisualStyleBackColor = true;
            this.rbUniques.CheckedChanged += new System.EventHandler(this.rbUniques_CheckedChanged);
            // 
            // rbNonUnique
            // 
            this.rbNonUnique.AutoSize = true;
            this.rbNonUnique.Location = new System.Drawing.Point(45, 184);
            this.rbNonUnique.Name = "rbNonUnique";
            this.rbNonUnique.Size = new System.Drawing.Size(254, 48);
            this.rbNonUnique.TabIndex = 7;
            this.rbNonUnique.Text = "Non Unque";
            this.rbNonUnique.UseVisualStyleBackColor = true;
            this.rbNonUnique.CheckedChanged += new System.EventHandler(this.rbNonUnique_CheckedChanged);
            // 
            // gbTypes
            // 
            this.gbTypes.Controls.Add(this.rbnRnd);
            this.gbTypes.Controls.Add(this.rbNonUnique);
            this.gbTypes.Controls.Add(this.rbUniques);
            this.gbTypes.Location = new System.Drawing.Point(1288, 313);
            this.gbTypes.Name = "gbTypes";
            this.gbTypes.Size = new System.Drawing.Size(419, 486);
            this.gbTypes.TabIndex = 8;
            this.gbTypes.TabStop = false;
            this.gbTypes.Text = "Types Of Groups";
            // 
            // rbnRnd
            // 
            this.rbnRnd.AutoSize = true;
            this.rbnRnd.Location = new System.Drawing.Point(45, 275);
            this.rbnRnd.Name = "rbnRnd";
            this.rbnRnd.Size = new System.Drawing.Size(208, 48);
            this.rbnRnd.TabIndex = 8;
            this.rbnRnd.Text = "Random";
            this.rbnRnd.UseVisualStyleBackColor = true;
            this.rbnRnd.CheckedChanged += new System.EventHandler(this.rbnRnd_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1960, 1202);
            this.Controls.Add(this.gbTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.txtStudentCount);
            this.Controls.Add(this.txtSessionlength);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTypes.ResumeLayout(false);
            this.gbTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSessionlength;
        private System.Windows.Forms.TextBox txtStudentCount;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbUniques;
        private System.Windows.Forms.RadioButton rbNonUnique;
        private System.Windows.Forms.GroupBox gbTypes;
        private System.Windows.Forms.RadioButton rbnRnd;
    }
}

