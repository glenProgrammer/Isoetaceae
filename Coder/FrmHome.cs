using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coder
{
    public partial class FrmHome : Form
    {
        private const string TXT_FIELD = "Text Field";
        private const string TXT_FILE = "Text File";

        private const string METHOD_SUBSTITUTION = "Substition Cypher";

        private bool inputFileSelected = false;
        private bool outputFileSelected = false;

        private List<ICodeMethod> methods = new List<ICodeMethod>();
        private ResettableSet<char> alphabet;

        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            CBoxInput.Items.Add(TXT_FIELD);
            CBoxInput.Items.Add(TXT_FILE);
            CBoxInput.Text = TXT_FIELD;

            CBoxOutput.Items.Add(TXT_FIELD);
            CBoxOutput.Items.Add(TXT_FILE);
            CBoxOutput.Text = TXT_FIELD;

            CBoxMethod.Items.Add(METHOD_SUBSTITUTION);
            CBoxMethod.Text = METHOD_SUBSTITUTION;

            alphabet = new ResettableSet<char>();
            const int ASCII_MIN_NON_FORMAT_CHAR = 32;
            const int ASCII_MAX = 126;
            for (int i = ASCII_MIN_NON_FORMAT_CHAR; i <= ASCII_MAX; ++i)
                alphabet.Add((char)i);
        }

        private void HideDoneLabel()
        {
            LblDone.Visible = false;
        }

        private void CBoxInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(CBoxInput.Text)
            {
                case TXT_FIELD:
                    TxtInputArea.Visible = true;
                    BtnOpenFile.Visible = false;
                    LblSelectedInputFile.Visible = false;
                    break;
                case TXT_FILE:
                    TxtInputArea.Visible = false;
                    BtnOpenFile.Visible = true;
                    if (inputFileSelected)
                        LblSelectedInputFile.Visible = true;
                    break;
            }
        }
        
        private void CBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBoxOutput.Text)
            {
                case TXT_FIELD:
                    TxtOutputArea.Visible = true;
                    BtnSaveFile.Visible = false;
                    LblSelectedOutputFile.Visible = false;
                    break;
                case TXT_FILE:
                    TxtOutputArea.Visible = false;
                    BtnSaveFile.Visible = true;
                    if (outputFileSelected)
                        LblSelectedOutputFile.Visible = true;
                    break;
            }
        }

        private void EncodeOrDecode(bool encode)
        {
            bool existsError = false;
            if( CBoxInput.Text == TXT_FILE && !inputFileSelected )
            {
                epInput.SetError(BtnOpenFile, "No input file is selected.");
                existsError = true;
            }
            if( CBoxOutput.Text == TXT_FILE && !outputFileSelected )
            {
                epOutput.SetError(BtnSaveFile, "No output file is selected.");
                existsError = true;
            }

            if (existsError)
                return;

            ICodeMethod method;
            string input;

            switch (CBoxInput.Text)
            {
                case TXT_FIELD:
                    input = TxtInputArea.Text;
                    break;
                case TXT_FILE:
                    System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog.FileName);
                    input = file.ReadToEnd();
                    file.Close();
                    break;
                default:
                    throw new Exception("Invalid selection for input.");
            }
            switch (CBoxMethod.Text)
            {
                case METHOD_SUBSTITUTION:
                    method = new SubstitutionCypher(input, alphabet);
                    break;
                default:
                    throw new NotImplementedException();
            }

            string output;
            if (encode)
                output = method.Encode(TxtKey.Text);
            else
                output = method.Decode(TxtKey.Text);

            switch (CBoxOutput.Text)
            {
                case TXT_FIELD:
                    TxtOutputArea.Text = output;
                    break;
                case TXT_FILE:
                    System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog.FileName);
                    file.Write(output);
                    file.Close();
                    break;
            }

            LblDone.Visible = true;

            //Stop showing "done" after a while.
            const int DONE_DISPLAY_TIME_MILISECONDS = 1500;
            Task.Delay(DONE_DISPLAY_TIME_MILISECONDS).GetAwaiter().OnCompleted( () => {
                if (LblDone != null)
                    LblDone.Visible = false;
                });
        }

        private void BtnEncode_Click(object sender, EventArgs e)
        {
            EncodeOrDecode(true); //encodes
        }

        private void BtnDecode_Click(object sender, EventArgs e)
        {
            EncodeOrDecode(false); //decodes
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            if( openFileDialog.ShowDialog() == DialogResult.OK )
            {
                inputFileSelected = true;
                LblSelectedInputFile.Text = openFileDialog.FileName;
                LblSelectedInputFile.Visible = true;
                epInput.Clear();
            }
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            if( saveFileDialog.ShowDialog() == DialogResult.OK )
            {
                outputFileSelected = true;
                LblSelectedOutputFile.Text = saveFileDialog.FileName;
                LblSelectedOutputFile.Visible = true;
                epOutput.Clear();
            }
        }

        private void LblKey_MouseHover(object sender, EventArgs e)
        {
            LblKeyHelp.Visible = true;
        }

        private void LblKey_MouseLeave(object sender, EventArgs e)
        {
            LblKeyHelp.Visible = false;
        }
    }
}
