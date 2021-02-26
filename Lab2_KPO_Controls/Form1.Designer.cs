
namespace Lab2_KPO_Controls
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Ex1Page = new System.Windows.Forms.TabPage();
            this.Ex2Page = new System.Windows.Forms.TabPage();
            this.Ex3Page = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.numberBox3 = new LabControls.NumberBox(this.components);
            this.numberBox2 = new LabControls.NumberBox(this.components);
            this.numberBox1 = new LabControls.NumberBox(this.components);
            this.filePathSelect1 = new LabControls.FilePathSelect();
            this.complexColorControl1 = new LabControls.ComplexColorControl();
            this.tabControl1.SuspendLayout();
            this.Ex1Page.SuspendLayout();
            this.Ex2Page.SuspendLayout();
            this.Ex3Page.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Ex1Page);
            this.tabControl1.Controls.Add(this.Ex2Page);
            this.tabControl1.Controls.Add(this.Ex3Page);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(364, 280);
            this.tabControl1.TabIndex = 0;
            // 
            // Ex1Page
            // 
            this.Ex1Page.Controls.Add(this.numberBox3);
            this.Ex1Page.Controls.Add(this.numberBox2);
            this.Ex1Page.Controls.Add(this.numberBox1);
            this.Ex1Page.Location = new System.Drawing.Point(4, 22);
            this.Ex1Page.Name = "Ex1Page";
            this.Ex1Page.Padding = new System.Windows.Forms.Padding(3);
            this.Ex1Page.Size = new System.Drawing.Size(356, 254);
            this.Ex1Page.TabIndex = 0;
            this.Ex1Page.Text = "Упражнение 1";
            this.Ex1Page.UseVisualStyleBackColor = true;
            // 
            // Ex2Page
            // 
            this.Ex2Page.Controls.Add(this.filePathSelect1);
            this.Ex2Page.Location = new System.Drawing.Point(4, 22);
            this.Ex2Page.Name = "Ex2Page";
            this.Ex2Page.Padding = new System.Windows.Forms.Padding(3);
            this.Ex2Page.Size = new System.Drawing.Size(356, 254);
            this.Ex2Page.TabIndex = 1;
            this.Ex2Page.Text = "Упражнение 2";
            this.Ex2Page.UseVisualStyleBackColor = true;
            // 
            // Ex3Page
            // 
            this.Ex3Page.Controls.Add(this.label1);
            this.Ex3Page.Controls.Add(this.complexColorControl1);
            this.Ex3Page.Location = new System.Drawing.Point(4, 22);
            this.Ex3Page.Name = "Ex3Page";
            this.Ex3Page.Size = new System.Drawing.Size(356, 254);
            this.Ex3Page.TabIndex = 2;
            this.Ex3Page.Text = "Упражнение 3";
            this.Ex3Page.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "MY COLOR IS CHANGING";
            // 
            // numberBox3
            // 
            this.numberBox3.ForeColor = System.Drawing.Color.Red;
            this.numberBox3.Location = new System.Drawing.Point(99, 110);
            this.numberBox3.Name = "numberBox3";
            this.numberBox3.Size = new System.Drawing.Size(154, 20);
            this.numberBox3.TabIndex = 2;
            // 
            // numberBox2
            // 
            this.numberBox2.ForeColor = System.Drawing.Color.Red;
            this.numberBox2.Location = new System.Drawing.Point(99, 156);
            this.numberBox2.Name = "numberBox2";
            this.numberBox2.Size = new System.Drawing.Size(154, 20);
            this.numberBox2.TabIndex = 1;
            // 
            // numberBox1
            // 
            this.numberBox1.ForeColor = System.Drawing.Color.Red;
            this.numberBox1.Location = new System.Drawing.Point(99, 63);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(154, 20);
            this.numberBox1.TabIndex = 0;
            // 
            // filePathSelect1
            // 
            this.filePathSelect1.FileName = "C:\\Users\\Acer\\Desktop\\Blue.png";
            this.filePathSelect1.Location = new System.Drawing.Point(18, 110);
            this.filePathSelect1.Name = "filePathSelect1";
            this.filePathSelect1.Size = new System.Drawing.Size(315, 21);
            this.filePathSelect1.TabIndex = 0;
            // 
            // complexColorControl1
            // 
            this.complexColorControl1.CurrentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.complexColorControl1.Location = new System.Drawing.Point(31, 60);
            this.complexColorControl1.Name = "complexColorControl1";
            this.complexColorControl1.Size = new System.Drawing.Size(298, 125);
            this.complexColorControl1.TabIndex = 0;
            this.complexColorControl1.CurrentColorChanged += new System.EventHandler(this.complexColorControl1_CurrentColorChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 280);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controls";
            this.tabControl1.ResumeLayout(false);
            this.Ex1Page.ResumeLayout(false);
            this.Ex1Page.PerformLayout();
            this.Ex2Page.ResumeLayout(false);
            this.Ex3Page.ResumeLayout(false);
            this.Ex3Page.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Ex1Page;
        private System.Windows.Forms.TabPage Ex2Page;
        private System.Windows.Forms.TabPage Ex3Page;
        private LabControls.NumberBox numberBox3;
        private LabControls.NumberBox numberBox2;
        private LabControls.NumberBox numberBox1;
        private LabControls.FilePathSelect filePathSelect1;
        private LabControls.ComplexColorControl complexColorControl1;
        private System.Windows.Forms.Label label1;
    }
}

