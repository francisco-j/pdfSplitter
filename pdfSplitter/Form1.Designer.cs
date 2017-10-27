namespace pdfSplitter
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnBuscarOrigen = new System.Windows.Forms.Button();
            this.labl2 = new System.Windows.Forms.Label();
            this.btnBuscarDestino = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblNombreSalida = new System.Windows.Forms.Label();
            this.lblEjemplo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAgregarR = new System.Windows.Forms.Button();
            this.btnQuitarR = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstbxRango = new System.Windows.Forms.ListBox();
            this.upDnFinRango = new System.Windows.Forms.NumericUpDown();
            this.upDnInicioRango = new System.Windows.Forms.NumericUpDown();
            this.btnDivPorRango = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnIgnorar = new System.Windows.Forms.Button();
            this.btnQuitarI = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstbxIgnorar = new System.Windows.Forms.ListBox();
            this.upDnFinIgnorar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.upDnInicioIgnorar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDivPorGrupo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDnFinRango)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDnInicioRango)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDnFinIgnorar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDnInicioIgnorar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(85, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Origen de datos:";
            // 
            // btnBuscarOrigen
            // 
            this.btnBuscarOrigen.Location = new System.Drawing.Point(161, 36);
            this.btnBuscarOrigen.Name = "btnBuscarOrigen";
            this.btnBuscarOrigen.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarOrigen.TabIndex = 3;
            this.btnBuscarOrigen.Text = "Buscar";
            this.btnBuscarOrigen.UseVisualStyleBackColor = true;
            this.btnBuscarOrigen.Click += new System.EventHandler(this.btnBuscarOrigen_Click);
            // 
            // labl2
            // 
            this.labl2.AutoSize = true;
            this.labl2.Location = new System.Drawing.Point(248, 21);
            this.labl2.Name = "labl2";
            this.labl2.Size = new System.Drawing.Size(99, 13);
            this.labl2.TabIndex = 2;
            this.labl2.Text = "Carpeta de destino:";
            // 
            // btnBuscarDestino
            // 
            this.btnBuscarDestino.Location = new System.Drawing.Point(415, 34);
            this.btnBuscarDestino.Name = "btnBuscarDestino";
            this.btnBuscarDestino.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDestino.TabIndex = 3;
            this.btnBuscarDestino.Text = "Explorar";
            this.btnBuscarDestino.UseVisualStyleBackColor = true;
            this.btnBuscarDestino.Click += new System.EventHandler(this.btnBuscarDestino_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOrigen);
            this.groupBox2.Controls.Add(this.lbl1);
            this.groupBox2.Controls.Add(this.lblDestino);
            this.groupBox2.Controls.Add(this.labl2);
            this.groupBox2.Controls.Add(this.btnBuscarOrigen);
            this.groupBox2.Controls.Add(this.btnBuscarDestino);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 70);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(6, 41);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(10, 13);
            this.lblOrigen.TabIndex = 2;
            this.lblOrigen.Text = "-";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(248, 41);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(10, 13);
            this.lblDestino.TabIndex = 2;
            this.lblDestino.Text = "-";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "archivos PDF (.pdf)|*.pdf";
            // 
            // lblNombreSalida
            // 
            this.lblNombreSalida.AutoSize = true;
            this.lblNombreSalida.Location = new System.Drawing.Point(314, 110);
            this.lblNombreSalida.Name = "lblNombreSalida";
            this.lblNombreSalida.Size = new System.Drawing.Size(92, 13);
            this.lblNombreSalida.TabIndex = 0;
            this.lblNombreSalida.Text = "Nombre de salida:";
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.AutoSize = true;
            this.lblEjemplo.Location = new System.Drawing.Point(314, 139);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(47, 13);
            this.lblEjemplo.TabIndex = 0;
            this.lblEjemplo.Text = "Ejemplo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.btnAgregarR);
            this.tabPage2.Controls.Add(this.btnQuitarR);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lstbxRango);
            this.tabPage2.Controls.Add(this.upDnFinRango);
            this.tabPage2.Controls.Add(this.upDnInicioRango);
            this.tabPage2.Controls.Add(this.btnDivPorRango);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(277, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Por rangos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(92, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Dividir";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnAgregarR
            // 
            this.btnAgregarR.Location = new System.Drawing.Point(182, 27);
            this.btnAgregarR.Name = "btnAgregarR";
            this.btnAgregarR.Size = new System.Drawing.Size(56, 23);
            this.btnAgregarR.TabIndex = 13;
            this.btnAgregarR.Text = "Agregar";
            this.btnAgregarR.UseVisualStyleBackColor = true;
            this.btnAgregarR.Click += new System.EventHandler(this.btnAgregarR_Click);
            // 
            // btnQuitarR
            // 
            this.btnQuitarR.Location = new System.Drawing.Point(182, 56);
            this.btnQuitarR.Name = "btnQuitarR";
            this.btnQuitarR.Size = new System.Drawing.Size(56, 23);
            this.btnQuitarR.TabIndex = 13;
            this.btnQuitarR.Text = "Quitar";
            this.btnQuitarR.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "de";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Agregar";
            // 
            // lstbxRango
            // 
            this.lstbxRango.FormattingEnabled = true;
            this.lstbxRango.Location = new System.Drawing.Point(44, 56);
            this.lstbxRango.Name = "lstbxRango";
            this.lstbxRango.Size = new System.Drawing.Size(132, 134);
            this.lstbxRango.TabIndex = 9;
            // 
            // upDnFinRango
            // 
            this.upDnFinRango.Location = new System.Drawing.Point(135, 32);
            this.upDnFinRango.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.upDnFinRango.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDnFinRango.Name = "upDnFinRango";
            this.upDnFinRango.Size = new System.Drawing.Size(41, 20);
            this.upDnFinRango.TabIndex = 7;
            this.upDnFinRango.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // upDnInicioRango
            // 
            this.upDnInicioRango.Location = new System.Drawing.Point(69, 30);
            this.upDnInicioRango.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.upDnInicioRango.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDnInicioRango.Name = "upDnInicioRango";
            this.upDnInicioRango.Size = new System.Drawing.Size(41, 20);
            this.upDnInicioRango.TabIndex = 8;
            this.upDnInicioRango.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDivPorRango
            // 
            this.btnDivPorRango.Location = new System.Drawing.Point(527, 309);
            this.btnDivPorRango.Name = "btnDivPorRango";
            this.btnDivPorRango.Size = new System.Drawing.Size(75, 23);
            this.btnDivPorRango.TabIndex = 0;
            this.btnDivPorRango.Text = "Dividir";
            this.btnDivPorRango.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnIgnorar);
            this.tabPage1.Controls.Add(this.btnQuitarI);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lstbxIgnorar);
            this.tabPage1.Controls.Add(this.upDnFinIgnorar);
            this.tabPage1.Controls.Add(this.numericUpDown6);
            this.tabPage1.Controls.Add(this.upDnInicioIgnorar);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnDivPorGrupo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(277, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por grupos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(92, 210);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Dividir";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "paginas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Separar por grupos de";
            // 
            // btnIgnorar
            // 
            this.btnIgnorar.Location = new System.Drawing.Point(185, 73);
            this.btnIgnorar.Name = "btnIgnorar";
            this.btnIgnorar.Size = new System.Drawing.Size(52, 28);
            this.btnIgnorar.TabIndex = 6;
            this.btnIgnorar.Text = "Ignorar";
            this.btnIgnorar.UseVisualStyleBackColor = true;
            // 
            // btnQuitarI
            // 
            this.btnQuitarI.Location = new System.Drawing.Point(184, 103);
            this.btnQuitarI.Name = "btnQuitarI";
            this.btnQuitarI.Size = new System.Drawing.Size(53, 28);
            this.btnQuitarI.TabIndex = 6;
            this.btnQuitarI.Text = "Quitar";
            this.btnQuitarI.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "de";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ignorar";
            // 
            // lstbxIgnorar
            // 
            this.lstbxIgnorar.FormattingEnabled = true;
            this.lstbxIgnorar.Location = new System.Drawing.Point(47, 103);
            this.lstbxIgnorar.Name = "lstbxIgnorar";
            this.lstbxIgnorar.Size = new System.Drawing.Size(132, 30);
            this.lstbxIgnorar.TabIndex = 4;
            // 
            // upDnFinIgnorar
            // 
            this.upDnFinIgnorar.Location = new System.Drawing.Point(138, 79);
            this.upDnFinIgnorar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.upDnFinIgnorar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDnFinIgnorar.Name = "upDnFinIgnorar";
            this.upDnFinIgnorar.Size = new System.Drawing.Size(41, 20);
            this.upDnFinIgnorar.TabIndex = 3;
            this.upDnFinIgnorar.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(157, 20);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown6.TabIndex = 3;
            this.numericUpDown6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // upDnInicioIgnorar
            // 
            this.upDnInicioIgnorar.Location = new System.Drawing.Point(72, 77);
            this.upDnInicioIgnorar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.upDnInicioIgnorar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDnInicioIgnorar.Name = "upDnInicioIgnorar";
            this.upDnInicioIgnorar.Size = new System.Drawing.Size(41, 20);
            this.upDnInicioIgnorar.TabIndex = 3;
            this.upDnInicioIgnorar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(317, 54);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "grupos de";
            // 
            // btnDivPorGrupo
            // 
            this.btnDivPorGrupo.Location = new System.Drawing.Point(527, 309);
            this.btnDivPorGrupo.Name = "btnDivPorGrupo";
            this.btnDivPorGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnDivPorGrupo.TabIndex = 1;
            this.btnDivPorGrupo.Text = "Dividir";
            this.btnDivPorGrupo.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(285, 265);
            this.tabControl1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ejemplo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 359);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEjemplo);
            this.Controls.Add(this.lblNombreSalida);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "pdfSplitter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDnFinRango)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDnInicioRango)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDnFinIgnorar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDnInicioIgnorar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnBuscarOrigen;
        private System.Windows.Forms.Label labl2;
        private System.Windows.Forms.Button btnBuscarDestino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblNombreSalida;
        private System.Windows.Forms.Label lblEjemplo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnQuitarR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstbxRango;
        private System.Windows.Forms.NumericUpDown upDnFinRango;
        private System.Windows.Forms.NumericUpDown upDnInicioRango;
        private System.Windows.Forms.Button btnDivPorRango;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnIgnorar;
        private System.Windows.Forms.Button btnQuitarI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbxIgnorar;
        private System.Windows.Forms.NumericUpDown upDnFinIgnorar;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown upDnInicioIgnorar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDivPorGrupo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAgregarR;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
    }
}

