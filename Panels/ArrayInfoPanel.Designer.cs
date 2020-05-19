namespace KursOOP
{
    partial class ArrayInfoPanel
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LabelType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.FreeCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BusyCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CircleCount = new System.Windows.Forms.Label();
            this.RhombusCount = new System.Windows.Forms.Label();
            this.TriangleCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.LabelType);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Location = new System.Drawing.Point(10, 9);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(314, 170);
            this.MainPanel.TabIndex = 7;
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelType.Location = new System.Drawing.Point(17, -4);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(217, 20);
            this.LabelType.TabIndex = 9;
            this.LabelType.Text = "Информация по массиву";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TotalCount);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.FreeCount);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.BusyCount);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CircleCount);
            this.panel1.Controls.Add(this.RhombusCount);
            this.panel1.Controls.Add(this.TriangleCount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 155);
            this.panel1.TabIndex = 6;
            // 
            // TotalCount
            // 
            this.TotalCount.AutoSize = true;
            this.TotalCount.Location = new System.Drawing.Point(74, 101);
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Size = new System.Drawing.Size(41, 13);
            this.TotalCount.TabIndex = 21;
            this.TotalCount.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(9, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Всего:";
            // 
            // FreeCount
            // 
            this.FreeCount.AutoSize = true;
            this.FreeCount.Location = new System.Drawing.Point(74, 73);
            this.FreeCount.Name = "FreeCount";
            this.FreeCount.Size = new System.Drawing.Size(35, 13);
            this.FreeCount.TabIndex = 19;
            this.FreeCount.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(9, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Свободно:";
            // 
            // BusyCount
            // 
            this.BusyCount.AutoSize = true;
            this.BusyCount.Location = new System.Drawing.Point(74, 45);
            this.BusyCount.Name = "BusyCount";
            this.BusyCount.Size = new System.Drawing.Size(35, 13);
            this.BusyCount.TabIndex = 17;
            this.BusyCount.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(9, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Занято:";
            // 
            // CircleCount
            // 
            this.CircleCount.AutoSize = true;
            this.CircleCount.Location = new System.Drawing.Point(260, 101);
            this.CircleCount.Name = "CircleCount";
            this.CircleCount.Size = new System.Drawing.Size(35, 13);
            this.CircleCount.TabIndex = 15;
            this.CircleCount.Text = "label4";
            // 
            // RhombusCount
            // 
            this.RhombusCount.AutoSize = true;
            this.RhombusCount.Location = new System.Drawing.Point(260, 73);
            this.RhombusCount.Name = "RhombusCount";
            this.RhombusCount.Size = new System.Drawing.Size(35, 13);
            this.RhombusCount.TabIndex = 14;
            this.RhombusCount.Text = "label5";
            // 
            // TriangleCount
            // 
            this.TriangleCount.AutoSize = true;
            this.TriangleCount.Location = new System.Drawing.Point(260, 45);
            this.TriangleCount.Name = "TriangleCount";
            this.TriangleCount.Size = new System.Drawing.Size(35, 13);
            this.TriangleCount.TabIndex = 13;
            this.TriangleCount.Text = "label6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(161, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Окружностей: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(161, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ромбов: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(161, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Треугольников: ";
            // 
            // ArrayInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 189);
            this.Controls.Add(this.MainPanel);
            this.Name = "ArrayInfoPanel";
            this.Text = "ArrayInfoPanel";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label FreeCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label BusyCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CircleCount;
        private System.Windows.Forms.Label RhombusCount;
        private System.Windows.Forms.Label TriangleCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}