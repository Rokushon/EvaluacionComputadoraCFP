namespace FormPrincipal
{
    partial class FormPrincipal
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
            dgv_computadoras = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_computadoras).BeginInit();
            SuspendLayout();
            // 
            // dgv_computadoras
            // 
            dgv_computadoras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_computadoras.Location = new Point(35, 28);
            dgv_computadoras.Name = "dgv_computadoras";
            dgv_computadoras.Size = new Size(846, 383);
            dgv_computadoras.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(391, 437);
            button1.Name = "button1";
            button1.Size = new Size(160, 23);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 493);
            Controls.Add(button1);
            Controls.Add(dgv_computadoras);
            Name = "FormPrincipal";
            Text = "Computadoras";
            Load += this.FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_computadoras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_computadoras;
        private Button button1;
    }
}
