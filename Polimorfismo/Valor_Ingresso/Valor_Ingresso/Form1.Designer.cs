namespace Valor_Ingresso
{
    partial class Form1
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
            this.btnVip = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnCamarote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVip
            // 
            this.btnVip.Location = new System.Drawing.Point(176, 12);
            this.btnVip.Name = "btnVip";
            this.btnVip.Size = new System.Drawing.Size(102, 38);
            this.btnVip.TabIndex = 0;
            this.btnVip.Text = "VIP";
            this.btnVip.UseVisualStyleBackColor = true;
            this.btnVip.Click += new System.EventHandler(this.btnVip_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(34, 12);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(102, 38);
            this.btnNormal.TabIndex = 1;
            this.btnNormal.Text = "Ingresso Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnCamarote
            // 
            this.btnCamarote.Location = new System.Drawing.Point(34, 91);
            this.btnCamarote.Name = "btnCamarote";
            this.btnCamarote.Size = new System.Drawing.Size(102, 38);
            this.btnCamarote.TabIndex = 2;
            this.btnCamarote.Text = "Camarote Inferior";
            this.btnCamarote.UseVisualStyleBackColor = true;
            this.btnCamarote.Click += new System.EventHandler(this.btnCamarote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 144);
            this.Controls.Add(this.btnCamarote);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnVip);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVip;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnCamarote;
    }
}

