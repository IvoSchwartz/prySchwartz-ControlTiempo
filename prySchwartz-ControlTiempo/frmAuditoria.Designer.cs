namespace prySchwartz_ControlTiempo
{
    partial class frmAuditoria
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
            this.components = new System.ComponentModel.Container();
            this.pnlCoordenadas = new System.Windows.Forms.Panel();
            this.lstCordenadas = new System.Windows.Forms.ListBox();
            this.btnAuditoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlCoordenadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCoordenadas
            // 
            this.pnlCoordenadas.Controls.Add(this.lstCordenadas);
            this.pnlCoordenadas.Location = new System.Drawing.Point(15, 12);
            this.pnlCoordenadas.Name = "pnlCoordenadas";
            this.pnlCoordenadas.Size = new System.Drawing.Size(376, 225);
            this.pnlCoordenadas.TabIndex = 0;
            // 
            // lstCordenadas
            // 
            this.lstCordenadas.FormattingEnabled = true;
            this.lstCordenadas.Location = new System.Drawing.Point(0, 0);
            this.lstCordenadas.Name = "lstCordenadas";
            this.lstCordenadas.Size = new System.Drawing.Size(376, 225);
            this.lstCordenadas.TabIndex = 1;
            // 
            // btnAuditoria
            // 
            this.btnAuditoria.Location = new System.Drawing.Point(316, 291);
            this.btnAuditoria.Name = "btnAuditoria";
            this.btnAuditoria.Size = new System.Drawing.Size(75, 23);
            this.btnAuditoria.TabIndex = 2;
            this.btnAuditoria.Text = "Auditoria";
            this.btnAuditoria.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tiempo de trabajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lugares";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(130, 301);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(55, 13);
            this.lblTiempo.TabIndex = 5;
            this.lblTiempo.Text = "Segundos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "-";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 357);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAuditoria);
            this.Controls.Add(this.pnlCoordenadas);
            this.Name = "frmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAuditoria";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            this.pnlCoordenadas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCoordenadas;
        private System.Windows.Forms.ListBox lstCordenadas;
        private System.Windows.Forms.Button btnAuditoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer;
    }
}