namespace DataBase_Jewelry
{
    partial class FormAddNewJewerly
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
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_composition = new System.Windows.Forms.TextBox();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_AddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_weight
            // 
            this.textBox_weight.Location = new System.Drawing.Point(74, 211);
            this.textBox_weight.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(132, 22);
            this.textBox_weight.TabIndex = 14;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(74, 257);
            this.textBox_price.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(132, 22);
            this.textBox_price.TabIndex = 13;
            // 
            // textBox_composition
            // 
            this.textBox_composition.Location = new System.Drawing.Point(74, 156);
            this.textBox_composition.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_composition.Name = "textBox_composition";
            this.textBox_composition.Size = new System.Drawing.Size(132, 22);
            this.textBox_composition.TabIndex = 12;
            // 
            // textBox_type
            // 
            this.textBox_type.Location = new System.Drawing.Point(74, 107);
            this.textBox_type.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(132, 22);
            this.textBox_type.TabIndex = 11;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(74, 52);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(132, 22);
            this.textBox_name.TabIndex = 10;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(172, 327);
            this.button_Close.Margin = new System.Windows.Forms.Padding(4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(100, 28);
            this.button_Close.TabIndex = 9;
            this.button_Close.Text = "Отмена";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_AddNew
            // 
            this.button_AddNew.Location = new System.Drawing.Point(52, 327);
            this.button_AddNew.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddNew.Name = "button_AddNew";
            this.button_AddNew.Size = new System.Drawing.Size(100, 28);
            this.button_AddNew.TabIndex = 8;
            this.button_AddNew.Text = "Ок";
            this.button_AddNew.UseVisualStyleBackColor = true;
            this.button_AddNew.Click += new System.EventHandler(this.button_AddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Тип ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Состав";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Вес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Цена";
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(49, 399);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 16);
            this.label_error.TabIndex = 20;
            // 
            // FormAddNewJewerly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 424);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_weight);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_composition);
            this.Controls.Add(this.textBox_type);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_AddNew);
            this.Name = "FormAddNewJewerly";
            this.Text = "Добавьте новое изделие";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_composition;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_AddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_error;
    }
}