namespace TestForm
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
            this.based2 = new System.Windows.Forms.Label();
            this.based2onebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.heightonebox = new System.Windows.Forms.TextBox();
            this.based = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.basedonebox = new System.Windows.Forms.TextBox();
            this.btnresult = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // based2
            // 
            this.based2.AutoSize = true;
            this.based2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.based2.Location = new System.Drawing.Point(11, 112);
            this.based2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.based2.Name = "based2";
            this.based2.Size = new System.Drawing.Size(72, 13);
            this.based2.TabIndex = 28;
            this.based2.Text = "Основание 2";
            // 
            // based2onebox
            // 
            this.based2onebox.Location = new System.Drawing.Point(96, 109);
            this.based2onebox.Margin = new System.Windows.Forms.Padding(2);
            this.based2onebox.Name = "based2onebox";
            this.based2onebox.Size = new System.Drawing.Size(131, 20);
            this.based2onebox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(25, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Периметр";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.height.Location = new System.Drawing.Point(29, 140);
            this.height.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(45, 13);
            this.height.TabIndex = 25;
            this.height.Text = "Высота";
            // 
            // heightonebox
            // 
            this.heightonebox.Location = new System.Drawing.Point(96, 133);
            this.heightonebox.Margin = new System.Windows.Forms.Padding(2);
            this.heightonebox.Name = "heightonebox";
            this.heightonebox.Size = new System.Drawing.Size(131, 20);
            this.heightonebox.TabIndex = 24;
            // 
            // based
            // 
            this.based.AutoSize = true;
            this.based.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.based.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.based.Location = new System.Drawing.Point(11, 88);
            this.based.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.based.Name = "based";
            this.based.Size = new System.Drawing.Size(63, 13);
            this.based.TabIndex = 23;
            this.based.Text = "Основание";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(96, 274);
            this.resultBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(122, 20);
            this.resultBox.TabIndex = 22;
            // 
            // basedonebox
            // 
            this.basedonebox.Location = new System.Drawing.Point(96, 85);
            this.basedonebox.Margin = new System.Windows.Forms.Padding(2);
            this.basedonebox.Name = "basedonebox";
            this.basedonebox.Size = new System.Drawing.Size(131, 20);
            this.basedonebox.TabIndex = 21;
            // 
            // btnresult
            // 
            this.btnresult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnresult.Location = new System.Drawing.Point(71, 209);
            this.btnresult.Margin = new System.Windows.Forms.Padding(2);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(122, 19);
            this.btnresult.TabIndex = 20;
            this.btnresult.Text = "Результат";
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forumss.Properties.Resources.Безымянный;
            this.pictureBox1.Location = new System.Drawing.Point(116, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 50);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.based2);
            this.Controls.Add(this.based2onebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.height);
            this.Controls.Add(this.heightonebox);
            this.Controls.Add(this.based);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.basedonebox);
            this.Controls.Add(this.btnresult);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label based2;
        private System.Windows.Forms.TextBox based2onebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.TextBox heightonebox;
        private System.Windows.Forms.Label based;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox basedonebox;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

