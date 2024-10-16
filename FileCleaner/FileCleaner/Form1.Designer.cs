
namespace FileCleaner
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCheckFiles = new Button();
            listBoxFiles = new ListBox();
            SuspendLayout();
            // 
            // btnCheckFiles
            // 
            btnCheckFiles.Location = new Point(163, 324);
            btnCheckFiles.Name = "btnCheckFiles";
            btnCheckFiles.Size = new Size(521, 95);
            btnCheckFiles.TabIndex = 0;
            btnCheckFiles.Text = "Verificar e Apagar Arquivos";
            btnCheckFiles.UseVisualStyleBackColor = true;
            btnCheckFiles.Click += btnCheckFiles_Click;
            // 
            // listBoxFiles
            // 
            listBoxFiles.BackColor = SystemColors.ActiveCaption;
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.ItemHeight = 15;
            listBoxFiles.Location = new Point(113, 43);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(630, 244);
            listBoxFiles.TabIndex = 1;
            listBoxFiles.SelectedIndexChanged += listBoxFiles_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(872, 526);
            Controls.Add(listBoxFiles);
            Controls.Add(btnCheckFiles);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "FileCleaner";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnCheckFiles;
        private ListBox listBoxFiles;
    }
}
