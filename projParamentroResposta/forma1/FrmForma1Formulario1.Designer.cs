﻿
namespace projParamentroResposta.forma1
{
    partial class FrmForma1Formulario1
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
            this.txtParametroEnviar = new System.Windows.Forms.TextBox();
            this.txtRespostaRecebida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parâmetro para Enviar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtParametroEnviar
            // 
            this.txtParametroEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametroEnviar.Location = new System.Drawing.Point(36, 50);
            this.txtParametroEnviar.Name = "txtParametroEnviar";
            this.txtParametroEnviar.Size = new System.Drawing.Size(348, 26);
            this.txtParametroEnviar.TabIndex = 1;
            // 
            // txtRespostaRecebida
            // 
            this.txtRespostaRecebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespostaRecebida.Location = new System.Drawing.Point(36, 172);
            this.txtRespostaRecebida.Name = "txtRespostaRecebida";
            this.txtRespostaRecebida.Size = new System.Drawing.Size(348, 26);
            this.txtRespostaRecebida.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reposta Recebida:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(237, 96);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(147, 35);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar para Form 2";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // FrmForma1Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 262);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtRespostaRecebida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParametroEnviar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmForma1Formulario1";
            this.ShowIcon = false;
            this.Text = "FrmForma1Formulario1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParametroEnviar;
        private System.Windows.Forms.TextBox txtRespostaRecebida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviar;
    }
}