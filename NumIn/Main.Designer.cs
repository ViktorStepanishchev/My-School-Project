
namespace NumIn
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundButton1 = new NumIn.RoundButton();
            this.roundButton2 = new NumIn.RoundButton();
            this.roundButton3 = new NumIn.RoundButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.roundButton3);
            this.panel1.Controls.Add(this.roundButton2);
            this.panel1.Controls.Add(this.roundButton1);
            this.panel1.Location = new System.Drawing.Point(-7, -18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 647);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(472, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 128);
            this.label1.TabIndex = 1;
            this.label1.Text = "NumIn";
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton1.BackColor2 = System.Drawing.Color.White;
            this.roundButton1.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.roundButton1.ButtonHighlightColor = System.Drawing.Color.Transparent;
            this.roundButton1.ButtonHighlightColor2 = System.Drawing.Color.Snow;
            this.roundButton1.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.roundButton1.ButtonPressedColor = System.Drawing.Color.White;
            this.roundButton1.ButtonPressedColor2 = System.Drawing.Color.White;
            this.roundButton1.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton1.ButtonRoundRadius = 60;
            this.roundButton1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton1.Location = new System.Drawing.Point(19, 515);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(239, 88);
            this.roundButton1.TabIndex = 2;
            this.roundButton1.Text = "Системы счислений";
            this.roundButton1.Click += new System.EventHandler(this.button3_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton2.BackColor2 = System.Drawing.Color.White;
            this.roundButton2.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.roundButton2.ButtonHighlightColor = System.Drawing.Color.Transparent;
            this.roundButton2.ButtonHighlightColor2 = System.Drawing.Color.Snow;
            this.roundButton2.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.roundButton2.ButtonPressedColor = System.Drawing.Color.White;
            this.roundButton2.ButtonPressedColor2 = System.Drawing.Color.White;
            this.roundButton2.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton2.ButtonRoundRadius = 60;
            this.roundButton2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton2.Location = new System.Drawing.Point(19, 286);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(239, 88);
            this.roundButton2.TabIndex = 3;
            this.roundButton2.Text = "Калькулятор";
            this.roundButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton3.BackColor2 = System.Drawing.Color.White;
            this.roundButton3.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.roundButton3.ButtonHighlightColor = System.Drawing.Color.Transparent;
            this.roundButton3.ButtonHighlightColor2 = System.Drawing.Color.Snow;
            this.roundButton3.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.roundButton3.ButtonPressedColor = System.Drawing.Color.White;
            this.roundButton3.ButtonPressedColor2 = System.Drawing.Color.White;
            this.roundButton3.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton3.ButtonRoundRadius = 60;
            this.roundButton3.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton3.Location = new System.Drawing.Point(19, 64);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(239, 88);
            this.roundButton3.TabIndex = 4;
            this.roundButton3.Text = "Дискриминант";
            this.roundButton3.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1031, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Numln";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private RoundButton roundButton3;
    }
}

