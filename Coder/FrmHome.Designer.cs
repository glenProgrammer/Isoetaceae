namespace Coder
{
    partial class FrmHome
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
            this.components = new System.ComponentModel.Container();
            this.LblInputType = new System.Windows.Forms.Label();
            this.LblOutputType = new System.Windows.Forms.Label();
            this.BtnEncode = new System.Windows.Forms.Button();
            this.BtnDecode = new System.Windows.Forms.Button();
            this.CBoxInput = new System.Windows.Forms.ComboBox();
            this.CBoxOutput = new System.Windows.Forms.ComboBox();
            this.TxtInputArea = new System.Windows.Forms.RichTextBox();
            this.TxtOutputArea = new System.Windows.Forms.RichTextBox();
            this.LblKey = new System.Windows.Forms.Label();
            this.LblInput = new System.Windows.Forms.Label();
            this.LblOutput = new System.Windows.Forms.Label();
            this.LblMethod = new System.Windows.Forms.Label();
            this.CBoxMethod = new System.Windows.Forms.ComboBox();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.BtnSaveFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TxtKey = new System.Windows.Forms.TextBox();
            this.LblSelectedInputFile = new System.Windows.Forms.Label();
            this.LblSelectedOutputFile = new System.Windows.Forms.Label();
            this.epInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblDone = new System.Windows.Forms.Label();
            this.epOutput = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.LblKeyHelp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // LblInputType
            // 
            this.LblInputType.AutoSize = true;
            this.LblInputType.Location = new System.Drawing.Point(52, 107);
            this.LblInputType.Name = "LblInputType";
            this.LblInputType.Size = new System.Drawing.Size(34, 13);
            this.LblInputType.TabIndex = 0;
            this.LblInputType.Text = "Input:";
            // 
            // LblOutputType
            // 
            this.LblOutputType.AutoSize = true;
            this.LblOutputType.Location = new System.Drawing.Point(45, 144);
            this.LblOutputType.Name = "LblOutputType";
            this.LblOutputType.Size = new System.Drawing.Size(42, 13);
            this.LblOutputType.TabIndex = 0;
            this.LblOutputType.Text = "Output:";
            // 
            // BtnEncode
            // 
            this.BtnEncode.Location = new System.Drawing.Point(86, 483);
            this.BtnEncode.Name = "BtnEncode";
            this.BtnEncode.Size = new System.Drawing.Size(75, 23);
            this.BtnEncode.TabIndex = 1;
            this.BtnEncode.Text = "Encode";
            this.BtnEncode.UseVisualStyleBackColor = true;
            this.BtnEncode.Click += new System.EventHandler(this.BtnEncode_Click);
            // 
            // BtnDecode
            // 
            this.BtnDecode.Location = new System.Drawing.Point(207, 483);
            this.BtnDecode.Name = "BtnDecode";
            this.BtnDecode.Size = new System.Drawing.Size(75, 23);
            this.BtnDecode.TabIndex = 1;
            this.BtnDecode.Text = "Decode";
            this.BtnDecode.UseVisualStyleBackColor = true;
            this.BtnDecode.Click += new System.EventHandler(this.BtnDecode_Click);
            // 
            // CBoxInput
            // 
            this.CBoxInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxInput.FormattingEnabled = true;
            this.CBoxInput.Location = new System.Drawing.Point(88, 104);
            this.CBoxInput.Name = "CBoxInput";
            this.CBoxInput.Size = new System.Drawing.Size(194, 21);
            this.CBoxInput.TabIndex = 2;
            this.CBoxInput.SelectedIndexChanged += new System.EventHandler(this.CBoxInput_SelectedIndexChanged);
            // 
            // CBoxOutput
            // 
            this.CBoxOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxOutput.FormattingEnabled = true;
            this.CBoxOutput.Location = new System.Drawing.Point(88, 141);
            this.CBoxOutput.Name = "CBoxOutput";
            this.CBoxOutput.Size = new System.Drawing.Size(194, 21);
            this.CBoxOutput.TabIndex = 3;
            this.CBoxOutput.SelectedIndexChanged += new System.EventHandler(this.CBoxOutput_SelectedIndexChanged);
            // 
            // TxtInputArea
            // 
            this.TxtInputArea.Location = new System.Drawing.Point(388, 23);
            this.TxtInputArea.Name = "TxtInputArea";
            this.TxtInputArea.Size = new System.Drawing.Size(474, 311);
            this.TxtInputArea.TabIndex = 4;
            this.TxtInputArea.Text = "";
            this.TxtInputArea.Visible = false;
            // 
            // TxtOutputArea
            // 
            this.TxtOutputArea.Location = new System.Drawing.Point(388, 340);
            this.TxtOutputArea.Name = "TxtOutputArea";
            this.TxtOutputArea.ReadOnly = true;
            this.TxtOutputArea.Size = new System.Drawing.Size(474, 311);
            this.TxtOutputArea.TabIndex = 4;
            this.TxtOutputArea.Text = "";
            this.TxtOutputArea.Visible = false;
            // 
            // LblKey
            // 
            this.LblKey.AutoSize = true;
            this.LblKey.Location = new System.Drawing.Point(52, 196);
            this.LblKey.Name = "LblKey";
            this.LblKey.Size = new System.Drawing.Size(28, 13);
            this.LblKey.TabIndex = 5;
            this.LblKey.Text = "Key:";
            this.LblKey.MouseLeave += new System.EventHandler(this.LblKey_MouseLeave);
            this.LblKey.MouseHover += new System.EventHandler(this.LblKey_MouseHover);
            // 
            // LblInput
            // 
            this.LblInput.AutoSize = true;
            this.LblInput.Location = new System.Drawing.Point(337, 158);
            this.LblInput.Name = "LblInput";
            this.LblInput.Size = new System.Drawing.Size(31, 13);
            this.LblInput.TabIndex = 7;
            this.LblInput.Text = "Input";
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(337, 488);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(39, 13);
            this.LblOutput.TabIndex = 7;
            this.LblOutput.Text = "Output";
            // 
            // LblMethod
            // 
            this.LblMethod.AutoSize = true;
            this.LblMethod.Location = new System.Drawing.Point(41, 72);
            this.LblMethod.Name = "LblMethod";
            this.LblMethod.Size = new System.Drawing.Size(46, 13);
            this.LblMethod.TabIndex = 0;
            this.LblMethod.Text = "Method:";
            // 
            // CBoxMethod
            // 
            this.CBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxMethod.FormattingEnabled = true;
            this.CBoxMethod.Location = new System.Drawing.Point(87, 69);
            this.CBoxMethod.Name = "CBoxMethod";
            this.CBoxMethod.Size = new System.Drawing.Size(194, 21);
            this.CBoxMethod.TabIndex = 2;
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Location = new System.Drawing.Point(388, 153);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(108, 23);
            this.BtnOpenFile.TabIndex = 10;
            this.BtnOpenFile.Text = "Select File";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Visible = false;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // BtnSaveFile
            // 
            this.BtnSaveFile.Location = new System.Drawing.Point(388, 483);
            this.BtnSaveFile.Name = "BtnSaveFile";
            this.BtnSaveFile.Size = new System.Drawing.Size(108, 23);
            this.BtnSaveFile.TabIndex = 10;
            this.BtnSaveFile.Text = "Select Destination";
            this.BtnSaveFile.UseVisualStyleBackColor = true;
            this.BtnSaveFile.Visible = false;
            this.BtnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt files (*.txt)|*.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "\"Text File (*.txt)|*.txt";
            // 
            // TxtKey
            // 
            this.TxtKey.Location = new System.Drawing.Point(86, 193);
            this.TxtKey.Name = "TxtKey";
            this.TxtKey.Size = new System.Drawing.Size(193, 20);
            this.TxtKey.TabIndex = 9;
            // 
            // LblSelectedInputFile
            // 
            this.LblSelectedInputFile.AutoSize = true;
            this.LblSelectedInputFile.Location = new System.Drawing.Point(503, 158);
            this.LblSelectedInputFile.Name = "LblSelectedInputFile";
            this.LblSelectedInputFile.Size = new System.Drawing.Size(76, 13);
            this.LblSelectedInputFile.TabIndex = 11;
            this.LblSelectedInputFile.Text = "Selected Input";
            this.LblSelectedInputFile.Visible = false;
            // 
            // LblSelectedOutputFile
            // 
            this.LblSelectedOutputFile.AutoSize = true;
            this.LblSelectedOutputFile.Location = new System.Drawing.Point(503, 488);
            this.LblSelectedOutputFile.Name = "LblSelectedOutputFile";
            this.LblSelectedOutputFile.Size = new System.Drawing.Size(84, 13);
            this.LblSelectedOutputFile.TabIndex = 12;
            this.LblSelectedOutputFile.Text = "Selected Output";
            this.LblSelectedOutputFile.Visible = false;
            // 
            // epInput
            // 
            this.epInput.ContainerControl = this;
            // 
            // LblDone
            // 
            this.LblDone.AutoSize = true;
            this.LblDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblDone.Location = new System.Drawing.Point(156, 533);
            this.LblDone.Name = "LblDone";
            this.LblDone.Size = new System.Drawing.Size(52, 20);
            this.LblDone.TabIndex = 13;
            this.LblDone.Text = "Done!";
            this.LblDone.Visible = false;
            // 
            // epOutput
            // 
            this.epOutput.ContainerControl = this;
            // 
            // LblKeyHelp
            // 
            this.LblKeyHelp.AutoSize = true;
            this.LblKeyHelp.Location = new System.Drawing.Point(5, 229);
            this.LblKeyHelp.Name = "LblKeyHelp";
            this.LblKeyHelp.Size = new System.Drawing.Size(377, 13);
            this.LblKeyHelp.TabIndex = 14;
            this.LblKeyHelp.Text = "The key can be any combination of numbers, letters, spaces, and punctuation.";
            this.LblKeyHelp.Visible = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 663);
            this.Controls.Add(this.LblKeyHelp);
            this.Controls.Add(this.LblDone);
            this.Controls.Add(this.LblSelectedOutputFile);
            this.Controls.Add(this.LblSelectedInputFile);
            this.Controls.Add(this.BtnSaveFile);
            this.Controls.Add(this.BtnOpenFile);
            this.Controls.Add(this.TxtKey);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.LblInput);
            this.Controls.Add(this.LblKey);
            this.Controls.Add(this.TxtOutputArea);
            this.Controls.Add(this.TxtInputArea);
            this.Controls.Add(this.CBoxOutput);
            this.Controls.Add(this.CBoxMethod);
            this.Controls.Add(this.CBoxInput);
            this.Controls.Add(this.BtnDecode);
            this.Controls.Add(this.BtnEncode);
            this.Controls.Add(this.LblOutputType);
            this.Controls.Add(this.LblMethod);
            this.Controls.Add(this.LblInputType);
            this.Name = "FrmHome";
            this.Text = "Isoetaceae - Cipher Encoding and Decoding";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInputType;
        private System.Windows.Forms.Label LblOutputType;
        private System.Windows.Forms.Button BtnEncode;
        private System.Windows.Forms.Button BtnDecode;
        private System.Windows.Forms.ComboBox CBoxInput;
        private System.Windows.Forms.ComboBox CBoxOutput;
        private System.Windows.Forms.RichTextBox TxtInputArea;
        private System.Windows.Forms.RichTextBox TxtOutputArea;
        private System.Windows.Forms.Label LblKey;
        private System.Windows.Forms.Label LblInput;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.Label LblMethod;
        private System.Windows.Forms.ComboBox CBoxMethod;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.Button BtnSaveFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox TxtKey;
        private System.Windows.Forms.Label LblSelectedInputFile;
        private System.Windows.Forms.Label LblSelectedOutputFile;
        private System.Windows.Forms.ErrorProvider epInput;
        private System.Windows.Forms.Label LblDone;
        private System.Windows.Forms.ErrorProvider epOutput;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.Label LblKeyHelp;
    }
}

