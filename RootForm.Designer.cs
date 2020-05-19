namespace KursOOP
{
    partial class RootForm
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
            this.MainList = new System.Windows.Forms.ListBox();
            this.BtShowInfo = new System.Windows.Forms.Button();
            this.BtChangeObject = new System.Windows.Forms.Button();
            this.BtAddObject = new System.Windows.Forms.Button();
            this.BtCreateArray = new System.Windows.Forms.Button();
            this.BtArrayInfo = new System.Windows.Forms.Button();
            this.InpItemCount = new System.Windows.Forms.TextBox();
            this.InpIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainList
            // 
            this.MainList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainList.FormattingEnabled = true;
            this.MainList.ItemHeight = 16;
            this.MainList.Location = new System.Drawing.Point(12, 12);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(157, 260);
            this.MainList.TabIndex = 0;
            this.MainList.SelectedIndexChanged += new System.EventHandler(this.MainList_SelectedIndexChanged);
            // 
            // BtShowInfo
            // 
            this.BtShowInfo.Enabled = false;
            this.BtShowInfo.Location = new System.Drawing.Point(12, 321);
            this.BtShowInfo.Name = "BtShowInfo";
            this.BtShowInfo.Size = new System.Drawing.Size(236, 23);
            this.BtShowInfo.TabIndex = 1;
            this.BtShowInfo.Text = "Информация об элементе";
            this.BtShowInfo.UseVisualStyleBackColor = true;
            this.BtShowInfo.Click += new System.EventHandler(this.BtShowInfo_Click);
            // 
            // BtChangeObject
            // 
            this.BtChangeObject.Enabled = false;
            this.BtChangeObject.Location = new System.Drawing.Point(12, 350);
            this.BtChangeObject.Name = "BtChangeObject";
            this.BtChangeObject.Size = new System.Drawing.Size(236, 23);
            this.BtChangeObject.TabIndex = 2;
            this.BtChangeObject.Text = "Изменить объект";
            this.BtChangeObject.UseVisualStyleBackColor = true;
            this.BtChangeObject.Click += new System.EventHandler(this.BtChangeObject_Click);
            // 
            // BtAddObject
            // 
            this.BtAddObject.Enabled = false;
            this.BtAddObject.Location = new System.Drawing.Point(12, 379);
            this.BtAddObject.Name = "BtAddObject";
            this.BtAddObject.Size = new System.Drawing.Size(236, 23);
            this.BtAddObject.TabIndex = 3;
            this.BtAddObject.Text = "Добавить элемент";
            this.BtAddObject.UseVisualStyleBackColor = true;
            this.BtAddObject.Click += new System.EventHandler(this.BtAddObject_Click);
            // 
            // BtCreateArray
            // 
            this.BtCreateArray.Location = new System.Drawing.Point(460, 37);
            this.BtCreateArray.Name = "BtCreateArray";
            this.BtCreateArray.Size = new System.Drawing.Size(112, 23);
            this.BtCreateArray.TabIndex = 4;
            this.BtCreateArray.Text = "Задать массив";
            this.BtCreateArray.UseVisualStyleBackColor = true;
            this.BtCreateArray.Click += new System.EventHandler(this.BtCreateArray_Click);
            // 
            // BtArrayInfo
            // 
            this.BtArrayInfo.Enabled = false;
            this.BtArrayInfo.Location = new System.Drawing.Point(416, 66);
            this.BtArrayInfo.Name = "BtArrayInfo";
            this.BtArrayInfo.Size = new System.Drawing.Size(156, 23);
            this.BtArrayInfo.TabIndex = 5;
            this.BtArrayInfo.Text = "Информация о массиве";
            this.BtArrayInfo.UseVisualStyleBackColor = true;
            this.BtArrayInfo.Click += new System.EventHandler(this.BtArrayInfo_Click);
            // 
            // InpItemCount
            // 
            this.InpItemCount.Location = new System.Drawing.Point(460, 11);
            this.InpItemCount.Name = "InpItemCount";
            this.InpItemCount.Size = new System.Drawing.Size(110, 20);
            this.InpItemCount.TabIndex = 6;
            // 
            // InpIndex
            // 
            this.InpIndex.Enabled = false;
            this.InpIndex.Location = new System.Drawing.Point(148, 295);
            this.InpIndex.Name = "InpIndex";
            this.InpIndex.Size = new System.Drawing.Size(100, 20);
            this.InpIndex.TabIndex = 7;
            this.InpIndex.TextChanged += new System.EventHandler(this.InpIndex_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(175, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите кол-во элементов массива:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите индекс";
            // 
            // ContentPanel
            // 
            this.ContentPanel.Location = new System.Drawing.Point(254, 241);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(316, 172);
            this.ContentPanel.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(175, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 115);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Окружность - 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ромб - 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Треугольник - 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(183, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Обозначение элементов";
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 429);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InpIndex);
            this.Controls.Add(this.InpItemCount);
            this.Controls.Add(this.BtArrayInfo);
            this.Controls.Add(this.BtCreateArray);
            this.Controls.Add(this.BtAddObject);
            this.Controls.Add(this.BtChangeObject);
            this.Controls.Add(this.BtShowInfo);
            this.Controls.Add(this.MainList);
            this.Name = "RootForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсовая работа. Меньков С.А.";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MainList;
        private System.Windows.Forms.Button BtShowInfo;
        private System.Windows.Forms.Button BtChangeObject;
        private System.Windows.Forms.Button BtAddObject;
        private System.Windows.Forms.Button BtCreateArray;
        private System.Windows.Forms.Button BtArrayInfo;
        private System.Windows.Forms.TextBox InpItemCount;
        private System.Windows.Forms.TextBox InpIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel ContentPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

