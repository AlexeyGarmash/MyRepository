namespace Metropolitan
{
    partial class Board
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.label5 = new System.Windows.Forms.Label();
            this.NowTime = new System.Windows.Forms.Label();
            this.SomeText = new System.Windows.Forms.Label();
            this.SomeText_2 = new System.Windows.Forms.Label();
            this.ArriveTime = new System.Windows.Forms.Label();
            this.TimerNow = new System.Windows.Forms.Timer(this.components);
            this.TimerArrive = new System.Windows.Forms.Timer(this.components);
            this.TimerString = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.If_InTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 73);
            this.label5.TabIndex = 11;
            this.label5.Text = "Точний час";
            // 
            // NowTime
            // 
            this.NowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NowTime.ForeColor = System.Drawing.SystemColors.Info;
            this.NowTime.Location = new System.Drawing.Point(554, 9);
            this.NowTime.Name = "NowTime";
            this.NowTime.Size = new System.Drawing.Size(451, 73);
            this.NowTime.TabIndex = 12;
            this.NowTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SomeText
            // 
            this.SomeText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SomeText.AutoSize = true;
            this.SomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SomeText.ForeColor = System.Drawing.Color.Gold;
            this.SomeText.Location = new System.Drawing.Point(140, 114);
            this.SomeText.Name = "SomeText";
            this.SomeText.Size = new System.Drawing.Size(757, 73);
            this.SomeText.TabIndex = 13;
            this.SomeText.Text = "Час з моменту відбуття";
            // 
            // SomeText_2
            // 
            this.SomeText_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SomeText_2.AutoSize = true;
            this.SomeText_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SomeText_2.ForeColor = System.Drawing.Color.Gold;
            this.SomeText_2.Location = new System.Drawing.Point(189, 211);
            this.SomeText_2.Name = "SomeText_2";
            this.SomeText_2.Size = new System.Drawing.Size(654, 73);
            this.SomeText_2.TabIndex = 14;
            this.SomeText_2.Text = "Time since departure";
            // 
            // ArriveTime
            // 
            this.ArriveTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArriveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArriveTime.ForeColor = System.Drawing.SystemColors.Info;
            this.ArriveTime.Location = new System.Drawing.Point(12, 284);
            this.ArriveTime.Name = "ArriveTime";
            this.ArriveTime.Size = new System.Drawing.Size(993, 233);
            this.ArriveTime.TabIndex = 15;
            this.ArriveTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerNow
            // 
            this.TimerNow.Tick += new System.EventHandler(this.TimerNow_Tick);
            // 
            // TimerArrive
            // 
            this.TimerArrive.Tick += new System.EventHandler(this.TimerDeparture_Tick);
            // 
            // TimerString
            // 
            this.TimerString.Tick += new System.EventHandler(this.TimerString_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 119);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(505, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 55);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1017, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ArriveTime);
            this.Controls.Add(this.SomeText_2);
            this.Controls.Add(this.SomeText);
            this.Controls.Add(this.NowTime);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Board";
            this.Text = "Табло";
            this.Load += new System.EventHandler(this.Board_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NowTime;
        private System.Windows.Forms.Label SomeText;
        private System.Windows.Forms.Label SomeText_2;
        private System.Windows.Forms.Label ArriveTime;
        private System.Windows.Forms.Timer TimerNow;
        private System.Windows.Forms.Timer TimerArrive;
        private System.Windows.Forms.Timer TimerString;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer If_InTime;
    }
}

