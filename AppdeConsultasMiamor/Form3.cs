using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;







namespace AppdeConsultasMiamor
{
    public partial class Form3 : Form


    {
        private string masterFolderPath;
        private string subFolderPath;
        private string pdfXmlFolderPath;



        public Form3()


        {
            InitializeComponent();
            this.SizeChanged += Form3_SizeChanged;
            ConfigureUI();
            BtnUnirPdfPrincipal.Click += BtnUnirPdfPrincipal_Click;

        }

        private void ConfigureUI()

        {




            DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DataGridView1.GridColor = Color.White;

            DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 200);
            DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            DataGridView1.DefaultCellStyle.BackColor = Color.White;
            DataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;


            ConfigureButtonsNeon();
        }

        private void ConfigureButtonsNeon()
        {
            var buttonColors = new Dictionary<System.Windows.Forms.Button, Color>()
        {
            { BtnCargarExcel, Color.FromArgb(42, 157, 143) }, // Cian
            { BtnCrearCarpetaMaster, Color.FromArgb(255, 64, 129) }, // Rosa neón
            { BtnPdfXml, Color.FromArgb(255, 196, 0) }, // Amarillo neón
            { BtnBye2, Color.FromArgb(0, 230, 64) } // Verde neón
        };

            foreach (var buttonColor in buttonColors)
            {
                var button = buttonColor.Key;
                button.BackColor = buttonColor.Value;
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = Color.White;
                button.FlatAppearance.BorderSize = 0;
                button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button.Width, button.Height, 15, 15));
            }


            // Establecer bordes redondeados para botones
            BtnCargarExcel.FlatAppearance.BorderSize = 0;
            BtnCargarExcel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnCargarExcel.Width, BtnCargarExcel.Height, 15, 15));

            BtnCrearCarpetaMaster.FlatAppearance.BorderSize = 0;
            BtnCrearCarpetaMaster.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnCrearCarpetaMaster.Width, BtnCrearCarpetaMaster.Height, 15, 15));

            BtnPdfXml.FlatAppearance.BorderSize = 0;
            BtnPdfXml.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnPdfXml.Width, BtnPdfXml.Height, 15, 15));

            BtnBye2.FlatAppearance.BorderSize = 0;
            BtnBye2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnBye2.Width, BtnBye2.Height, 15, 15));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        // Evento para el TreeView cuando se pasa el mouse sobre un nodo
        private void TreeView1_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            e.Node.BackColor = Color.Black;
        }





        // Evento para el DataGridView cuando se pasa el mouse sobre una celda
        private void DataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Asegurar que la celda sea válida
            {
                DataGridViewCell cell = DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Style.BackColor = Color.Black; // Cambiar el fondo de la celda a negro
            }
        }

        // Evento para el DataGridView cuando se sale el mouse de una celda
        private void DataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Asegurar que la celda sea válida
            {
                DataGridViewCell cell = DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Style.BackColor = Color.White; // Restaurar el fondo de la celda al color original o a otro que desees
            }
        }

        private void Form3_SizeChanged(object sender, EventArgs e)
        {
            DataGridView1.Width = this.ClientSize.Width - 50; // Ajusta el ancho del DataGridView1
            DataGridView1.Height = this.ClientSize.Height - 100; // Ajusta la altura del DataGridView1

            treeView1Dat.Width = this.ClientSize.Width - 50; // Ajusta el ancho del TreeView1
            treeView1Dat.Height = this.ClientSize.Height - 100; // Ajusta la altura del TreeView1
        }


        public void BtnCargarExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Archivos de Excel|*.xls;*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm",
                Title = "Seleccionar archivo de Excel"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var stream = File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                    using (var excelReader = openFileDialog1.FileName.EndsWith(".xls")
                        ? ExcelReaderFactory.CreateBinaryReader(stream)
                        : ExcelReaderFactory.CreateOpenXmlReader(stream))
                    {
                        DataSet result = excelReader.AsDataSet();
                        int numberOfSheets = result.Tables.Count;

                        var sheetDialog = new SheetSelectionDialog(numberOfSheets);
                        if (sheetDialog.ShowDialog() == DialogResult.OK)
                        {
                            int selectedSheetIndex = sheetDialog.SelectedSheetIndex;

                            if (selectedSheetIndex >= 0 && selectedSheetIndex < numberOfSheets)
                            {
                                DataTable table = result.Tables[selectedSheetIndex];

                                // Mostrar los datos en el DataGridView1
                                SetDataGridViewWithHeaders(DataGridView1, table);
                            }
                            else
                            {
                                MessageBox.Show("Índice de hoja no válido.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el archivo: " + ex.Message);
                }
            }
        }

        public void SetDataGridViewWithHeaders(DataGridView dataGridView, DataTable table)
        {
            DataGridView1.Rows.Clear();
            DataGridView1.Columns.Clear();

            if (table.Rows.Count == 0 || table.Columns.Count == 0)
            {
                DataGridView1.DataSource = null;
                return;
            }

            int maxRowIndex = table.Rows.Count - 1;
            int maxColumnIndex = table.Columns.Count - 1;

            DataGridView1.RowHeadersVisible = true;
            for (int i = 0; i <= maxColumnIndex; i++)
            {
                DataGridView1.Columns.Add(ConvertToLetter(i), ConvertToLetter(i));
            }

            for (int i = 0; i <= maxRowIndex; i++)
            {
                DataGridView1.Rows.Add();
                DataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();

                for (int j = 0; j <= maxColumnIndex; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = table.Rows[i][j].ToString();
                    dataGridView.Rows[i].Cells[j].Tag = ConvertToLetter(j) + (i + 1).ToString();
                }
            }
        }

        public string ConvertToLetter(int columnIndex)
        {
            int dividend = columnIndex + 1;
            string columnName = string.Empty;

            while (dividend > 0)
            {
                int modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }

            return columnName;
        }

        public void BtnBye2_Click(object sender, EventArgs e)
        {
            this.Close();

            if (Application.OpenForms.OfType<Form2>().Any())
            {
                Form2 existingForm2 = Application.OpenForms.OfType<Form2>().First();
                existingForm2.Focus();
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        public void BtnCrearCarpetaMaster_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string rootFolderPath = folderBrowserDialog1.SelectedPath;

                string masterFolderName = GetMasterFolderName();

                if (string.IsNullOrWhiteSpace(masterFolderName))
                {
                    MessageBox.Show("Debe ingresar un nombre para la carpeta madre.");
                    return;
                }

                string masterFolderPath = Path.Combine(rootFolderPath, masterFolderName);
                Directory.CreateDirectory(masterFolderPath);

                // Mensaje de depuración para verificar la ruta de la carpeta "master" creada
                MessageBox.Show($"Ruta de la carpeta 'master': {masterFolderPath}");

                // Inicializa masterFolderPath aquí para que esté disponible en otros métodos
                this.masterFolderPath = masterFolderPath; // 'this' se refiere a la instancia actual de la clase Form3

                // Pasar masterFolderPath como argumento a CreateFoldersBasedOnDataGridView
                CreateFoldersBasedOnDataGridView(masterFolderPath);
            }
        }



        public string GetMasterFolderName()
        {
            using (var inputBoxForm = new InputBoxForm())
            {
                if (inputBoxForm.ShowDialog() == DialogResult.OK)
                {
                    return inputBoxForm.EnteredText;
                }
            }

            return string.Empty;
        }



        private void CreateFoldersBasedOnDataGridView(string masterFolderPath)
        {
            int carpetaColumnIndex = 0;
            int subcarpetaColumnIndex = 1;
            int carpetaPrincipalColumnIndex = 4;

            Dictionary<string, List<string>> folders = new Dictionary<string, List<string>>();

            // Recopilar información de las celdas del DataGridView
            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                // Verificar si la columna A no está en blanco y la columna E no está en blanco
                if (row.Cells[carpetaColumnIndex].Value != null &&
                    row.Cells[carpetaPrincipalColumnIndex].Value != null &&
                    !string.IsNullOrEmpty(row.Cells[carpetaColumnIndex].Value.ToString()) &&
                    !string.IsNullOrEmpty(row.Cells[carpetaPrincipalColumnIndex].Value.ToString()) &&
                    row.Cells[carpetaPrincipalColumnIndex].Value.ToString().StartsWith("OTM "))
                {
                    string mainFolderName = row.Cells[carpetaColumnIndex].Value.ToString();

                    if (!folders.ContainsKey(mainFolderName))
                    {
                        folders[mainFolderName] = new List<string>();
                    }

                    if (subcarpetaColumnIndex != -1 && row.Cells[subcarpetaColumnIndex].Value != null)
                    {
                        string subFolderName = row.Cells[subcarpetaColumnIndex].Value.ToString();

                        if (!string.IsNullOrEmpty(subFolderName) && subFolderName != mainFolderName)
                        {
                            folders[mainFolderName].Add(subFolderName);
                        }
                    }
                }
            }

            // Crear las carpetas y subcarpetas
            foreach (var mainFolder in folders)
            {
                // Nombre de la carpeta principal, se añade "OTM" al inicio del nombre
                string mainFolderName = "OTM " + mainFolder.Key;

                // Ruta completa de la carpeta principal
                string mainFolderPath = Path.Combine(masterFolderPath, mainFolderName);

                // Verificar si la carpeta principal ya existe
                if (!Directory.Exists(mainFolderPath))
                {
                    // Si no existe, crear la carpeta principal
                    Directory.CreateDirectory(mainFolderPath);
                }

                // Iterar a través de las subcarpetas asociadas a la carpeta principal
                foreach (var subFolderName in mainFolder.Value)
                {
                    // Ruta completa de la subcarpeta dentro de la carpeta principal
                    string subFolderPath = Path.Combine(mainFolderPath, subFolderName);

                    // Verificar si la subcarpeta ya existe dentro de la carpeta principal
                    if (!Directory.Exists(subFolderPath))
                    {
                        // Si no existe, crear la subcarpeta dentro de la carpeta principal
                        Directory.CreateDirectory(subFolderPath);
                    }
                    // Se asegura de que no se creen subcarpetas duplicadas dentro de la carpeta principal
                }
            }

            // Actualizar el TreeView después de la creación
            UpdateTreeView(masterFolderPath);
            EliminarCarpetasDuplicadasVacias(masterFolderPath);
        }



        private async void BtnPdfXml_Click_1(object sender, EventArgs e)
        {
            pdfXmlFolderPath = ObtenerCarpetaArchivos();
            if (!string.IsNullOrEmpty(pdfXmlFolderPath))
            {
                await ProcesarArchivosPDFyXML(pdfXmlFolderPath);
            }
        }


        private string ObtenerCarpetaArchivos()
        {
            FolderBrowserDialog folderBrowserDialog2 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog2.ShowDialog();

            if (result == DialogResult.OK)
            {
                return folderBrowserDialog2.SelectedPath;
            }

            return null;
        }


        // Función para buscar y copiar archivos PDF y XML a las subcarpetas correspondientes
        // Función para buscar y copiar archivos PDF y XML a las subcarpetas correspondientes
        private async Task ProcesarArchivosPDFyXML(string pdfXmlFolderPath)
        {
            List<string> errores = new List<string>();

            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                string nombreSubcarpeta = row.Cells["B"].Value?.ToString();
                string nombreArchivoBuscado = row.Cells["D"].Value?.ToString();
                string nombreFinalCarpeta = row.Cells["E"].Value?.ToString();

                if (!string.IsNullOrEmpty(nombreSubcarpeta) &&
                    !string.IsNullOrEmpty(nombreArchivoBuscado) &&
                    !string.IsNullOrEmpty(nombreFinalCarpeta))
                {
                    string rutaDestino = Path.Combine(masterFolderPath, nombreFinalCarpeta, nombreSubcarpeta);

                    try
                    {
                        string rutaArchivoPDF = Path.Combine(pdfXmlFolderPath, $"{nombreArchivoBuscado}.pdf");
                        string rutaArchivoXML = Path.Combine(pdfXmlFolderPath, $"{nombreArchivoBuscado}.xml");

                        if (File.Exists(rutaArchivoPDF) && File.Exists(rutaArchivoXML))
                        {
                            Directory.CreateDirectory(rutaDestino);

                            string rutaArchivoPDFDestino = Path.Combine(rutaDestino, $"{nombreSubcarpeta}PDF.pdf");
                            string rutaArchivoXMLDestino = Path.Combine(rutaDestino, $"{nombreSubcarpeta}XML.xml");

                            await Task.Run(() =>
                            {
                                File.Copy(rutaArchivoPDF, rutaArchivoPDFDestino, true);
                                File.Copy(rutaArchivoXML, rutaArchivoXMLDestino, true);
                            });
                        }
                        else
                        {
                            errores.Add($"Los archivos PDF y XML para '{nombreArchivoBuscado}' no existen en la carpeta seleccionada.");
                        }
                    }
                    catch (Exception ex)
                    {
                        errores.Add($"Error al copiar archivos para '{nombreArchivoBuscado}': {ex.Message}");
                    }
                }
            }

            if (errores.Any())
            {
                string mensajeErrores = string.Join(Environment.NewLine, errores);
                string mensajeFinal = $"¡Ups! Se encontraron algunos errores:{Environment.NewLine}{mensajeErrores}";
                Clipboard.SetText(mensajeFinal); // Copiar al portapapeles el mensaje de errores
                MessageBox.Show(mensajeFinal, "Errores Pendientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("¡Proceso completado sin errores!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UpdateTreeView(masterFolderPath);

        }

















        private void UpdateTreeView(string masterFolderPath)
        {
            treeView1Dat.Nodes.Clear(); // Limpia los nodos existentes en el TreeView
            PopulateTreeView(masterFolderPath);
            ShowPDFandXMLFiles(masterFolderPath);
            treeView1Dat.ExpandAll(); // Expandir todos los nodos del TreeView
        }



        private void PopulateTreeView(string masterFolderPath)
        {
            treeView1Dat.Nodes.Clear(); // Limpia los nodos existentes en el TreeView
            DirectoryInfo directoryInfo = new DirectoryInfo(masterFolderPath);
            if (directoryInfo.Exists)
            {
                TreeNode rootNode = CreateDirectoryNode(directoryInfo);
                treeView1Dat.Nodes.Add(rootNode);
                ExploreFolders(masterFolderPath, rootNode);
            }
        }

        private TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            TreeNode directoryNode = new TreeNode(directoryInfo.Name);
            directoryNode.Tag = directoryInfo.FullName;
            return directoryNode;
        }


        private void ExploreFolders(string rootFolderPath, TreeNode parentNode)
        {
            try
            {
                string[] subDirectories = Directory.GetDirectories(rootFolderPath);

                foreach (string subDir in subDirectories)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(subDir);
                    TreeNode childNode = CreateDirectoryNode(directoryInfo);
                    parentNode.Nodes.Add(childNode);
                    ExploreFolders(subDir, childNode); // Llamada recursiva para las subcarpetas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void BtnOpenFolders_Click(object sender, EventArgs e)
        {
            UpdateTreeView(masterFolderPath);
        }



        private void ShowPDFandXMLFiles(string masterFolderPath)
        {
            try
            {
                DirectoryInfo masterDirectory = new DirectoryInfo(masterFolderPath);

                foreach (TreeNode node in treeView1Dat.Nodes)
                {
                    if (node.Text == masterDirectory.Name)
                    {
                        foreach (TreeNode childNode in node.Nodes)
                        {
                            ShowFilesInSubfolders(childNode);
                        }
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ShowFilesInSubfolders(TreeNode parentNode)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(parentNode.Tag.ToString());

                foreach (TreeNode node in parentNode.Nodes)
                {
                    // Verificar si el nodo no tiene nodos hijos (subcarpetas)
                    if (node.Nodes.Count == 0)
                    {
                        string nodeFolderPath = Path.Combine(directoryInfo.FullName, node.Text);

                        // Agregar archivos PDF y XML del nodo actual
                        AddPDFandXMLFilesToNode(node, nodeFolderPath);

                        // Explorar subcarpetas y sus archivos
                        ExploreSubfolders(node, nodeFolderPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ExploreSubfolders(TreeNode parentNode, string folderPath)
        {
            try
            {
                string[] subDirectories = Directory.GetDirectories(folderPath);

                foreach (string subDir in subDirectories)
                {
                    DirectoryInfo subDirectoryInfo = new DirectoryInfo(subDir);
                    TreeNode subNode = new TreeNode(subDirectoryInfo.Name);

                    // Agregar archivos PDF y XML de la subcarpeta actual
                    AddPDFandXMLFilesToNode(subNode, subDir);

                    // Recursivamente explorar subcarpetas y sus archivos
                    ExploreSubfolders(subNode, subDir);

                    parentNode.Nodes.Add(subNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddPDFandXMLFilesToNode(TreeNode node, string folderPath)
        {
            string[] pdfFiles = Directory.GetFiles(folderPath, "*.pdf");
            string[] xmlFiles = Directory.GetFiles(folderPath, "*.xml");

            foreach (string pdfFile in pdfFiles)
            {
                node.Nodes.Add(new TreeNode(Path.GetFileName(pdfFile)));
            }

            foreach (string xmlFile in xmlFiles)
            {
                node.Nodes.Add(new TreeNode(Path.GetFileName(xmlFile)));
            }
        }




        private void treeView1Dat_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la letra de la columna según el índice
                string columnName = ConvertToLetter(e.ColumnIndex);

                // Obtener el número de fila y sumar 1 porque las filas son base 0
                int rowNumber = e.RowIndex + 1;

                // Mostrar la posición actual
                MessageBox.Show($"Estás en la celda {columnName}{rowNumber}");
            }
        }

        private void EliminarCarpetasDuplicadasVacias(string masterFolderPath)
        {
            try
            {
                DirectoryInfo masterDirectory = new DirectoryInfo(masterFolderPath);
                if (masterDirectory.Exists)
                {
                    Dictionary<string, List<string>> folders = GetFoldersDictionary(masterFolderPath);

                    foreach (var mainFolder in folders)
                    {
                        string mainFolderPath = Path.Combine(masterFolderPath, "OTM " + mainFolder.Key);

                        // Obtener la lista de subcarpetas en la carpeta principal
                        List<string> subFolders = mainFolder.Value;

                        // Diccionario para almacenar información relacionada con las subcarpetas vacías
                        Dictionary<string, string> emptySubFoldersInfo = new Dictionary<string, string>();


                        foreach (var subFolderName in subFolders)
                        {
                            string subFolderPath = Path.Combine(mainFolderPath, subFolderName);

                            // Verificar si la carpeta está vacía
                            if (IsDirectoryEmpty(subFolderPath))
                            {
                                // Si está vacía, eliminarla
                                Directory.Delete(subFolderPath);

                                // Mensaje de depuración
                                MessageBox.Show($"Se eliminó la carpeta vacía: {subFolderPath}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar carpetas vacías: " + ex.Message);
            }
        }

        public bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }

        public Dictionary<string, List<string>> GetFoldersDictionary(string masterFolderPath)
        {
            Dictionary<string, List<string>> folders = new Dictionary<string, List<string>>();

            try
            {
                DirectoryInfo masterDirectory = new DirectoryInfo(masterFolderPath);

                if (masterDirectory.Exists)
                {
                    // Obtener todas las subcarpetas en la carpeta principal
                    string[] subDirectories = Directory.GetDirectories(masterFolderPath);

                    foreach (string subDir in subDirectories)
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(subDir);

                        // Agregar el nombre de la carpeta principal y sus subcarpetas a un diccionario
                        string mainFolderName = directoryInfo.Name;
                        List<string> subFolders = new List<string>();

                        string[] subFoldersArray = Directory.GetDirectories(subDir);
                        foreach (string subFolder in subFoldersArray)
                        {
                            DirectoryInfo subFolderInfo = new DirectoryInfo(subFolder);
                            subFolders.Add(subFolderInfo.Name);
                        }

                        folders.Add(mainFolderName, subFolders);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener información de carpetas: " + ex.Message);
            }

            return folders;
        }







        private async void BtnUnirPdfPrincipal_Click(object sender, EventArgs e)
        {
            string masterFolderPath = SelectMasterFolder();

            if (string.IsNullOrEmpty(masterFolderPath))
            {
                MessageBox.Show("No se seleccionó ninguna carpeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            System.Windows.Forms.TextBox txtFallas = new System.Windows.Forms.TextBox();
            txtFallas.Clear();

            await CopyAndCombinePDFsInSubfoldersAsync(masterFolderPath, txtFallas);

            if (string.IsNullOrWhiteSpace(txtFallas.Text))
            {
                MessageBox.Show("Archivos PDF combinados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Algunos errores ocurrieron durante la combinación de archivos PDF. Consulta los detalles en el registro de errores.", "Errores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task CopyAndCombinePDFsInSubfoldersAsync(string masterFolderPath, System.Windows.Forms.TextBox txtFallas)
        {
            try
            {
                string[] subDirectories = Directory.GetDirectories(masterFolderPath);

                foreach (string subDir in subDirectories)
                {
                    await CopyAndCombinePDFsInDirectoryAsync(subDir, txtFallas);
                }
            }
            catch (Exception ex)
            {
                txtFallas.AppendText($"Error al copiar y combinar archivos PDF en las subcarpetas: {ex.Message}" + Environment.NewLine);
            }
        }

        private async Task CopyAndCombinePDFsInDirectoryAsync(string directoryPath, System.Windows.Forms.TextBox txtFallas)
        {
            try
            {
                string[] pdfFiles = Directory.GetFiles(directoryPath, "*.pdf");

                if (pdfFiles.Length > 0)
                {
                    string subFolderName = new DirectoryInfo(directoryPath).Name;

                    // Crear una carpeta temporal dentro de la carpeta principal
                    string tempFolderPath = Path.Combine(directoryPath, "Temp");
                    Directory.CreateDirectory(tempFolderPath);

                    foreach (string pdfFile in pdfFiles)
                    {
                        string newFileName = $"{subFolderName}_EVIDENCIA.pdf";
                        string newFilePath = Path.Combine(tempFolderPath, newFileName);

                        // Copiar y renombrar el archivo PDF a la carpeta temporal
                        await Task.Run(() => File.Copy(pdfFile, newFilePath));
                    }

                    // Combinar los archivos PDF renombrados en uno solo
                    await CombinePDFsInDirectoryAsync(tempFolderPath, Path.Combine(directoryPath, $"{subFolderName}_COMBINADO.pdf"));

                    // Eliminar la carpeta temporal
                    Directory.Delete(tempFolderPath, true);
                }
            }
            catch (Exception ex)
            {
                txtFallas.AppendText($"Error al copiar y combinar archivos PDF en {directoryPath}: {ex.Message}" + Environment.NewLine);
            }
        }

        private async Task CombinePDFsInDirectoryAsync(string directoryPath, string combinedFilePath)
        {
            try
            {
                string[] pdfFiles = Directory.GetFiles(directoryPath, "*.pdf");

                if (pdfFiles.Length > 1)
                {
                    using (var pdfWriter = new PdfWriter(combinedFilePath))
                    {
                        using (var pdfDocument = new PdfDocument(pdfWriter))
                        {
                            var pdfMerger = new PdfMerger(pdfDocument);

                            foreach (string pdfFile in pdfFiles)
                            {
                                pdfMerger.Merge(new PdfDocument(new PdfReader(pdfFile)), 1, 1);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al combinar archivos PDF en {directoryPath}: {ex.Message}");
            }
        }

        private string SelectMasterFolder()
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    return folderBrowserDialog.SelectedPath;
                }
                else
                {
                    return null;
                }
            }
        }

    }
    }
