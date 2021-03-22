
namespace RSA_University_project_Vysochina
{
    partial class Test_tool_rand
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
            this.btn_GenerateRandSeed = new System.Windows.Forms.Button();
            this.tb_ManualRandSeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_passive_MainRandseed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SaveManualRandSeed = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_CurrentRandomValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_passive_CurrentRandseed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_RangeMax = new System.Windows.Forms.TextBox();
            this.tb_RangeMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_SaveRange = new System.Windows.Forms.Button();
            this.btn_GenerateNextNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GenerateRandSeed
            // 
            this.btn_GenerateRandSeed.Location = new System.Drawing.Point(12, 15);
            this.btn_GenerateRandSeed.Name = "btn_GenerateRandSeed";
            this.btn_GenerateRandSeed.Size = new System.Drawing.Size(498, 29);
            this.btn_GenerateRandSeed.TabIndex = 0;
            this.btn_GenerateRandSeed.Text = "Автоматически сгенерировать зерно рандома";
            this.btn_GenerateRandSeed.UseVisualStyleBackColor = true;
            // 
            // tb_ManualRandSeed
            // 
            this.tb_ManualRandSeed.Location = new System.Drawing.Point(12, 79);
            this.tb_ManualRandSeed.Name = "tb_ManualRandSeed";
            this.tb_ManualRandSeed.Size = new System.Drawing.Size(372, 22);
            this.tb_ManualRandSeed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Начальное зерно для последовательности";
            // 
            // tb_passive_MainRandseed
            // 
            this.tb_passive_MainRandseed.Enabled = false;
            this.tb_passive_MainRandseed.Location = new System.Drawing.Point(309, 210);
            this.tb_passive_MainRandseed.Name = "tb_passive_MainRandseed";
            this.tb_passive_MainRandseed.Size = new System.Drawing.Size(201, 22);
            this.tb_passive_MainRandseed.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Задать значение зерна вручную";
            // 
            // btn_SaveManualRandSeed
            // 
            this.btn_SaveManualRandSeed.Location = new System.Drawing.Point(390, 76);
            this.btn_SaveManualRandSeed.Name = "btn_SaveManualRandSeed";
            this.btn_SaveManualRandSeed.Size = new System.Drawing.Size(120, 28);
            this.btn_SaveManualRandSeed.TabIndex = 5;
            this.btn_SaveManualRandSeed.Text = "Сохранить";
            this.btn_SaveManualRandSeed.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сгенерированное псевдослучайное число";
            // 
            // tb_CurrentRandomValue
            // 
            this.tb_CurrentRandomValue.Enabled = false;
            this.tb_CurrentRandomValue.Location = new System.Drawing.Point(9, 365);
            this.tb_CurrentRandomValue.Name = "tb_CurrentRandomValue";
            this.tb_CurrentRandomValue.Size = new System.Drawing.Size(497, 22);
            this.tb_CurrentRandomValue.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Текущее значение зерна";
            // 
            // tb_passive_CurrentRandseed
            // 
            this.tb_passive_CurrentRandseed.Enabled = false;
            this.tb_passive_CurrentRandseed.Location = new System.Drawing.Point(309, 251);
            this.tb_passive_CurrentRandseed.Name = "tb_passive_CurrentRandseed";
            this.tb_passive_CurrentRandseed.Size = new System.Drawing.Size(201, 22);
            this.tb_passive_CurrentRandseed.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Задать границы для сгенерированного числа";
            // 
            // tb_RangeMax
            // 
            this.tb_RangeMax.Location = new System.Drawing.Point(42, 175);
            this.tb_RangeMax.Name = "tb_RangeMax";
            this.tb_RangeMax.Size = new System.Drawing.Size(342, 22);
            this.tb_RangeMax.TabIndex = 12;
            // 
            // tb_RangeMin
            // 
            this.tb_RangeMin.Location = new System.Drawing.Point(42, 134);
            this.tb_RangeMin.Name = "tb_RangeMin";
            this.tb_RangeMin.Size = new System.Drawing.Size(342, 22);
            this.tb_RangeMin.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "От";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "До";
            // 
            // btn_SaveRange
            // 
            this.btn_SaveRange.Location = new System.Drawing.Point(390, 134);
            this.btn_SaveRange.Name = "btn_SaveRange";
            this.btn_SaveRange.Size = new System.Drawing.Size(120, 63);
            this.btn_SaveRange.TabIndex = 15;
            this.btn_SaveRange.Text = "Сохранить";
            this.btn_SaveRange.UseVisualStyleBackColor = true;
            // 
            // btn_GenerateNextNumber
            // 
            this.btn_GenerateNextNumber.Location = new System.Drawing.Point(12, 294);
            this.btn_GenerateNextNumber.Name = "btn_GenerateNextNumber";
            this.btn_GenerateNextNumber.Size = new System.Drawing.Size(498, 48);
            this.btn_GenerateNextNumber.TabIndex = 16;
            this.btn_GenerateNextNumber.Text = "Сгенерировать следующее число последовательности";
            this.btn_GenerateNextNumber.UseVisualStyleBackColor = true;
            // 
            // Test_tool_rand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 403);
            this.Controls.Add(this.btn_GenerateNextNumber);
            this.Controls.Add(this.btn_SaveRange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_RangeMax);
            this.Controls.Add(this.tb_RangeMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_passive_CurrentRandseed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_CurrentRandomValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_SaveManualRandSeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_passive_MainRandseed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ManualRandSeed);
            this.Controls.Add(this.btn_GenerateRandSeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Test_tool_rand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random generator (testing tool)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GenerateRandSeed;
        private System.Windows.Forms.TextBox tb_ManualRandSeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_passive_MainRandseed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SaveManualRandSeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_CurrentRandomValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_passive_CurrentRandseed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_RangeMax;
        private System.Windows.Forms.TextBox tb_RangeMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_SaveRange;
        private System.Windows.Forms.Button btn_GenerateNextNumber;
    }
}

