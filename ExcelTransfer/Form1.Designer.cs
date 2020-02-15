namespace ExcelTransfer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.fConnection = new System.Windows.Forms.CheckBox();
            this.fGetStyleSheet = new System.Windows.Forms.Button();
            this.fStyleSheetLoc = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fExcelConnector = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fSheetNames = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fConnection
            // 
            this.fConnection.AutoSize = true;
            this.fConnection.Enabled = false;
            this.fConnection.Location = new System.Drawing.Point(386, 12);
            this.fConnection.Name = "fConnection";
            this.fConnection.Size = new System.Drawing.Size(131, 21);
            this.fConnection.TabIndex = 0;
            this.fConnection.Text = "Połączenie SQL";
            this.fConnection.UseVisualStyleBackColor = true;
            this.fConnection.CheckedChanged += new System.EventHandler(this.fConnection_CheckedChanged);
            // 
            // fGetStyleSheet
            // 
            this.fGetStyleSheet.Location = new System.Drawing.Point(12, 77);
            this.fGetStyleSheet.Name = "fGetStyleSheet";
            this.fGetStyleSheet.Size = new System.Drawing.Size(127, 23);
            this.fGetStyleSheet.TabIndex = 1;
            this.fGetStyleSheet.Text = "Wybierz arkusz";
            this.fGetStyleSheet.UseVisualStyleBackColor = true;
            this.fGetStyleSheet.Click += new System.EventHandler(this.fGetStyleSheet_Click);
            // 
            // fStyleSheetLoc
            // 
            this.fStyleSheetLoc.Location = new System.Drawing.Point(184, 78);
            this.fStyleSheetLoc.Name = "fStyleSheetLoc";
            this.fStyleSheetLoc.ReadOnly = true;
            this.fStyleSheetLoc.Size = new System.Drawing.Size(333, 22);
            this.fStyleSheetLoc.TabIndex = 2;
            this.fStyleSheetLoc.TextChanged += new System.EventHandler(this.fStyleSheetLoc_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fExcelConnector
            // 
            this.fExcelConnector.AutoSize = true;
            this.fExcelConnector.Enabled = false;
            this.fExcelConnector.Location = new System.Drawing.Point(13, 13);
            this.fExcelConnector.Name = "fExcelConnector";
            this.fExcelConnector.Size = new System.Drawing.Size(136, 21);
            this.fExcelConnector.TabIndex = 3;
            this.fExcelConnector.Text = "Połączenie Excel";
            this.fExcelConnector.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wybierz nazwę arkusza";
            // 
            // fSheetNames
            // 
            this.fSheetNames.FormattingEnabled = true;
            this.fSheetNames.Location = new System.Drawing.Point(184, 117);
            this.fSheetNames.Name = "fSheetNames";
            this.fSheetNames.Size = new System.Drawing.Size(333, 24);
            this.fSheetNames.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sprawdz czy tabela istnieje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fSheetNames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fExcelConnector);
            this.Controls.Add(this.fStyleSheetLoc);
            this.Controls.Add(this.fGetStyleSheet);
            this.Controls.Add(this.fConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox fConnection;
        private System.Windows.Forms.Button fGetStyleSheet;
        private System.Windows.Forms.TextBox fStyleSheetLoc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox fExcelConnector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fSheetNames;
        private System.Windows.Forms.Button button1;
    }
}

