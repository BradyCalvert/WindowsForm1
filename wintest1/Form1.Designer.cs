namespace wintest1
{
    partial class formGideon
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.CheckBox chkChangeA;
      this.labelTyler = new System.Windows.Forms.Label();
      this.buttonA = new System.Windows.Forms.Button();
      this.nameEntry = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.wordCount = new System.Windows.Forms.Label();
      this.buttonB = new System.Windows.Forms.Button();
      this.buttonC = new System.Windows.Forms.Button();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.drpYear = new System.Windows.Forms.ComboBox();
      chkChangeA = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // chkChangeA
      // 
      chkChangeA.AllowDrop = true;
      chkChangeA.AutoSize = true;
      chkChangeA.Location = new System.Drawing.Point(348, 21);
      chkChangeA.Margin = new System.Windows.Forms.Padding(4);
      chkChangeA.Name = "chkChangeA";
      chkChangeA.Size = new System.Drawing.Size(129, 21);
      chkChangeA.TabIndex = 8;
      chkChangeA.Text = "Change A Color";
      chkChangeA.UseVisualStyleBackColor = true;
      chkChangeA.CheckedChanged += new System.EventHandler(this.changeButtonAColor);
      // 
      // labelTyler
      // 
      this.labelTyler.AutoSize = true;
      this.labelTyler.ForeColor = System.Drawing.Color.Red;
      this.labelTyler.Location = new System.Drawing.Point(204, 474);
      this.labelTyler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelTyler.Name = "labelTyler";
      this.labelTyler.Size = new System.Drawing.Size(40, 17);
      this.labelTyler.TabIndex = 0;
      this.labelTyler.Text = "Tyler";
      this.labelTyler.Click += new System.EventHandler(this.labelTyler_Click);
      // 
      // buttonA
      // 
      this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.buttonA.Location = new System.Drawing.Point(144, 15);
      this.buttonA.Margin = new System.Windows.Forms.Padding(4);
      this.buttonA.Name = "buttonA";
      this.buttonA.Size = new System.Drawing.Size(100, 28);
      this.buttonA.TabIndex = 1;
      this.buttonA.Text = "AAA";
      this.toolTip1.SetToolTip(this.buttonA, "This is a cool button");
      this.buttonA.UseVisualStyleBackColor = true;
      this.buttonA.Click += new System.EventHandler(this.vancesMethod);
      // 
      // nameEntry
      // 
      this.nameEntry.Location = new System.Drawing.Point(144, 345);
      this.nameEntry.Margin = new System.Windows.Forms.Padding(4);
      this.nameEntry.Name = "nameEntry";
      this.nameEntry.Size = new System.Drawing.Size(311, 22);
      this.nameEntry.TabIndex = 2;
      this.nameEntry.TextChanged += new System.EventHandler(this.nameEntry_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(32, 345);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(83, 17);
      this.label1.TabIndex = 3;
      this.label1.Text = "Enter Name";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(204, 511);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(91, 17);
      this.label2.TabIndex = 4;
      this.label2.Text = "Word Count: ";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // wordCount
      // 
      this.wordCount.AutoSize = true;
      this.wordCount.Location = new System.Drawing.Point(295, 510);
      this.wordCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.wordCount.Name = "wordCount";
      this.wordCount.Size = new System.Drawing.Size(0, 17);
      this.wordCount.TabIndex = 5;
      // 
      // buttonB
      // 
      this.buttonB.Location = new System.Drawing.Point(144, 71);
      this.buttonB.Margin = new System.Windows.Forms.Padding(4);
      this.buttonB.Name = "buttonB";
      this.buttonB.Size = new System.Drawing.Size(100, 28);
      this.buttonB.TabIndex = 6;
      this.buttonB.Text = "BBB";
      this.buttonB.UseVisualStyleBackColor = true;
      // 
      // buttonC
      // 
      this.buttonC.Location = new System.Drawing.Point(144, 130);
      this.buttonC.Margin = new System.Windows.Forms.Padding(4);
      this.buttonC.Name = "buttonC";
      this.buttonC.Size = new System.Drawing.Size(100, 28);
      this.buttonC.TabIndex = 7;
      this.buttonC.Text = "CCC";
      this.buttonC.UseVisualStyleBackColor = true;
      this.buttonC.Click += new System.EventHandler(this.formControlClicked);
      // 
      // toolTip1
      // 
      this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May"});
      this.comboBox1.Location = new System.Drawing.Point(293, 90);
      this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(160, 24);
      this.comboBox1.TabIndex = 9;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // drpYear
      // 
      this.drpYear.FormattingEnabled = true;
      this.drpYear.Location = new System.Drawing.Point(320, 215);
      this.drpYear.Margin = new System.Windows.Forms.Padding(4);
      this.drpYear.Name = "drpYear";
      this.drpYear.Size = new System.Drawing.Size(160, 24);
      this.drpYear.TabIndex = 10;
      // 
      // formGideon
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.ClientSize = new System.Drawing.Size(807, 638);
      this.Controls.Add(this.drpYear);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(chkChangeA);
      this.Controls.Add(this.buttonC);
      this.Controls.Add(this.buttonB);
      this.Controls.Add(this.wordCount);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.nameEntry);
      this.Controls.Add(this.buttonA);
      this.Controls.Add(this.labelTyler);
      this.ForeColor = System.Drawing.Color.Red;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "formGideon";
      this.Text = "Howdy App";
      this.Load += new System.EventHandler(this.formGideon_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTyler;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.TextBox nameEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wordCount;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox drpYear;
    }
}

