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
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.rbUniques = new System.Windows.Forms.RadioButton();
            this.rbNonUnique = new System.Windows.Forms.RadioButton();
            this.gbTypes = new System.Windows.Forms.GroupBox();
            this.rbnRnd = new System.Windows.Forms.RadioButton();
            this.btnLoadNames = new System.Windows.Forms.Button();
            this.lbxOutputNames = new System.Windows.Forms.ListBox();
            this.btnGenerateNames = new System.Windows.Forms.Button();
            this.gbTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.Location = new System.Drawing.Point(30, 52);
            this.lbxOutput.Margin = new System.Windows.Forms.Padding(1);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.ScrollAlwaysVisible = true;
            this.lbxOutput.Size = new System.Drawing.Size(124, 277);
            this.lbxOutput.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(30, 4);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(1);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(124, 46);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Generate Groups";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // rbUniques
            // 
            this.rbUniques.AutoSize = true;
            this.rbUniques.Checked = true;
            this.rbUniques.Location = new System.Drawing.Point(12, 27);
            this.rbUniques.Margin = new System.Windows.Forms.Padding(1);
            this.rbUniques.Name = "rbUniques";
            this.rbUniques.Size = new System.Drawing.Size(96, 17);
            this.rbUniques.TabIndex = 6;
            this.rbUniques.TabStop = true;
            this.rbUniques.Text = "Unique Groups";
            this.rbUniques.UseVisualStyleBackColor = true;
            this.rbUniques.CheckedChanged += new System.EventHandler(this.rbUniques_CheckedChanged);
            // 
            // rbNonUnique
            // 
            this.rbNonUnique.AutoSize = true;
            this.rbNonUnique.Location = new System.Drawing.Point(12, 57);
            this.rbNonUnique.Margin = new System.Windows.Forms.Padding(1);
            this.rbNonUnique.Name = "rbNonUnique";
            this.rbNonUnique.Size = new System.Drawing.Size(80, 17);
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
            this.gbTypes.Location = new System.Drawing.Point(164, 79);
            this.gbTypes.Margin = new System.Windows.Forms.Padding(1);
            this.gbTypes.Name = "gbTypes";
            this.gbTypes.Padding = new System.Windows.Forms.Padding(1);
            this.gbTypes.Size = new System.Drawing.Size(106, 116);
            this.gbTypes.TabIndex = 8;
            this.gbTypes.TabStop = false;
            this.gbTypes.Text = "Types Of Groups";
            // 
            // rbnRnd
            // 
            this.rbnRnd.AutoSize = true;
            this.rbnRnd.Location = new System.Drawing.Point(12, 85);
            this.rbnRnd.Margin = new System.Windows.Forms.Padding(1);
            this.rbnRnd.Name = "rbnRnd";
            this.rbnRnd.Size = new System.Drawing.Size(65, 17);
            this.rbnRnd.TabIndex = 8;
            this.rbnRnd.Text = "Random";
            this.rbnRnd.UseVisualStyleBackColor = true;
            this.rbnRnd.CheckedChanged += new System.EventHandler(this.rbnRnd_CheckedChanged);
            // 
            // btnLoadNames
            // 
            this.btnLoadNames.Location = new System.Drawing.Point(166, 199);
            this.btnLoadNames.Name = "btnLoadNames";
            this.btnLoadNames.Size = new System.Drawing.Size(106, 23);
            this.btnLoadNames.TabIndex = 9;
            this.btnLoadNames.Text = "Load Names";
            this.btnLoadNames.UseVisualStyleBackColor = true;
            this.btnLoadNames.Click += new System.EventHandler(this.btnLoadNames_Click);
            // 
            // lbxOutputNames
            // 
            this.lbxOutputNames.FormattingEnabled = true;
            this.lbxOutputNames.Location = new System.Drawing.Point(286, 19);
            this.lbxOutputNames.Margin = new System.Windows.Forms.Padding(1);
            this.lbxOutputNames.Name = "lbxOutputNames";
            this.lbxOutputNames.ScrollAlwaysVisible = true;
            this.lbxOutputNames.Size = new System.Drawing.Size(390, 277);
            this.lbxOutputNames.TabIndex = 10;
            this.lbxOutputNames.SizeChanged += new System.EventHandler(this.lbxOutputNames_SizeChanged_1);
            // 
            // btnGenerateNames
            // 
            this.btnGenerateNames.Location = new System.Drawing.Point(164, 21);
            this.btnGenerateNames.Name = "btnGenerateNames";
            this.btnGenerateNames.Size = new System.Drawing.Size(108, 24);
            this.btnGenerateNames.TabIndex = 11;
            this.btnGenerateNames.Text = "Generate Names";
            this.btnGenerateNames.UseVisualStyleBackColor = true;
            this.btnGenerateNames.Click += new System.EventHandler(this.btnGenerateNames_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 319);
            this.Controls.Add(this.btnGenerateNames);
            this.Controls.Add(this.lbxOutputNames);
            this.Controls.Add(this.btnLoadNames);
            this.Controls.Add(this.gbTypes);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lbxOutput);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTypes.ResumeLayout(false);
            this.gbTypes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.RadioButton rbUniques;
        private System.Windows.Forms.RadioButton rbNonUnique;
        private System.Windows.Forms.GroupBox gbTypes;
        private System.Windows.Forms.RadioButton rbnRnd;
        private System.Windows.Forms.Button btnLoadNames;
        private System.Windows.Forms.ListBox lbxOutputNames;
        private System.Windows.Forms.Button btnGenerateNames;
    }
}

