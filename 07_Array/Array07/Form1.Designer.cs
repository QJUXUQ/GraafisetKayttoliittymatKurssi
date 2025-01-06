namespace Array07
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
            this.createChartB = new System.Windows.Forms.Button();
            this.SaveB = new System.Windows.Forms.Button();
            this.SearchB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chartBox = new System.Windows.Forms.TextBox();
            this.saveNumBox = new System.Windows.Forms.TextBox();
            this.indexBox = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createChartB
            // 
            this.createChartB.Location = new System.Drawing.Point(305, 78);
            this.createChartB.Name = "createChartB";
            this.createChartB.Size = new System.Drawing.Size(133, 23);
            this.createChartB.TabIndex = 0;
            this.createChartB.Text = "Luo taulukko";
            this.createChartB.UseVisualStyleBackColor = true;
            this.createChartB.Click += new System.EventHandler(this.createChartB_Click);
            // 
            // SaveB
            // 
            this.SaveB.Location = new System.Drawing.Point(320, 205);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(75, 23);
            this.SaveB.TabIndex = 1;
            this.SaveB.Text = "Talleta";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // SearchB
            // 
            this.SearchB.Location = new System.Drawing.Point(305, 318);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(75, 23);
            this.SearchB.TabIndex = 2;
            this.SearchB.Text = "Hae";
            this.SearchB.UseVisualStyleBackColor = true;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TAULUKON LUONTI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "taulukon koko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TALLENNUS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tallennettava numero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Talletuspaikan indeksi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "HAKU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Talletuspaikan indeksi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 10;
            // 
            // chartBox
            // 
            this.chartBox.Location = new System.Drawing.Point(169, 73);
            this.chartBox.Name = "chartBox";
            this.chartBox.Size = new System.Drawing.Size(100, 20);
            this.chartBox.TabIndex = 11;
            // 
            // saveNumBox
            // 
            this.saveNumBox.Location = new System.Drawing.Point(184, 188);
            this.saveNumBox.Name = "saveNumBox";
            this.saveNumBox.Size = new System.Drawing.Size(100, 20);
            this.saveNumBox.TabIndex = 12;
            // 
            // indexBox
            // 
            this.indexBox.Location = new System.Drawing.Point(184, 222);
            this.indexBox.Name = "indexBox";
            this.indexBox.Size = new System.Drawing.Size(100, 20);
            this.indexBox.TabIndex = 13;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(175, 321);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.indexBox);
            this.Controls.Add(this.saveNumBox);
            this.Controls.Add(this.chartBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.createChartB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createChartB;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox chartBox;
        private System.Windows.Forms.TextBox saveNumBox;
        private System.Windows.Forms.TextBox indexBox;
        private System.Windows.Forms.TextBox searchBox;
    }
}

