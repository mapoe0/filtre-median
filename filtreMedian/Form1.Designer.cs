
namespace filtreMedian
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pbTraitement = new System.Windows.Forms.PictureBox();
            this.pbTraintement2 = new System.Windows.Forms.PictureBox();
            this.btnTriABulles = new System.Windows.Forms.Button();
            this.btnNoirEtBlanc = new System.Windows.Forms.Button();
            this.btnFiltreMedian = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraitement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraintement2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(90, 73);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(400, 400);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // pbTraitement
            // 
            this.pbTraitement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTraitement.Location = new System.Drawing.Point(549, 73);
            this.pbTraitement.Name = "pbTraitement";
            this.pbTraitement.Size = new System.Drawing.Size(400, 400);
            this.pbTraitement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTraitement.TabIndex = 1;
            this.pbTraitement.TabStop = false;
            // 
            // pbTraintement2
            // 
            this.pbTraintement2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTraintement2.Location = new System.Drawing.Point(1008, 73);
            this.pbTraintement2.Name = "pbTraintement2";
            this.pbTraintement2.Size = new System.Drawing.Size(400, 400);
            this.pbTraintement2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTraintement2.TabIndex = 2;
            this.pbTraintement2.TabStop = false;
            // 
            // btnTriABulles
            // 
            this.btnTriABulles.Location = new System.Drawing.Point(181, 501);
            this.btnTriABulles.Name = "btnTriABulles";
            this.btnTriABulles.Size = new System.Drawing.Size(246, 23);
            this.btnTriABulles.TabIndex = 3;
            this.btnTriABulles.Text = "Tri à bulles";
            this.btnTriABulles.UseVisualStyleBackColor = true;
            this.btnTriABulles.Click += new System.EventHandler(this.btnTriABulles_Click);
            // 
            // btnNoirEtBlanc
            // 
            this.btnNoirEtBlanc.Location = new System.Drawing.Point(638, 500);
            this.btnNoirEtBlanc.Name = "btnNoirEtBlanc";
            this.btnNoirEtBlanc.Size = new System.Drawing.Size(246, 23);
            this.btnNoirEtBlanc.TabIndex = 4;
            this.btnNoirEtBlanc.Text = "Noir et Blanc";
            this.btnNoirEtBlanc.UseVisualStyleBackColor = true;
            this.btnNoirEtBlanc.Click += new System.EventHandler(this.btnNoirEtBlanc_Click);
            // 
            // btnFiltreMedian
            // 
            this.btnFiltreMedian.Location = new System.Drawing.Point(1117, 501);
            this.btnFiltreMedian.Name = "btnFiltreMedian";
            this.btnFiltreMedian.Size = new System.Drawing.Size(246, 23);
            this.btnFiltreMedian.TabIndex = 5;
            this.btnFiltreMedian.Text = "Filtre Médian";
            this.btnFiltreMedian.UseVisualStyleBackColor = true;
            this.btnFiltreMedian.Click += new System.EventHandler(this.btnFiltreMedian_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 686);
            this.Controls.Add(this.btnFiltreMedian);
            this.Controls.Add(this.btnNoirEtBlanc);
            this.Controls.Add(this.btnTriABulles);
            this.Controls.Add(this.pbTraintement2);
            this.Controls.Add(this.pbTraitement);
            this.Controls.Add(this.pbImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraitement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraintement2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pbTraitement;
        private System.Windows.Forms.PictureBox pbTraintement2;
        private System.Windows.Forms.Button btnTriABulles;
        private System.Windows.Forms.Button btnNoirEtBlanc;
        private System.Windows.Forms.Button btnFiltreMedian;
    }
}

