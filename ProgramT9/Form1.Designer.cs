namespace ProgramT9
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbInput = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lbOutput = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.lbAffichOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(27, 59);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(44, 13);
            this.lbInput.TabIndex = 1;
            this.lbInput.Text = "Entrée :";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(89, 59);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(250, 20);
            this.tbInput.TabIndex = 2;
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(27, 141);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(46, 13);
            this.lbOutput.TabIndex = 3;
            this.lbOutput.Text = "Résultat";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(89, 215);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(236, 215);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btAnnuler.TabIndex = 6;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // lbAffichOutput
            // 
            this.lbAffichOutput.AutoSize = true;
            this.lbAffichOutput.Location = new System.Drawing.Point(89, 141);
            this.lbAffichOutput.Name = "lbAffichOutput";
            this.lbAffichOutput.Size = new System.Drawing.Size(0, 13);
            this.lbAffichOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 257);
            this.Controls.Add(this.lbAffichOutput);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbInput);
            this.Name = "Form1";
            this.Text = "Programme T9 by Fadel Donatien 2020";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Label lbAffichOutput;
    }
}

