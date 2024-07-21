namespace GeradorDeQrCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            GenerateByteArray(tb_url.Text);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_tipo_arquivo.Text))
            {
                MessageBox.Show("Escolha um tipo de arquivo.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cb_tipo_arquivo.SelectedIndex == 0)
            {
                if(pb_img_qr_code.Image is null)
                {
                    MessageBox.Show("Gere um QrCode antes de salvar.", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (path_save_file.ShowDialog() == DialogResult.OK)
                {
                    string pathPng = GenerateUniqueFileName(path_save_file.SelectedPath, "QrCode.png");
                    SalvarQrCode.SaveQrCodePng(pb_img_qr_code.Image, pathPng);
                    qrcode_salvo_notify.ShowBalloonTip(1, "QrCode Salvo com sucesso", "Sucesso", ToolTipIcon.Info);

                    return;
                }
            }

            if (path_save_file.ShowDialog() == DialogResult.OK)
            {
                string pathPng = GenerateUniqueFileName(path_save_file.SelectedPath, "QrCode.pdf");
                SalvarQrCode.SavePdf(pb_img_qr_code.Image, pathPng);
                qrcode_salvo_notify.ShowBalloonTip(1, "QrCode Salvo com sucesso", "Sucesso", ToolTipIcon.Info);
            }
        }
 
        public byte[] GenerateByteArray(string url)
        {
            var image = GerarQrCode.QrCodeGenerator(url);
            pb_img_qr_code.Image = image;
            return GerarQrCode.ImageToByte(image);
        }

        private string GenerateUniqueFileName(string file, string extension)
        {
            string data = DateTime.Now.ToString("yyyy-MM-ddHH-mm-ss");
            return $"{file}\\{data}-{extension}";
        }
    }
}
