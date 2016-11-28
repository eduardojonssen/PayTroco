namespace PayTroco.UI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UxBtnPay = new System.Windows.Forms.Button();
            this.UxTxtInsertedAmount = new System.Windows.Forms.TextBox();
            this.UxTxtProductAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UxTxtChangeAmountInCoins = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UxTxtChangeAmountTotal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.UxTxtChangeAmountTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.UxBtnPay);
            this.panel1.Controls.Add(this.UxTxtChangeAmountInCoins);
            this.panel1.Controls.Add(this.UxTxtInsertedAmount);
            this.panel1.Controls.Add(this.UxTxtProductAmount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 426);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Inserido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor do Produto";
            // 
            // UxBtnPay
            // 
            this.UxBtnPay.Location = new System.Drawing.Point(208, 139);
            this.UxBtnPay.Name = "UxBtnPay";
            this.UxBtnPay.Size = new System.Drawing.Size(149, 36);
            this.UxBtnPay.TabIndex = 4;
            this.UxBtnPay.Text = "Pagar";
            this.UxBtnPay.UseVisualStyleBackColor = true;
            this.UxBtnPay.Click += new System.EventHandler(this.UxBtnPay_Click);
            // 
            // UxTxtInsertedAmount
            // 
            this.UxTxtInsertedAmount.Location = new System.Drawing.Point(168, 83);
            this.UxTxtInsertedAmount.Name = "UxTxtInsertedAmount";
            this.UxTxtInsertedAmount.Size = new System.Drawing.Size(222, 26);
            this.UxTxtInsertedAmount.TabIndex = 2;
            // 
            // UxTxtProductAmount
            // 
            this.UxTxtProductAmount.Location = new System.Drawing.Point(168, 41);
            this.UxTxtProductAmount.Name = "UxTxtProductAmount";
            this.UxTxtProductAmount.Size = new System.Drawing.Size(222, 26);
            this.UxTxtProductAmount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Troco em moedas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(126, 30);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem1});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.sobreToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(144, 30);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            this.sobreToolStripMenuItem1.Click += new System.EventHandler(this.sobreToolStripMenuItem1_Click);
            // 
            // UxTxtChangeAmountInCoins
            // 
            this.UxTxtChangeAmountInCoins.Location = new System.Drawing.Point(168, 282);
            this.UxTxtChangeAmountInCoins.Multiline = true;
            this.UxTxtChangeAmountInCoins.Name = "UxTxtChangeAmountInCoins";
            this.UxTxtChangeAmountInCoins.Size = new System.Drawing.Size(222, 111);
            this.UxTxtChangeAmountInCoins.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Troco Total";
            // 
            // UxTxtChangeAmountTotal
            // 
            this.UxTxtChangeAmountTotal.Location = new System.Drawing.Point(168, 222);
            this.UxTxtChangeAmountTotal.Name = "UxTxtChangeAmountTotal";
            this.UxTxtChangeAmountTotal.Size = new System.Drawing.Size(222, 26);
            this.UxTxtChangeAmountTotal.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.UxBtnPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayTroco";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UxBtnPay;
        private System.Windows.Forms.TextBox UxTxtInsertedAmount;
        private System.Windows.Forms.TextBox UxTxtProductAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.TextBox UxTxtChangeAmountInCoins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UxTxtChangeAmountTotal;
    }
}

