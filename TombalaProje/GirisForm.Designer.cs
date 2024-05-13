
namespace TombalaProje
{
    partial class GirisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbOyuncuAdet = new System.Windows.Forms.ComboBox();
            this.txtIsim1 = new System.Windows.Forms.TextBox();
            this.txtIsim2 = new System.Windows.Forms.TextBox();
            this.txtIsim3 = new System.Windows.Forms.TextBox();
            this.txtIsim4 = new System.Windows.Forms.TextBox();
            this.lblIsim1 = new System.Windows.Forms.Label();
            this.lblIsim2 = new System.Windows.Forms.Label();
            this.lblIsim3 = new System.Windows.Forms.Label();
            this.gbOyuncuLabel = new System.Windows.Forms.GroupBox();
            this.gbOyuncuText = new System.Windows.Forms.GroupBox();
            this.lblIsim4 = new System.Windows.Forms.Label();
            this.lblSecilenIndex = new System.Windows.Forms.Label();
            this.gbOyuncuLabel.SuspendLayout();
            this.gbOyuncuText.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyuncu Adet:";
            // 
            // cbOyuncuAdet
            // 
            this.cbOyuncuAdet.AllowDrop = true;
            this.cbOyuncuAdet.FormattingEnabled = true;
            this.cbOyuncuAdet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbOyuncuAdet.Location = new System.Drawing.Point(112, 26);
            this.cbOyuncuAdet.Name = "cbOyuncuAdet";
            this.cbOyuncuAdet.Size = new System.Drawing.Size(130, 24);
            this.cbOyuncuAdet.TabIndex = 1;
            this.cbOyuncuAdet.SelectedIndexChanged += new System.EventHandler(this.cbOyuncuAdet_SelectedIndexChanged);
            // 
            // txtIsim1
            // 
            this.txtIsim1.Location = new System.Drawing.Point(6, 21);
            this.txtIsim1.Name = "txtIsim1";
            this.txtIsim1.Size = new System.Drawing.Size(130, 22);
            this.txtIsim1.TabIndex = 2;
            // 
            // txtIsim2
            // 
            this.txtIsim2.Location = new System.Drawing.Point(6, 49);
            this.txtIsim2.Name = "txtIsim2";
            this.txtIsim2.Size = new System.Drawing.Size(130, 22);
            this.txtIsim2.TabIndex = 3;
            // 
            // txtIsim3
            // 
            this.txtIsim3.Location = new System.Drawing.Point(6, 77);
            this.txtIsim3.Name = "txtIsim3";
            this.txtIsim3.Size = new System.Drawing.Size(130, 22);
            this.txtIsim3.TabIndex = 4;
            // 
            // txtIsim4
            // 
            this.txtIsim4.Location = new System.Drawing.Point(6, 105);
            this.txtIsim4.Name = "txtIsim4";
            this.txtIsim4.Size = new System.Drawing.Size(130, 22);
            this.txtIsim4.TabIndex = 5;
            // 
            // lblIsim1
            // 
            this.lblIsim1.AutoSize = true;
            this.lblIsim1.Location = new System.Drawing.Point(14, 24);
            this.lblIsim1.Name = "lblIsim1";
            this.lblIsim1.Size = new System.Drawing.Size(77, 17);
            this.lblIsim1.TabIndex = 22;
            this.lblIsim1.Text = "1. Oyuncu:";
            // 
            // lblIsim2
            // 
            this.lblIsim2.AutoSize = true;
            this.lblIsim2.Location = new System.Drawing.Point(14, 52);
            this.lblIsim2.Name = "lblIsim2";
            this.lblIsim2.Size = new System.Drawing.Size(77, 17);
            this.lblIsim2.TabIndex = 23;
            this.lblIsim2.Text = "2. Oyuncu:";
            // 
            // lblIsim3
            // 
            this.lblIsim3.AutoSize = true;
            this.lblIsim3.Location = new System.Drawing.Point(14, 80);
            this.lblIsim3.Name = "lblIsim3";
            this.lblIsim3.Size = new System.Drawing.Size(77, 17);
            this.lblIsim3.TabIndex = 24;
            this.lblIsim3.Text = "3. Oyuncu:";
            // 
            // gbOyuncuLabel
            // 
            this.gbOyuncuLabel.Controls.Add(this.lblIsim4);
            this.gbOyuncuLabel.Controls.Add(this.lblIsim3);
            this.gbOyuncuLabel.Controls.Add(this.lblIsim2);
            this.gbOyuncuLabel.Controls.Add(this.lblIsim1);
            this.gbOyuncuLabel.Location = new System.Drawing.Point(15, 56);
            this.gbOyuncuLabel.Name = "gbOyuncuLabel";
            this.gbOyuncuLabel.Size = new System.Drawing.Size(100, 138);
            this.gbOyuncuLabel.TabIndex = 42;
            this.gbOyuncuLabel.TabStop = false;
            // 
            // gbOyuncuText
            // 
            this.gbOyuncuText.Controls.Add(this.txtIsim1);
            this.gbOyuncuText.Controls.Add(this.txtIsim2);
            this.gbOyuncuText.Controls.Add(this.txtIsim3);
            this.gbOyuncuText.Controls.Add(this.txtIsim4);
            this.gbOyuncuText.Location = new System.Drawing.Point(116, 56);
            this.gbOyuncuText.Name = "gbOyuncuText";
            this.gbOyuncuText.Size = new System.Drawing.Size(156, 138);
            this.gbOyuncuText.TabIndex = 43;
            this.gbOyuncuText.TabStop = false;
            // 
            // lblIsim4
            // 
            this.lblIsim4.AutoSize = true;
            this.lblIsim4.Location = new System.Drawing.Point(14, 108);
            this.lblIsim4.Name = "lblIsim4";
            this.lblIsim4.Size = new System.Drawing.Size(77, 17);
            this.lblIsim4.TabIndex = 25;
            this.lblIsim4.Text = "4. Oyuncu:";
            // 
            // lblSecilenIndex
            // 
            this.lblSecilenIndex.AutoSize = true;
            this.lblSecilenIndex.Location = new System.Drawing.Point(288, 224);
            this.lblSecilenIndex.Name = "lblSecilenIndex";
            this.lblSecilenIndex.Size = new System.Drawing.Size(0, 17);
            this.lblSecilenIndex.TabIndex = 44;
            // 
            // GirisForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 269);
            this.Controls.Add(this.lblSecilenIndex);
            this.Controls.Add(this.gbOyuncuText);
            this.Controls.Add(this.gbOyuncuLabel);
            this.Controls.Add(this.cbOyuncuAdet);
            this.Controls.Add(this.label1);
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.GirisForm_Load);
            this.gbOyuncuLabel.ResumeLayout(false);
            this.gbOyuncuLabel.PerformLayout();
            this.gbOyuncuText.ResumeLayout(false);
            this.gbOyuncuText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOyuncuAdet;
        private System.Windows.Forms.TextBox txtIsim1;
        private System.Windows.Forms.TextBox txtIsim2;
        private System.Windows.Forms.TextBox txtIsim3;
        private System.Windows.Forms.TextBox txtIsim4;
        private System.Windows.Forms.Label lblIsim1;
        private System.Windows.Forms.Label lblIsim2;
        private System.Windows.Forms.Label lblIsim3;
        private System.Windows.Forms.GroupBox gbOyuncuLabel;
        private System.Windows.Forms.GroupBox gbOyuncuText;
        private System.Windows.Forms.Label lblIsim4;
        private System.Windows.Forms.Label lblSecilenIndex;
    }
}