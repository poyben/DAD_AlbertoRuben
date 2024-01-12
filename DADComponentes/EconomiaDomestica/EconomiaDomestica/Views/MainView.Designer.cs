namespace EconomiaDomestica.Views
{
    partial class MainView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.mnStripMainView = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.análisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDomesticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPrevisionMainView = new System.Windows.Forms.Label();
            this.rBtnMainViewVista = new System.Windows.Forms.RadioButton();
            this.rBtnMainViewPeriodo = new System.Windows.Forms.RadioButton();
            this.gBoxMainViewVista = new System.Windows.Forms.GroupBox();
            this.gBoxMainViewPeriodos = new System.Windows.Forms.GroupBox();
            this.btnMainViewVisualizar = new System.Windows.Forms.Button();
            this.rBtnMainViewSemana = new System.Windows.Forms.RadioButton();
            this.rBtnMainViewMes = new System.Windows.Forms.RadioButton();
            this.rBtnMainViewYear = new System.Windows.Forms.RadioButton();
            this.cBoxMainView = new System.Windows.Forms.ComboBox();
            this.dtPickerMainViewDe = new System.Windows.Forms.DateTimePicker();
            this.lblMainViewHasta = new System.Windows.Forms.Label();
            this.lblMainViewDe = new System.Windows.Forms.Label();
            this.dtPickerMainViewHasta = new System.Windows.Forms.DateTimePicker();
            this.chartMainView1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMainViewGastos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnMainViewCargaDatos = new System.Windows.Forms.Button();
            this.btnMainViewEditarDatos = new System.Windows.Forms.Button();
            this.btnMainViewRegistrarTicket = new System.Windows.Forms.Button();
            this.btnMainViewAnalisis = new System.Windows.Forms.Button();
            this.mnStripMainView.SuspendLayout();
            this.gBoxMainViewVista.SuspendLayout();
            this.gBoxMainViewPeriodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMainView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMainViewGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // mnStripMainView
            // 
            this.mnStripMainView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.datosToolStripMenuItem,
            this.análisisToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.mnStripMainView.Location = new System.Drawing.Point(0, 0);
            this.mnStripMainView.Name = "mnStripMainView";
            this.mnStripMainView.Size = new System.Drawing.Size(1141, 24);
            this.mnStripMainView.TabIndex = 0;
            this.mnStripMainView.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.registrarTicketsToolStripMenuItem});
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.datosToolStripMenuItem.Text = "Datos";
            // 
            // análisisToolStripMenuItem
            // 
            this.análisisToolStripMenuItem.Name = "análisisToolStripMenuItem";
            this.análisisToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.análisisToolStripMenuItem.Text = "Análisis";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDomesticosToolStripMenuItem,
            this.idiomaToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // registrarTicketsToolStripMenuItem
            // 
            this.registrarTicketsToolStripMenuItem.Name = "registrarTicketsToolStripMenuItem";
            this.registrarTicketsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarTicketsToolStripMenuItem.Text = "Registrar tickets";
            this.registrarTicketsToolStripMenuItem.Click += new System.EventHandler(this.registrarTicketsToolStripMenuItem_Click);
            // 
            // datosDomesticosToolStripMenuItem
            // 
            this.datosDomesticosToolStripMenuItem.Name = "datosDomesticosToolStripMenuItem";
            this.datosDomesticosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datosDomesticosToolStripMenuItem.Text = "Datos domesticos";
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // lblPrevisionMainView
            // 
            this.lblPrevisionMainView.AutoSize = true;
            this.lblPrevisionMainView.Location = new System.Drawing.Point(24, 43);
            this.lblPrevisionMainView.Name = "lblPrevisionMainView";
            this.lblPrevisionMainView.Size = new System.Drawing.Size(50, 13);
            this.lblPrevisionMainView.TabIndex = 1;
            this.lblPrevisionMainView.Text = "Previsión";
            // 
            // rBtnMainViewVista
            // 
            this.rBtnMainViewVista.AutoSize = true;
            this.rBtnMainViewVista.Checked = true;
            this.rBtnMainViewVista.Cursor = System.Windows.Forms.Cursors.Default;
            this.rBtnMainViewVista.Location = new System.Drawing.Point(12, 85);
            this.rBtnMainViewVista.Name = "rBtnMainViewVista";
            this.rBtnMainViewVista.Size = new System.Drawing.Size(48, 17);
            this.rBtnMainViewVista.TabIndex = 2;
            this.rBtnMainViewVista.TabStop = true;
            this.rBtnMainViewVista.Text = "Vista";
            this.rBtnMainViewVista.UseVisualStyleBackColor = true;
            // 
            // rBtnMainViewPeriodo
            // 
            this.rBtnMainViewPeriodo.AutoSize = true;
            this.rBtnMainViewPeriodo.Location = new System.Drawing.Point(363, 82);
            this.rBtnMainViewPeriodo.Name = "rBtnMainViewPeriodo";
            this.rBtnMainViewPeriodo.Size = new System.Drawing.Size(61, 17);
            this.rBtnMainViewPeriodo.TabIndex = 3;
            this.rBtnMainViewPeriodo.Text = "Periodo";
            this.rBtnMainViewPeriodo.UseVisualStyleBackColor = true;
            // 
            // gBoxMainViewVista
            // 
            this.gBoxMainViewVista.Controls.Add(this.cBoxMainView);
            this.gBoxMainViewVista.Controls.Add(this.rBtnMainViewYear);
            this.gBoxMainViewVista.Controls.Add(this.rBtnMainViewMes);
            this.gBoxMainViewVista.Controls.Add(this.rBtnMainViewSemana);
            this.gBoxMainViewVista.Location = new System.Drawing.Point(56, 73);
            this.gBoxMainViewVista.Name = "gBoxMainViewVista";
            this.gBoxMainViewVista.Size = new System.Drawing.Size(301, 57);
            this.gBoxMainViewVista.TabIndex = 4;
            this.gBoxMainViewVista.TabStop = false;
            this.gBoxMainViewVista.Text = "Periodos";
            this.gBoxMainViewVista.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gBoxMainViewPeriodos
            // 
            this.gBoxMainViewPeriodos.Controls.Add(this.dtPickerMainViewHasta);
            this.gBoxMainViewPeriodos.Controls.Add(this.lblMainViewDe);
            this.gBoxMainViewPeriodos.Controls.Add(this.lblMainViewHasta);
            this.gBoxMainViewPeriodos.Controls.Add(this.dtPickerMainViewDe);
            this.gBoxMainViewPeriodos.Location = new System.Drawing.Point(430, 73);
            this.gBoxMainViewPeriodos.Name = "gBoxMainViewPeriodos";
            this.gBoxMainViewPeriodos.Size = new System.Drawing.Size(291, 57);
            this.gBoxMainViewPeriodos.TabIndex = 5;
            this.gBoxMainViewPeriodos.TabStop = false;
            this.gBoxMainViewPeriodos.Text = "Rango";
            // 
            // btnMainViewVisualizar
            // 
            this.btnMainViewVisualizar.Location = new System.Drawing.Point(727, 87);
            this.btnMainViewVisualizar.Name = "btnMainViewVisualizar";
            this.btnMainViewVisualizar.Size = new System.Drawing.Size(61, 23);
            this.btnMainViewVisualizar.TabIndex = 6;
            this.btnMainViewVisualizar.Text = "Visualizar";
            this.btnMainViewVisualizar.UseVisualStyleBackColor = true;
            // 
            // rBtnMainViewSemana
            // 
            this.rBtnMainViewSemana.AutoSize = true;
            this.rBtnMainViewSemana.Checked = true;
            this.rBtnMainViewSemana.Location = new System.Drawing.Point(7, 12);
            this.rBtnMainViewSemana.Name = "rBtnMainViewSemana";
            this.rBtnMainViewSemana.Size = new System.Drawing.Size(64, 17);
            this.rBtnMainViewSemana.TabIndex = 0;
            this.rBtnMainViewSemana.TabStop = true;
            this.rBtnMainViewSemana.Text = "Semana";
            this.rBtnMainViewSemana.UseVisualStyleBackColor = true;
            this.rBtnMainViewSemana.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rBtnMainViewMes
            // 
            this.rBtnMainViewMes.AutoSize = true;
            this.rBtnMainViewMes.Location = new System.Drawing.Point(77, 12);
            this.rBtnMainViewMes.Name = "rBtnMainViewMes";
            this.rBtnMainViewMes.Size = new System.Drawing.Size(45, 17);
            this.rBtnMainViewMes.TabIndex = 1;
            this.rBtnMainViewMes.Text = "Mes";
            this.rBtnMainViewMes.UseVisualStyleBackColor = true;
            this.rBtnMainViewMes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // rBtnMainViewYear
            // 
            this.rBtnMainViewYear.AutoSize = true;
            this.rBtnMainViewYear.Location = new System.Drawing.Point(128, 12);
            this.rBtnMainViewYear.Name = "rBtnMainViewYear";
            this.rBtnMainViewYear.Size = new System.Drawing.Size(47, 17);
            this.rBtnMainViewYear.TabIndex = 2;
            this.rBtnMainViewYear.Text = "Year";
            this.rBtnMainViewYear.UseVisualStyleBackColor = true;
            this.rBtnMainViewYear.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_2);
            // 
            // cBoxMainView
            // 
            this.cBoxMainView.FormattingEnabled = true;
            this.cBoxMainView.Location = new System.Drawing.Point(181, 10);
            this.cBoxMainView.Name = "cBoxMainView";
            this.cBoxMainView.Size = new System.Drawing.Size(102, 21);
            this.cBoxMainView.TabIndex = 3;
            // 
            // dtPickerMainViewDe
            // 
            this.dtPickerMainViewDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerMainViewDe.Location = new System.Drawing.Point(36, 19);
            this.dtPickerMainViewDe.Name = "dtPickerMainViewDe";
            this.dtPickerMainViewDe.Size = new System.Drawing.Size(98, 20);
            this.dtPickerMainViewDe.TabIndex = 7;
            // 
            // lblMainViewHasta
            // 
            this.lblMainViewHasta.AutoSize = true;
            this.lblMainViewHasta.Location = new System.Drawing.Point(140, 24);
            this.lblMainViewHasta.Name = "lblMainViewHasta";
            this.lblMainViewHasta.Size = new System.Drawing.Size(38, 13);
            this.lblMainViewHasta.TabIndex = 7;
            this.lblMainViewHasta.Text = "Hasta:";
            // 
            // lblMainViewDe
            // 
            this.lblMainViewDe.AutoSize = true;
            this.lblMainViewDe.Location = new System.Drawing.Point(6, 24);
            this.lblMainViewDe.Name = "lblMainViewDe";
            this.lblMainViewDe.Size = new System.Drawing.Size(24, 13);
            this.lblMainViewDe.TabIndex = 8;
            this.lblMainViewDe.Text = "De:";
            // 
            // dtPickerMainViewHasta
            // 
            this.dtPickerMainViewHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerMainViewHasta.Location = new System.Drawing.Point(179, 19);
            this.dtPickerMainViewHasta.Name = "dtPickerMainViewHasta";
            this.dtPickerMainViewHasta.Size = new System.Drawing.Size(98, 20);
            this.dtPickerMainViewHasta.TabIndex = 9;
            // 
            // chartMainView1
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMainView1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMainView1.Legends.Add(legend1);
            this.chartMainView1.Location = new System.Drawing.Point(57, 163);
            this.chartMainView1.Name = "chartMainView1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMainView1.Series.Add(series1);
            this.chartMainView1.Size = new System.Drawing.Size(538, 141);
            this.chartMainView1.TabIndex = 7;
            this.chartMainView1.Text = "chart1";
            // 
            // chartMainViewGastos
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMainViewGastos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMainViewGastos.Legends.Add(legend2);
            this.chartMainViewGastos.Location = new System.Drawing.Point(784, 381);
            this.chartMainViewGastos.Name = "chartMainViewGastos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMainViewGastos.Series.Add(series2);
            this.chartMainViewGastos.Size = new System.Drawing.Size(215, 134);
            this.chartMainViewGastos.TabIndex = 11;
            this.chartMainViewGastos.Text = "chart4";
            // 
            // btnMainViewCargaDatos
            // 
            this.btnMainViewCargaDatos.Location = new System.Drawing.Point(1014, 394);
            this.btnMainViewCargaDatos.Name = "btnMainViewCargaDatos";
            this.btnMainViewCargaDatos.Size = new System.Drawing.Size(108, 23);
            this.btnMainViewCargaDatos.TabIndex = 12;
            this.btnMainViewCargaDatos.Text = "Cargar Datos";
            this.btnMainViewCargaDatos.UseVisualStyleBackColor = true;
            this.btnMainViewCargaDatos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMainViewEditarDatos
            // 
            this.btnMainViewEditarDatos.Location = new System.Drawing.Point(1014, 423);
            this.btnMainViewEditarDatos.Name = "btnMainViewEditarDatos";
            this.btnMainViewEditarDatos.Size = new System.Drawing.Size(108, 23);
            this.btnMainViewEditarDatos.TabIndex = 13;
            this.btnMainViewEditarDatos.Text = "Editar Datos";
            this.btnMainViewEditarDatos.UseVisualStyleBackColor = true;
            // 
            // btnMainViewRegistrarTicket
            // 
            this.btnMainViewRegistrarTicket.Location = new System.Drawing.Point(1014, 452);
            this.btnMainViewRegistrarTicket.Name = "btnMainViewRegistrarTicket";
            this.btnMainViewRegistrarTicket.Size = new System.Drawing.Size(108, 23);
            this.btnMainViewRegistrarTicket.TabIndex = 14;
            this.btnMainViewRegistrarTicket.Text = "Registrar Ticket";
            this.btnMainViewRegistrarTicket.UseVisualStyleBackColor = true;
            // 
            // btnMainViewAnalisis
            // 
            this.btnMainViewAnalisis.Location = new System.Drawing.Point(1014, 481);
            this.btnMainViewAnalisis.Name = "btnMainViewAnalisis";
            this.btnMainViewAnalisis.Size = new System.Drawing.Size(108, 23);
            this.btnMainViewAnalisis.TabIndex = 15;
            this.btnMainViewAnalisis.Text = "Análisis";
            this.btnMainViewAnalisis.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 599);
            this.Controls.Add(this.btnMainViewAnalisis);
            this.Controls.Add(this.btnMainViewRegistrarTicket);
            this.Controls.Add(this.btnMainViewEditarDatos);
            this.Controls.Add(this.btnMainViewCargaDatos);
            this.Controls.Add(this.chartMainViewGastos);
            this.Controls.Add(this.chartMainView1);
            this.Controls.Add(this.btnMainViewVisualizar);
            this.Controls.Add(this.gBoxMainViewPeriodos);
            this.Controls.Add(this.gBoxMainViewVista);
            this.Controls.Add(this.rBtnMainViewPeriodo);
            this.Controls.Add(this.rBtnMainViewVista);
            this.Controls.Add(this.lblPrevisionMainView);
            this.Controls.Add(this.mnStripMainView);
            this.MainMenuStrip = this.mnStripMainView;
            this.Name = "MainView";
            this.Text = "Form1";
            this.mnStripMainView.ResumeLayout(false);
            this.mnStripMainView.PerformLayout();
            this.gBoxMainViewVista.ResumeLayout(false);
            this.gBoxMainViewVista.PerformLayout();
            this.gBoxMainViewPeriodos.ResumeLayout(false);
            this.gBoxMainViewPeriodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMainView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMainViewGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.MenuStrip mnStripMainView;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem análisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDomesticosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.Label lblPrevisionMainView;
        private System.Windows.Forms.RadioButton rBtnMainViewVista;
        private System.Windows.Forms.RadioButton rBtnMainViewPeriodo;
        private System.Windows.Forms.GroupBox gBoxMainViewVista;
        private System.Windows.Forms.GroupBox gBoxMainViewPeriodos;
        private System.Windows.Forms.Button btnMainViewVisualizar;
        private System.Windows.Forms.RadioButton rBtnMainViewSemana;
        private System.Windows.Forms.RadioButton rBtnMainViewMes;
        private System.Windows.Forms.RadioButton rBtnMainViewYear;
        private System.Windows.Forms.ComboBox cBoxMainView;
        private System.Windows.Forms.Label lblMainViewHasta;
        private System.Windows.Forms.DateTimePicker dtPickerMainViewDe;
        private System.Windows.Forms.DateTimePicker dtPickerMainViewHasta;
        private System.Windows.Forms.Label lblMainViewDe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMainView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMainViewGastos;
        private System.Windows.Forms.Button btnMainViewCargaDatos;
        private System.Windows.Forms.Button btnMainViewEditarDatos;
        private System.Windows.Forms.Button btnMainViewRegistrarTicket;
        private System.Windows.Forms.Button btnMainViewAnalisis;
    }
}