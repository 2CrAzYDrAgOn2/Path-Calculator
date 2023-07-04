namespace Вычисление_пути
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.velocityTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.accelerationTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.speed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wordButton = new System.Windows.Forms.Button();
            this.excelButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // velocityTextBox
            // 
            this.velocityTextBox.Location = new System.Drawing.Point(18, 30);
            this.velocityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.velocityTextBox.Name = "velocityTextBox";
            this.velocityTextBox.Size = new System.Drawing.Size(76, 20);
            this.velocityTextBox.TabIndex = 0;
            this.velocityTextBox.Text = "0";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(138, 30);
            this.timeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(76, 20);
            this.timeTextBox.TabIndex = 1;
            this.timeTextBox.Text = "0";
            this.timeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.velocityTextBox_KeyPress);
            // 
            // accelerationTextBox
            // 
            this.accelerationTextBox.Location = new System.Drawing.Point(256, 30);
            this.accelerationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.accelerationTextBox.Name = "accelerationTextBox";
            this.accelerationTextBox.Size = new System.Drawing.Size(76, 20);
            this.accelerationTextBox.TabIndex = 2;
            this.accelerationTextBox.Text = "0";
            this.accelerationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.velocityTextBox_KeyPress);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(41, 336);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(487, 65);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = resources.GetString("resultLabel.Text");
            // 
            // calculateButton
            // 
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.calculateButton.FlatAppearance.BorderSize = 2;
            this.calculateButton.Location = new System.Drawing.Point(389, 7);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(119, 55);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Результат";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(9, 7);
            this.speed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(112, 13);
            this.speed.TabIndex = 7;
            this.speed.Text = "Начальная скорость";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Время";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ускорение";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(11, 86);
            this.text.Margin = new System.Windows.Forms.Padding(2);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text.Size = new System.Drawing.Size(337, 231);
            this.text.TabIndex = 10;
            this.text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 86);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 54);
            this.button2.TabIndex = 11;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "км/ч";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "час";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "км/ч^2";
            // 
            // wordButton
            // 
            this.wordButton.Location = new System.Drawing.Point(389, 144);
            this.wordButton.Margin = new System.Windows.Forms.Padding(2);
            this.wordButton.Name = "wordButton";
            this.wordButton.Size = new System.Drawing.Size(116, 54);
            this.wordButton.TabIndex = 15;
            this.wordButton.Text = "Показать в Word";
            this.wordButton.UseVisualStyleBackColor = true;
            this.wordButton.Click += new System.EventHandler(this.wordButton_Click);
            // 
            // excelButton
            // 
            this.excelButton.Location = new System.Drawing.Point(389, 202);
            this.excelButton.Margin = new System.Windows.Forms.Padding(2);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(116, 54);
            this.excelButton.TabIndex = 16;
            this.excelButton.Text = "Показать в Excel";
            this.excelButton.UseVisualStyleBackColor = true;
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(389, 260);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 54);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 422);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.excelButton);
            this.Controls.Add(this.wordButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.accelerationTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.velocityTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Вычисление пути ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox velocityTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox accelerationTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button wordButton;
        private System.Windows.Forms.Button excelButton;
        private System.Windows.Forms.Button exitButton;
    }
}

