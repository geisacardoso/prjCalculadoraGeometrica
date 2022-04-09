
namespace prjCalculadoraGeométrica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbCalculos = new System.Windows.Forms.GroupBox();
            this.rbVolume = new System.Windows.Forms.RadioButton();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.rbPerimetro = new System.Windows.Forms.RadioButton();
            this.lbRaio = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.chkbDesenhar = new System.Windows.Forms.CheckBox();
            this.pn = new System.Windows.Forms.Panel();
            this.gbCalculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCalculos
            // 
            this.gbCalculos.Controls.Add(this.rbVolume);
            this.gbCalculos.Controls.Add(this.rbArea);
            this.gbCalculos.Controls.Add(this.rbPerimetro);
            this.gbCalculos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbCalculos.Location = new System.Drawing.Point(2, 12);
            this.gbCalculos.Name = "gbCalculos";
            this.gbCalculos.Size = new System.Drawing.Size(273, 229);
            this.gbCalculos.TabIndex = 0;
            this.gbCalculos.TabStop = false;
            this.gbCalculos.Text = "Calculos";
            // 
            // rbVolume
            // 
            this.rbVolume.AutoSize = true;
            this.rbVolume.Location = new System.Drawing.Point(22, 148);
            this.rbVolume.Name = "rbVolume";
            this.rbVolume.Size = new System.Drawing.Size(65, 19);
            this.rbVolume.TabIndex = 2;
            this.rbVolume.Text = "Volume";
            this.rbVolume.UseVisualStyleBackColor = true;
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Location = new System.Drawing.Point(22, 92);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(49, 19);
            this.rbArea.TabIndex = 1;
            this.rbArea.Text = "Área";
            this.rbArea.UseVisualStyleBackColor = true;
            // 
            // rbPerimetro
            // 
            this.rbPerimetro.AutoSize = true;
            this.rbPerimetro.Checked = true;
            this.rbPerimetro.Location = new System.Drawing.Point(22, 35);
            this.rbPerimetro.Name = "rbPerimetro";
            this.rbPerimetro.Size = new System.Drawing.Size(73, 19);
            this.rbPerimetro.TabIndex = 0;
            this.rbPerimetro.TabStop = true;
            this.rbPerimetro.Text = "Peímetro";
            this.rbPerimetro.UseVisualStyleBackColor = true;
            // 
            // lbRaio
            // 
            this.lbRaio.AutoSize = true;
            this.lbRaio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRaio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbRaio.Location = new System.Drawing.Point(325, 9);
            this.lbRaio.Name = "lbRaio";
            this.lbRaio.Size = new System.Drawing.Size(144, 17);
            this.lbRaio.TabIndex = 1;
            this.lbRaio.Text = "Raio do Círculo em cm:";
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(294, 47);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(193, 23);
            this.txtRaio.TabIndex = 2;
            this.txtRaio.Text = "0";
            this.txtRaio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCalcular.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btCalcular.Location = new System.Drawing.Point(325, 92);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(102, 42);
            this.btCalcular.TabIndex = 3;
            this.btCalcular.Text = "calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.BackColor = System.Drawing.Color.Transparent;
            this.lblResposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResposta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResposta.Location = new System.Drawing.Point(281, 148);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(193, 93);
            this.lblResposta.TabIndex = 4;
            this.lblResposta.Text = "resposta";
            this.lblResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkbDesenhar
            // 
            this.chkbDesenhar.AutoSize = true;
            this.chkbDesenhar.Location = new System.Drawing.Point(506, 10);
            this.chkbDesenhar.Name = "chkbDesenhar";
            this.chkbDesenhar.Size = new System.Drawing.Size(117, 19);
            this.chkbDesenhar.TabIndex = 5;
            this.chkbDesenhar.Text = "Desenhar círculo.";
            this.chkbDesenhar.UseVisualStyleBackColor = true;
            this.chkbDesenhar.CheckedChanged += new System.EventHandler(this.chkbDesenhar_CheckedChanged);
            // 
            // pn
            // 
            this.pn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn.Location = new System.Drawing.Point(506, 35);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(263, 206);
            this.pn.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(803, 253);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.chkbDesenhar);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.lbRaio);
            this.Controls.Add(this.gbCalculos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CALCULADORA GEOMÉTRICA";
            this.gbCalculos.ResumeLayout(false);
            this.gbCalculos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCalculos;
        private System.Windows.Forms.RadioButton rbVolume;
        private System.Windows.Forms.RadioButton rbArea;
        private System.Windows.Forms.RadioButton rbPerimetro;
        private System.Windows.Forms.Label lbRaio;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.CheckBox chkbDesenhar;
        private System.Windows.Forms.Panel pn;
    }
}

