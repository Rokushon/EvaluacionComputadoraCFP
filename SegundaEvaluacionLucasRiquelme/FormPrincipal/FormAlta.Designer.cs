namespace FormPrincipal
{
    partial class FormAlta
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
            btn_cancelar = new Button();
            btn_agregar = new Button();
            numeric_memoria_ram = new NumericUpDown();
            numeric_disco = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            cmb_procesador = new ComboBox();
            gb_sistemas = new GroupBox();
            rb_mac = new RadioButton();
            rb_linux = new RadioButton();
            rb_windows = new RadioButton();
            gb_programas = new GroupBox();
            cb_avast = new CheckBox();
            cb_dropbox = new CheckBox();
            cb_winrar = new CheckBox();
            cb_adobe = new CheckBox();
            cb_office = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numeric_memoria_ram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_disco).BeginInit();
            groupBox1.SuspendLayout();
            gb_sistemas.SuspendLayout();
            gb_programas.SuspendLayout();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(457, 394);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 0;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(576, 394);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // numeric_memoria_ram
            // 
            numeric_memoria_ram.Location = new Point(121, 119);
            numeric_memoria_ram.Name = "numeric_memoria_ram";
            numeric_memoria_ram.Size = new Size(143, 23);
            numeric_memoria_ram.TabIndex = 2;
            // 
            // numeric_disco
            // 
            numeric_disco.Location = new Point(121, 181);
            numeric_disco.Name = "numeric_disco";
            numeric_disco.Size = new Size(143, 23);
            numeric_disco.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 121);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 4;
            label1.Text = "Memoria Ram";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 183);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "Disco";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 74);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 6;
            label3.Text = "Procesador";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmb_procesador);
            groupBox1.Controls.Add(numeric_memoria_ram);
            groupBox1.Controls.Add(numeric_disco);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(35, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 330);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hardware";
            // 
            // cmb_procesador
            // 
            cmb_procesador.FormattingEnabled = true;
            cmb_procesador.Location = new Point(121, 71);
            cmb_procesador.Name = "cmb_procesador";
            cmb_procesador.Size = new Size(143, 23);
            cmb_procesador.TabIndex = 7;
            // 
            // gb_sistemas
            // 
            gb_sistemas.Controls.Add(rb_mac);
            gb_sistemas.Controls.Add(rb_linux);
            gb_sistemas.Controls.Add(rb_windows);
            gb_sistemas.Location = new Point(483, 33);
            gb_sistemas.Name = "gb_sistemas";
            gb_sistemas.Size = new Size(168, 114);
            gb_sistemas.TabIndex = 7;
            gb_sistemas.TabStop = false;
            gb_sistemas.Text = "Sistema Operativo";
            // 
            // rb_mac
            // 
            rb_mac.AutoSize = true;
            rb_mac.Location = new Point(6, 81);
            rb_mac.Name = "rb_mac";
            rb_mac.Size = new Size(63, 19);
            rb_mac.TabIndex = 2;
            rb_mac.TabStop = true;
            rb_mac.Text = "MacOS";
            rb_mac.UseVisualStyleBackColor = true;
            // 
            // rb_linux
            // 
            rb_linux.AutoSize = true;
            rb_linux.Location = new Point(6, 56);
            rb_linux.Name = "rb_linux";
            rb_linux.Size = new Size(54, 19);
            rb_linux.TabIndex = 1;
            rb_linux.TabStop = true;
            rb_linux.Text = "Linux";
            rb_linux.UseVisualStyleBackColor = true;
            // 
            // rb_windows
            // 
            rb_windows.AutoSize = true;
            rb_windows.Location = new Point(6, 31);
            rb_windows.Name = "rb_windows";
            rb_windows.Size = new Size(74, 19);
            rb_windows.TabIndex = 0;
            rb_windows.TabStop = true;
            rb_windows.Text = "Windows";
            rb_windows.UseVisualStyleBackColor = true;
            // 
            // gb_programas
            // 
            gb_programas.Controls.Add(cb_avast);
            gb_programas.Controls.Add(cb_dropbox);
            gb_programas.Controls.Add(cb_winrar);
            gb_programas.Controls.Add(cb_adobe);
            gb_programas.Controls.Add(cb_office);
            gb_programas.Location = new Point(483, 191);
            gb_programas.Name = "gb_programas";
            gb_programas.Size = new Size(168, 172);
            gb_programas.TabIndex = 16;
            gb_programas.TabStop = false;
            gb_programas.Text = "Programas";
            // 
            // cb_avast
            // 
            cb_avast.AutoSize = true;
            cb_avast.Location = new Point(22, 127);
            cb_avast.Name = "cb_avast";
            cb_avast.Size = new Size(55, 19);
            cb_avast.TabIndex = 4;
            cb_avast.Text = "Avast";
            cb_avast.UseVisualStyleBackColor = true;
            // 
            // cb_dropbox
            // 
            cb_dropbox.AutoSize = true;
            cb_dropbox.Location = new Point(22, 102);
            cb_dropbox.Name = "cb_dropbox";
            cb_dropbox.Size = new Size(72, 19);
            cb_dropbox.TabIndex = 3;
            cb_dropbox.Text = "Dropbox";
            cb_dropbox.UseVisualStyleBackColor = true;
            // 
            // cb_winrar
            // 
            cb_winrar.AutoSize = true;
            cb_winrar.Location = new Point(22, 77);
            cb_winrar.Name = "cb_winrar";
            cb_winrar.Size = new Size(61, 19);
            cb_winrar.TabIndex = 2;
            cb_winrar.Text = "Winrar";
            cb_winrar.UseVisualStyleBackColor = true;
            // 
            // cb_adobe
            // 
            cb_adobe.AutoSize = true;
            cb_adobe.Location = new Point(22, 52);
            cb_adobe.Name = "cb_adobe";
            cb_adobe.Size = new Size(100, 19);
            cb_adobe.TabIndex = 1;
            cb_adobe.Text = "Adobe Reader";
            cb_adobe.UseVisualStyleBackColor = true;
            // 
            // cb_office
            // 
            cb_office.AutoSize = true;
            cb_office.Location = new Point(22, 27);
            cb_office.Name = "cb_office";
            cb_office.Size = new Size(58, 19);
            cb_office.TabIndex = 0;
            cb_office.Text = "Office";
            cb_office.UseVisualStyleBackColor = true;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gb_programas);
            Controls.Add(gb_sistemas);
            Controls.Add(groupBox1);
            Controls.Add(btn_agregar);
            Controls.Add(btn_cancelar);
            Name = "FormAlta";
            Text = "FormAlta";
            Load += FormAlta_Load;
            ((System.ComponentModel.ISupportInitialize)numeric_memoria_ram).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_disco).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gb_sistemas.ResumeLayout(false);
            gb_sistemas.PerformLayout();
            gb_programas.ResumeLayout(false);
            gb_programas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_cancelar;
        private Button btn_agregar;
        private NumericUpDown numeric_memoria_ram;
        private NumericUpDown numeric_disco;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox gb_sistemas;
        private RadioButton rb_mac;
        private RadioButton rb_linux;
        private RadioButton rb_windows;
        private GroupBox gb_programas;
        private CheckBox cb_avast;
        private CheckBox cb_dropbox;
        private CheckBox cb_winrar;
        private CheckBox cb_adobe;
        private CheckBox cb_office;
        private ComboBox cmb_procesador;
    }
}