namespace EconomiaDomestica.Views
{
    partial class FormLoadData
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
            this.btnLoadView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadView
            // 
            this.btnLoadView.Location = new System.Drawing.Point(345, 81);
            this.btnLoadView.Name = "btnLoadView";
            this.btnLoadView.Size = new System.Drawing.Size(75, 23);
            this.btnLoadView.TabIndex = 0;
            this.btnLoadView.Text = "Cargar";
            this.btnLoadView.UseVisualStyleBackColor = true;
            this.btnLoadView.Click += new System.EventHandler(this.btnLoadView_Click);
            // 
            // FormLoadData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadView);
            this.Name = "FormLoadData";
            this.Text = "FormLoadData";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadView;
    }
}