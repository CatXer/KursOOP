namespace KursOOP
{
    partial class InsertPanel
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
            this.BtSave = new System.Windows.Forms.Button();
            this.Param2 = new System.Windows.Forms.Label();
            this.Param1 = new System.Windows.Forms.Label();
            this.InpParam2 = new System.Windows.Forms.TextBox();
            this.InpParam1 = new System.Windows.Forms.TextBox();
            this.RbCircle = new System.Windows.Forms.RadioButton();
            this.RbRhombus = new System.Windows.Forms.RadioButton();
            this.RbTriangle = new System.Windows.Forms.RadioButton();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.LabelType);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(314, 170);
            this.MainPanel.TabIndex = 5;
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelType.Location = new System.Drawing.Point(17, -4);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(204, 20);
            this.LabelType.TabIndex = 9;
            this.LabelType.Text = "Выберите тип объекта";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtSave);
            this.panel1.Controls.Add(this.Param2);
            this.panel1.Controls.Add(this.Param1);
            this.panel1.Controls.Add(this.InpParam2);
            this.panel1.Controls.Add(this.InpParam1);
            this.panel1.Controls.Add(this.RbCircle);
            this.panel1.Controls.Add(this.RbRhombus);
            this.panel1.Controls.Add(this.RbTriangle);
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 155);
            this.panel1.TabIndex = 6;
            // 
            // BtSave
            // 
            this.BtSave.Enabled = false;
            this.BtSave.Location = new System.Drawing.Point(4, 126);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(100, 23);
            this.BtSave.TabIndex = 8;
            this.BtSave.Text = "Сохранить";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // Param2
            // 
            this.Param2.AutoSize = true;
            this.Param2.Location = new System.Drawing.Point(7, 73);
            this.Param2.Name = "Param2";
            this.Param2.Size = new System.Drawing.Size(35, 13);
            this.Param2.TabIndex = 7;
            this.Param2.Text = "label3";
            // 
            // Param1
            // 
            this.Param1.AutoSize = true;
            this.Param1.Location = new System.Drawing.Point(7, 17);
            this.Param1.Name = "Param1";
            this.Param1.Size = new System.Drawing.Size(35, 13);
            this.Param1.TabIndex = 6;
            this.Param1.Text = "label4";
            // 
            // InpParam2
            // 
            this.InpParam2.Location = new System.Drawing.Point(4, 98);
            this.InpParam2.Name = "InpParam2";
            this.InpParam2.Size = new System.Drawing.Size(100, 20);
            this.InpParam2.TabIndex = 5;
            // 
            // InpParam1
            // 
            this.InpParam1.Location = new System.Drawing.Point(4, 42);
            this.InpParam1.Name = "InpParam1";
            this.InpParam1.Size = new System.Drawing.Size(100, 20);
            this.InpParam1.TabIndex = 4;
            // 
            // RbCircle
            // 
            this.RbCircle.AutoSize = true;
            this.RbCircle.Location = new System.Drawing.Point(164, 99);
            this.RbCircle.Name = "RbCircle";
            this.RbCircle.Size = new System.Drawing.Size(87, 17);
            this.RbCircle.TabIndex = 3;
            this.RbCircle.TabStop = true;
            this.RbCircle.Text = "Окружность";
            this.RbCircle.UseVisualStyleBackColor = true;
            this.RbCircle.CheckedChanged += new System.EventHandler(this.RbCircle_CheckedChanged);
            // 
            // RbRhombus
            // 
            this.RbRhombus.AutoSize = true;
            this.RbRhombus.Location = new System.Drawing.Point(164, 71);
            this.RbRhombus.Name = "RbRhombus";
            this.RbRhombus.Size = new System.Drawing.Size(52, 17);
            this.RbRhombus.TabIndex = 2;
            this.RbRhombus.TabStop = true;
            this.RbRhombus.Text = "Ромб";
            this.RbRhombus.UseVisualStyleBackColor = true;
            this.RbRhombus.CheckedChanged += new System.EventHandler(this.RbRhombus_CheckedChanged);
            // 
            // RbTriangle
            // 
            this.RbTriangle.AutoSize = true;
            this.RbTriangle.Location = new System.Drawing.Point(164, 43);
            this.RbTriangle.Name = "RbTriangle";
            this.RbTriangle.Size = new System.Drawing.Size(90, 17);
            this.RbTriangle.TabIndex = 1;
            this.RbTriangle.TabStop = true;
            this.RbTriangle.Text = "Треугольник";
            this.RbTriangle.UseVisualStyleBackColor = true;
            this.RbTriangle.CheckedChanged += new System.EventHandler(this.RbTriangle_CheckedChanged);
            // 
            // InsertPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 189);
            this.Controls.Add(this.MainPanel);
            this.Name = "InsertPanel";
            this.Text = "InsertForm";
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
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.Label Param2;
        private System.Windows.Forms.Label Param1;
        private System.Windows.Forms.TextBox InpParam2;
        private System.Windows.Forms.TextBox InpParam1;
        private System.Windows.Forms.RadioButton RbCircle;
        private System.Windows.Forms.RadioButton RbRhombus;
        private System.Windows.Forms.RadioButton RbTriangle;
    }
}