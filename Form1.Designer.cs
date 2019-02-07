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
            this.btnPrint = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxOutput
            // 
            this.lbxOutput.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.ItemHeight = 42;
            this.lbxOutput.Location = new System.Drawing.Point(0, 0);
            this.lbxOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.ScrollAlwaysVisible = true;
            this.lbxOutput.Size = new System.Drawing.Size(358, 1493);
            this.lbxOutput.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalc.Location = new System.Drawing.Point(0, 0);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(556, 94);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Generate Groups";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // rbUniques
            // 
            this.rbUniques.AutoSize = true;
            this.rbUniques.Checked = true;
            this.rbUniques.Location = new System.Drawing.Point(44, 87);
            this.rbUniques.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.rbNonUnique.Location = new System.Drawing.Point(44, 184);
            this.rbNonUnique.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.gbTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTypes.Location = new System.Drawing.Point(0, 94);
            this.gbTypes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbTypes.Name = "gbTypes";
            this.gbTypes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbTypes.Size = new System.Drawing.Size(556, 1251);
            this.gbTypes.TabIndex = 8;
            this.gbTypes.TabStop = false;
            this.gbTypes.Text = "Types Of Groups";
            // 
            // rbnRnd
            // 
            this.rbnRnd.AutoSize = true;
            this.rbnRnd.Location = new System.Drawing.Point(44, 275);
            this.rbnRnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbnRnd.Name = "rbnRnd";
            this.rbnRnd.Size = new System.Drawing.Size(208, 48);
            this.rbnRnd.TabIndex = 8;
            this.rbnRnd.Text = "Random";
            this.rbnRnd.UseVisualStyleBackColor = true;
            this.rbnRnd.CheckedChanged += new System.EventHandler(this.rbnRnd_CheckedChanged);
            // 
            // btnLoadNames
            // 
            this.btnLoadNames.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoadNames.Location = new System.Drawing.Point(0, 0);
            this.btnLoadNames.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnLoadNames.Name = "btnLoadNames";
            this.btnLoadNames.Size = new System.Drawing.Size(556, 74);
            this.btnLoadNames.TabIndex = 9;
            this.btnLoadNames.Text = "Load Names";
            this.btnLoadNames.UseVisualStyleBackColor = true;
            this.btnLoadNames.Click += new System.EventHandler(this.btnLoadNames_Click);
            // 
            // lbxOutputNames
            // 
            this.lbxOutputNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxOutputNames.FormattingEnabled = true;
            this.lbxOutputNames.ItemHeight = 42;
            this.lbxOutputNames.Location = new System.Drawing.Point(0, 0);
            this.lbxOutputNames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbxOutputNames.Name = "lbxOutputNames";
            this.lbxOutputNames.ScrollAlwaysVisible = true;
            this.lbxOutputNames.Size = new System.Drawing.Size(1722, 1493);
            this.lbxOutputNames.TabIndex = 10;
            this.lbxOutputNames.SizeChanged += new System.EventHandler(this.lbxOutputNames_SizeChanged_1);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPrint.Location = new System.Drawing.Point(0, 1419);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(556, 74);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print Groups";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.lbxOutput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.lbxOutputNames);
            this.splitContainer1.Size = new System.Drawing.Size(2640, 1493);
            this.splitContainer1.SplitterDistance = 914;
            this.splitContainer1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLoadNames);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(358, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 1493);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbTypes);
            this.panel2.Controls.Add(this.btnCalc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 1345);
            this.panel2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2640, 1493);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTypes.ResumeLayout(false);
            this.gbTypes.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

