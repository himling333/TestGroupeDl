namespace Calculatrice2
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
            this.components = new System.ComponentModel.Container();
            this.button_calculer = new System.Windows.Forms.Button();
            this.button_annuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_number1 = new System.Windows.Forms.TextBox();
            this.text_number2 = new System.Windows.Forms.TextBox();
            this.text_resultat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_operation = new System.Windows.Forms.GroupBox();
            this.radio_div = new System.Windows.Forms.RadioButton();
            this.radio_mul = new System.Windows.Forms.RadioButton();
            this.radio_sous = new System.Windows.Forms.RadioButton();
            this.radio_add = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_operation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_calculer
            // 
            this.button_calculer.Location = new System.Drawing.Point(138, 356);
            this.button_calculer.Name = "button_calculer";
            this.button_calculer.Size = new System.Drawing.Size(75, 23);
            this.button_calculer.TabIndex = 0;
            this.button_calculer.Text = "Calculer";
            this.button_calculer.UseVisualStyleBackColor = true;
            this.button_calculer.Click += new System.EventHandler(this.button_calculer_Click);
            // 
            // button_annuler
            // 
            this.button_annuler.Location = new System.Drawing.Point(341, 356);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(75, 23);
            this.button_annuler.TabIndex = 1;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = true;
            this.button_annuler.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre 2 :";
            // 
            // text_number1
            // 
            this.text_number1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.text_number1.Location = new System.Drawing.Point(177, 76);
            this.text_number1.Name = "text_number1";
            this.text_number1.Size = new System.Drawing.Size(100, 20);
            this.text_number1.TabIndex = 4;
            this.text_number1.TextChanged += new System.EventHandler(this.text_number1_TextChanged);
            // 
            // text_number2
            // 
            this.text_number2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.text_number2.Location = new System.Drawing.Point(177, 142);
            this.text_number2.Name = "text_number2";
            this.text_number2.Size = new System.Drawing.Size(100, 20);
            this.text_number2.TabIndex = 5;
            this.text_number2.TextChanged += new System.EventHandler(this.text_number2_TextChanged);
            // 
            // text_resultat
            // 
            this.text_resultat.Enabled = false;
            this.text_resultat.Location = new System.Drawing.Point(177, 222);
            this.text_resultat.Name = "text_resultat";
            this.text_resultat.Size = new System.Drawing.Size(100, 20);
            this.text_resultat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Résultat :";
            // 
            // label_operation
            // 
            this.label_operation.Controls.Add(this.radio_div);
            this.label_operation.Controls.Add(this.radio_mul);
            this.label_operation.Controls.Add(this.radio_sous);
            this.label_operation.Controls.Add(this.radio_add);
            this.label_operation.Location = new System.Drawing.Point(357, 75);
            this.label_operation.Name = "label_operation";
            this.label_operation.Size = new System.Drawing.Size(172, 200);
            this.label_operation.TabIndex = 8;
            this.label_operation.TabStop = false;
            this.label_operation.Text = "Opérations";
            // 
            // radio_div
            // 
            this.radio_div.AutoSize = true;
            this.radio_div.Location = new System.Drawing.Point(27, 160);
            this.radio_div.Name = "radio_div";
            this.radio_div.Size = new System.Drawing.Size(62, 17);
            this.radio_div.TabIndex = 3;
            this.radio_div.TabStop = true;
            this.radio_div.Text = "Division";
            this.radio_div.UseVisualStyleBackColor = true;
            this.radio_div.CheckedChanged += new System.EventHandler(this.radio_div_CheckedChanged);
            // 
            // radio_mul
            // 
            this.radio_mul.AutoSize = true;
            this.radio_mul.Location = new System.Drawing.Point(27, 115);
            this.radio_mul.Name = "radio_mul";
            this.radio_mul.Size = new System.Drawing.Size(86, 17);
            this.radio_mul.TabIndex = 2;
            this.radio_mul.TabStop = true;
            this.radio_mul.Text = "Multiplication";
            this.radio_mul.UseVisualStyleBackColor = true;
            this.radio_mul.CheckedChanged += new System.EventHandler(this.radio_mul_CheckedChanged);
            // 
            // radio_sous
            // 
            this.radio_sous.AutoSize = true;
            this.radio_sous.Location = new System.Drawing.Point(27, 69);
            this.radio_sous.Name = "radio_sous";
            this.radio_sous.Size = new System.Drawing.Size(84, 17);
            this.radio_sous.TabIndex = 1;
            this.radio_sous.TabStop = true;
            this.radio_sous.Text = "Soustraction";
            this.radio_sous.UseVisualStyleBackColor = true;
            this.radio_sous.CheckedChanged += new System.EventHandler(this.radio_sous_CheckedChanged);
            // 
            // radio_add
            // 
            this.radio_add.AutoSize = true;
            this.radio_add.Checked = true;
            this.radio_add.Location = new System.Drawing.Point(27, 31);
            this.radio_add.Name = "radio_add";
            this.radio_add.Size = new System.Drawing.Size(63, 17);
            this.radio_add.TabIndex = 0;
            this.radio_add.TabStop = true;
            this.radio_add.Text = "Addition";
            this.radio_add.UseVisualStyleBackColor = true;
            this.radio_add.CheckedChanged += new System.EventHandler(this.radio_add_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 411);
            this.Controls.Add(this.label_operation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_resultat);
            this.Controls.Add(this.text_number2);
            this.Controls.Add(this.text_number1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_annuler);
            this.Controls.Add(this.button_calculer);
            this.Name = "Form1";
            this.Text = "Calculatrice";
            this.label_operation.ResumeLayout(false);
            this.label_operation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calculer;
        private System.Windows.Forms.Button button_annuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_number1;
        private System.Windows.Forms.TextBox text_number2;
        private System.Windows.Forms.TextBox text_resultat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox label_operation;
        private System.Windows.Forms.RadioButton radio_div;
        private System.Windows.Forms.RadioButton radio_mul;
        private System.Windows.Forms.RadioButton radio_sous;
        private System.Windows.Forms.RadioButton radio_add;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

