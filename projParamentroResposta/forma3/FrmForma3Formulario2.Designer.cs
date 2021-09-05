
namespace projParamentroResposta.forma3
{
    partial class FrmForma3Formulario2
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
            this.btnDevolver = new System.Windows.Forms.Button();
            this.txtRespostaDevolver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParametroRecebido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDevolver
            // 
            this.btnDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.Location = new System.Drawing.Point(195, 195);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(190, 35);
            this.btnDevolver.TabIndex = 19;
            this.btnDevolver.Text = "Devolver para Form 2";
            this.btnDevolver.UseVisualStyleBackColor = true;
            // 
            // txtRespostaDevolver
            // 
            this.txtRespostaDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespostaDevolver.Location = new System.Drawing.Point(37, 143);
            this.txtRespostaDevolver.Name = "txtRespostaDevolver";
            this.txtRespostaDevolver.Size = new System.Drawing.Size(348, 26);
            this.txtRespostaDevolver.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Resposta para Devolver:";
            // 
            // txtParametroRecebido
            // 
            this.txtParametroRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametroRecebido.Location = new System.Drawing.Point(37, 61);
            this.txtParametroRecebido.Name = "txtParametroRecebido";
            this.txtParametroRecebido.Size = new System.Drawing.Size(348, 26);
            this.txtParametroRecebido.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Parâmetro Recebido:";
            // 
            // FrmForma3Formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 266);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.txtRespostaDevolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParametroRecebido);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmForma3Formulario2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmForma3Formulario2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.TextBox txtRespostaDevolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParametroRecebido;
        private System.Windows.Forms.Label label1;
    }
}