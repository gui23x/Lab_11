
namespace Lab_12.View
{
    partial class Telaprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telaprincipal));
            this.btnLer = new System.Windows.Forms.Button();
            this.lbxInfo = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLer
            // 
            this.btnLer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLer.Font = new System.Drawing.Font("AcadEref", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLer.Location = new System.Drawing.Point(157, 70);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(203, 66);
            this.btnLer.TabIndex = 0;
            this.btnLer.Text = "Ler";
            this.btnLer.UseVisualStyleBackColor = false;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // lbxInfo
            // 
            this.lbxInfo.FormattingEnabled = true;
            this.lbxInfo.ItemHeight = 15;
            this.lbxInfo.Location = new System.Drawing.Point(35, 159);
            this.lbxInfo.Name = "lbxInfo";
            this.lbxInfo.Size = new System.Drawing.Size(454, 259);
            this.lbxInfo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(76, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(391, 30);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Ver Texto com informações delimitadas";
            // 
            // Telaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lbxInfo);
            this.Controls.Add(this.btnLer);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Telaprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitor de Texto Deimitado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.ListBox lbxInfo;
        private System.Windows.Forms.Label lblTitulo;
    }
}