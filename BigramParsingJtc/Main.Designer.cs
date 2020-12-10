namespace BigramParsingJtc
{
    partial class main_form
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
            this.TextInput_radio = new System.Windows.Forms.RadioButton();
            this.FileInput_radio = new System.Windows.Forms.RadioButton();
            this.Input_text = new System.Windows.Forms.TextBox();
            this.Output_text = new System.Windows.Forms.TextBox();
            this.Parse_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectFile_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextInput_radio
            // 
            this.TextInput_radio.AutoSize = true;
            this.TextInput_radio.Checked = true;
            this.TextInput_radio.Location = new System.Drawing.Point(46, 27);
            this.TextInput_radio.Name = "TextInput_radio";
            this.TextInput_radio.Size = new System.Drawing.Size(95, 24);
            this.TextInput_radio.TabIndex = 0;
            this.TextInput_radio.TabStop = true;
            this.TextInput_radio.Text = "Text Input";
            this.TextInput_radio.UseVisualStyleBackColor = true;
            this.TextInput_radio.CheckedChanged += new System.EventHandler(this.TextInput_radio_CheckedChanged);
            // 
            // FileInput_radio
            // 
            this.FileInput_radio.AutoSize = true;
            this.FileInput_radio.Location = new System.Drawing.Point(187, 27);
            this.FileInput_radio.Name = "FileInput_radio";
            this.FileInput_radio.Size = new System.Drawing.Size(91, 24);
            this.FileInput_radio.TabIndex = 0;
            this.FileInput_radio.Text = "File Input";
            this.FileInput_radio.UseVisualStyleBackColor = true;
            this.FileInput_radio.CheckedChanged += new System.EventHandler(this.FileInput_radio_CheckedChanged);
            // 
            // Input_text
            // 
            this.Input_text.Location = new System.Drawing.Point(32, 58);
            this.Input_text.Name = "Input_text";
            this.Input_text.Size = new System.Drawing.Size(616, 27);
            this.Input_text.TabIndex = 1;
            // 
            // Output_text
            // 
            this.Output_text.AllowDrop = true;
            this.Output_text.Location = new System.Drawing.Point(32, 171);
            this.Output_text.Multiline = true;
            this.Output_text.Name = "Output_text";
            this.Output_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output_text.ShortcutsEnabled = false;
            this.Output_text.Size = new System.Drawing.Size(655, 217);
            this.Output_text.TabIndex = 1;
            // 
            // Parse_button
            // 
            this.Parse_button.Location = new System.Drawing.Point(593, 91);
            this.Parse_button.Name = "Parse_button";
            this.Parse_button.Size = new System.Drawing.Size(94, 29);
            this.Parse_button.TabIndex = 2;
            this.Parse_button.Text = "Parse Historgram";
            this.Parse_button.UseVisualStyleBackColor = true;
            this.Parse_button.Click += new System.EventHandler(this.Parse_button_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output";
            // 
            // SelectFile_button
            // 
            this.SelectFile_button.Location = new System.Drawing.Point(655, 58);
            this.SelectFile_button.Name = "SelectFile_button";
            this.SelectFile_button.Size = new System.Drawing.Size(32, 27);
            this.SelectFile_button.TabIndex = 4;
            this.SelectFile_button.Text = "...";
            this.SelectFile_button.UseVisualStyleBackColor = true;
            this.SelectFile_button.Visible = false;
            this.SelectFile_button.Click += new System.EventHandler(this.SelectFile_button_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 419);
            this.Controls.Add(this.SelectFile_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Parse_button);
            this.Controls.Add(this.Output_text);
            this.Controls.Add(this.Input_text);
            this.Controls.Add(this.FileInput_radio);
            this.Controls.Add(this.TextInput_radio);
            this.Name = "main_form";
            this.Text = "Bigram Parsing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton TextInput_radio;
        private System.Windows.Forms.RadioButton FileInput_radio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Parse_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Input_text;
        private System.Windows.Forms.Button SelectFile_button;
        protected internal System.Windows.Forms.TextBox Output_text;
    }
}

