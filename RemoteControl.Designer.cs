namespace Metropolitan
{
    partial class RemoteControl
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
            this.AddNews = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GetReact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNews
            // 
            this.AddNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNews.Location = new System.Drawing.Point(12, 46);
            this.AddNews.Multiline = true;
            this.AddNews.Name = "AddNews";
            this.AddNews.Size = new System.Drawing.Size(585, 80);
            this.AddNews.TabIndex = 0;
            this.AddNews.TextChanged += new System.EventHandler(this.AddNews_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавить новость";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(522, 132);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(12, 201);
            this.Info.Multiline = true;
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Info.Size = new System.Drawing.Size(585, 145);
            this.Info.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Информация табла";
            // 
            // GetReact
            // 
            this.GetReact.Location = new System.Drawing.Point(522, 352);
            this.GetReact.Name = "GetReact";
            this.GetReact.Size = new System.Drawing.Size(75, 23);
            this.GetReact.TabIndex = 5;
            this.GetReact.Text = "Get";
            this.GetReact.UseVisualStyleBackColor = true;
            this.GetReact.Click += new System.EventHandler(this.GetReact_Click);
            // 
            // RemoteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 383);
            this.Controls.Add(this.GetReact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddNews);
            this.Name = "RemoteControl";
            this.Text = "RemoteControl";
            this.Load += new System.EventHandler(this.RemoteControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddNews;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox Info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetReact;
    }
}