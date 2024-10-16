namespace FileCleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckFiles_Click(object sender, EventArgs e)
        {
            string directoryPath = @"C:\Users\Junior\Downloads"; // Altere para o diretório desejado
            ListFiles(directoryPath);
        }

        private void ListFiles(string directoryPath)
        {
            listBoxFiles.Items.Clear();
            DirectoryInfo dirInfo = new DirectoryInfo(directoryPath);

            // Verifica se o diretório existe
            if (!dirInfo.Exists)
            {
                listBoxFiles.Items.Add("Diretório não encontrado.");
                return;
            }

            FileInfo[] files = dirInfo.GetFiles();

            foreach (FileInfo file in files)
            {
                TimeSpan age = DateTime.Now - file.CreationTime;
                listBoxFiles.Items.Add($"{file.Name} - {age.Days} dias");

                // Se o arquivo tiver mais de 7 dias, apague-o
                if (age.TotalDays > 7)
                {
                    try
                    {
                        file.Delete();
                        listBoxFiles.Items.Add($"{file.Name} foi apagado.");
                    }
                    catch (Exception ex)
                    {
                        listBoxFiles.Items.Add($"Erro ao apagar {file.Name}: {ex.Message}");
                    }
                }
            }

            if (files.Length == 0)
            {
                listBoxFiles.Items.Add("Nenhum arquivo encontrado no diretório.");
            }
        }
    }
}