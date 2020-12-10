using System;
using System.IO;
using System.Windows.Forms;
using ParsingService.Services;
using ParsingService.Services.Exceptions;

namespace BigramParsingJtc
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private async void Parse_button_click(object sender, EventArgs e)
        {
            var fileInput = FileInput_radio.Checked;
            var textInput = TextInput_radio.Checked;
            var input = Input_text.Text;

            var parsingService = new BigramParser(new ParserOutputRenderer() );
            var output = string.Empty;
            var content = string.Empty;
            try
            {
                if (textInput)
                {
                    var parser = new BigramParser(new ParserOutputRenderer());
                    parser.Parse(input);
                    output = parser.GetContent();
                }
                else if (fileInput)
                {
                    var parser = new BigramParser(new ParserOutputRenderer());
                    var fileService = new ParserFileService(parser, input); 
                    fileService.Read();
                    output = fileService.GetContent();
                }
            }
            catch (FileNotFoundException ex)
            {
                output = "File was not found.";
            }
            catch (InvalidFileTypeException ex)
            {
                output = "File is invalid.";
            }
            catch (UnauthorizedAccessException ex)
            {
                output = "File access wasn't authorized.";
            }
            catch (ArgumentNullException ex)
            {
                output = "Please provide input before attempting to parse.";
            }
            catch (Exception ex)
            {
                output = "Could not process the file.\r\nSee error message below.\r\n" + ex.Message;
            }

            Output_text.Text = output;
        }

        private void FileInput_radio_CheckedChanged(object sender, EventArgs e)
        {
            Input_text.Text = "";
            SelectFile_button.Visible = true;
        }

        private void TextInput_radio_CheckedChanged(object sender, EventArgs e)
        {
            Input_text.Text = "";
            SelectFile_button.Visible = false;
        }

        private void SelectFile_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;

                    Input_text.Text = filePath;
                }
            }
        }
    }
}
