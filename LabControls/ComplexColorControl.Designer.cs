
namespace LabControls
{
    partial class ComplexColorControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DecRadioButton = new System.Windows.Forms.RadioButton();
            this.HexRadioButton = new System.Windows.Forms.RadioButton();
            this.rectControl1 = new LabControls.RectControl(this.components);
            this.colorBox3 = new LabControls.ColorBox(this.components);
            this.colorBox2 = new LabControls.ColorBox(this.components);
            this.colorBox1 = new LabControls.ColorBox(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Blue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Green";
            // 
            // DecRadioButton
            // 
            this.DecRadioButton.AutoSize = true;
            this.DecRadioButton.Checked = true;
            this.DecRadioButton.Location = new System.Drawing.Point(3, 110);
            this.DecRadioButton.Name = "DecRadioButton";
            this.DecRadioButton.Size = new System.Drawing.Size(45, 17);
            this.DecRadioButton.TabIndex = 7;
            this.DecRadioButton.TabStop = true;
            this.DecRadioButton.Text = "Dec";
            this.DecRadioButton.UseVisualStyleBackColor = true;
            this.DecRadioButton.CheckedChanged += new System.EventHandler(this.DecRadioButton_CheckedChanged);
            // 
            // HexRadioButton
            // 
            this.HexRadioButton.AutoSize = true;
            this.HexRadioButton.Location = new System.Drawing.Point(59, 110);
            this.HexRadioButton.Name = "HexRadioButton";
            this.HexRadioButton.Size = new System.Drawing.Size(44, 17);
            this.HexRadioButton.TabIndex = 8;
            this.HexRadioButton.Text = "Hex";
            this.HexRadioButton.UseVisualStyleBackColor = true;
            // 
            // rectControl1
            // 
            this.rectControl1.CurrColor = System.Drawing.Color.Black;
            this.rectControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.rectControl1.Location = new System.Drawing.Point(147, 0);
            this.rectControl1.Name = "rectControl1";
            this.rectControl1.Size = new System.Drawing.Size(151, 125);
            this.rectControl1.TabIndex = 6;
            this.rectControl1.Text = "rectControl1";
            // 
            // colorBox3
            // 
            this.colorBox3.CurrentNumSystem = "Dec";
            this.colorBox3.Location = new System.Drawing.Point(59, 71);
            this.colorBox3.Name = "colorBox3";
            this.colorBox3.Size = new System.Drawing.Size(65, 20);
            this.colorBox3.TabIndex = 2;
            this.colorBox3.Text = "0";
            this.colorBox3.CurrentNumSystemChanged += new System.EventHandler(this.colorBox1_CurrentNumSystemChanged);
            this.colorBox3.TextChanged += new System.EventHandler(this.colorBox1_TextChanged);
            // 
            // colorBox2
            // 
            this.colorBox2.CurrentNumSystem = "Dec";
            this.colorBox2.Location = new System.Drawing.Point(59, 45);
            this.colorBox2.Name = "colorBox2";
            this.colorBox2.Size = new System.Drawing.Size(65, 20);
            this.colorBox2.TabIndex = 1;
            this.colorBox2.Text = "0";
            this.colorBox2.CurrentNumSystemChanged += new System.EventHandler(this.colorBox1_CurrentNumSystemChanged);
            this.colorBox2.TextChanged += new System.EventHandler(this.colorBox1_TextChanged);
            // 
            // colorBox1
            // 
            this.colorBox1.CurrentNumSystem = "Dec";
            this.colorBox1.Location = new System.Drawing.Point(59, 19);
            this.colorBox1.Name = "colorBox1";
            this.colorBox1.Size = new System.Drawing.Size(65, 20);
            this.colorBox1.TabIndex = 0;
            this.colorBox1.Text = "0";
            this.colorBox1.CurrentNumSystemChanged += new System.EventHandler(this.colorBox1_CurrentNumSystemChanged);
            this.colorBox1.TextChanged += new System.EventHandler(this.colorBox1_TextChanged);
            // 
            // ComplexColorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HexRadioButton);
            this.Controls.Add(this.DecRadioButton);
            this.Controls.Add(this.rectControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorBox3);
            this.Controls.Add(this.colorBox2);
            this.Controls.Add(this.colorBox1);
            this.Name = "ComplexColorControl";
            this.Size = new System.Drawing.Size(298, 125);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorBox colorBox1;
        private ColorBox colorBox2;
        private ColorBox colorBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RectControl rectControl1;
        private System.Windows.Forms.RadioButton DecRadioButton;
        private System.Windows.Forms.RadioButton HexRadioButton;
    }
}
