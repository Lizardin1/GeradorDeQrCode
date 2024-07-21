namespace GeradorDeQrCode
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            tb_url = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btn_gerar = new Guna.UI2.WinForms.Guna2Button();
            btn_salvar = new Guna.UI2.WinForms.Guna2Button();
            pb_img_qr_code = new Guna.UI2.WinForms.Guna2PictureBox();
            path_save_file = new FolderBrowserDialog();
            cb_tipo_arquivo = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            qrcode_salvo_notify = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)pb_img_qr_code).BeginInit();
            SuspendLayout();
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.BackColor = SystemColors.ControlText;
            guna2ControlBox1.CustomizableEdges = customizableEdges13;
            guna2ControlBox1.FillColor = SystemColors.ControlLightLight;
            guna2ControlBox1.IconColor = Color.Black;
            guna2ControlBox1.Location = new Point(390, 0);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2ControlBox1.Size = new Size(45, 29);
            guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox2.BackColor = SystemColors.ControlText;
            guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBox2.CustomizableEdges = customizableEdges11;
            guna2ControlBox2.FillColor = SystemColors.ControlLightLight;
            guna2ControlBox2.IconColor = Color.Black;
            guna2ControlBox2.Location = new Point(345, 0);
            guna2ControlBox2.Name = "guna2ControlBox2";
            guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2ControlBox2.Size = new Size(45, 29);
            guna2ControlBox2.TabIndex = 1;
            // 
            // tb_url
            // 
            tb_url.BorderColor = Color.FromArgb(22, 22, 22);
            tb_url.BorderRadius = 15;
            tb_url.CustomizableEdges = customizableEdges9;
            tb_url.DefaultText = "";
            tb_url.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tb_url.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tb_url.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tb_url.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tb_url.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tb_url.Font = new Font("Segoe UI", 9F);
            tb_url.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tb_url.Location = new Point(50, 435);
            tb_url.Margin = new Padding(4, 3, 4, 3);
            tb_url.MaxLength = 1000;
            tb_url.Name = "tb_url";
            tb_url.PasswordChar = '\0';
            tb_url.PlaceholderForeColor = Color.FromArgb(161, 161, 161);
            tb_url.PlaceholderText = "https://exemplo.com";
            tb_url.SelectedText = "";
            tb_url.ShadowDecoration.CustomizableEdges = customizableEdges10;
            tb_url.Size = new Size(368, 36);
            tb_url.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 15F);
            guna2HtmlLabel1.Location = new Point(10, 435);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(33, 30);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "Url:";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // btn_gerar
            // 
            btn_gerar.BorderColor = Color.FromArgb(66, 66, 66);
            btn_gerar.BorderRadius = 15;
            btn_gerar.BorderThickness = 1;
            btn_gerar.Cursor = Cursors.Hand;
            btn_gerar.CustomizableEdges = customizableEdges7;
            btn_gerar.DisabledState.BorderColor = Color.DarkGray;
            btn_gerar.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_gerar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_gerar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_gerar.FillColor = Color.FromArgb(0, 201, 200);
            btn_gerar.Font = new Font("Segoe UI", 9F);
            btn_gerar.ForeColor = Color.FromArgb(22, 22, 22);
            btn_gerar.Location = new Point(18, 501);
            btn_gerar.Name = "btn_gerar";
            btn_gerar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btn_gerar.Size = new Size(102, 36);
            btn_gerar.TabIndex = 4;
            btn_gerar.Text = "Gerar QRCode";
            btn_gerar.Click += btn_gerar_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.BorderColor = Color.FromArgb(66, 66, 66);
            btn_salvar.BorderRadius = 15;
            btn_salvar.BorderThickness = 1;
            btn_salvar.Cursor = Cursors.Hand;
            btn_salvar.CustomizableEdges = customizableEdges5;
            btn_salvar.DisabledState.BorderColor = Color.DarkGray;
            btn_salvar.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_salvar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_salvar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_salvar.FillColor = Color.FromArgb(0, 201, 200);
            btn_salvar.Font = new Font("Segoe UI", 9F);
            btn_salvar.ForeColor = Color.FromArgb(22, 22, 22);
            btn_salvar.Location = new Point(135, 501);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_salvar.Size = new Size(108, 36);
            btn_salvar.TabIndex = 7;
            btn_salvar.Text = "Salvar Imagem";
            btn_salvar.Click += btn_salvar_Click;
            // 
            // pb_img_qr_code
            // 
            pb_img_qr_code.BorderStyle = BorderStyle.FixedSingle;
            pb_img_qr_code.CustomizableEdges = customizableEdges3;
            pb_img_qr_code.ImageRotate = 0F;
            pb_img_qr_code.Location = new Point(10, 35);
            pb_img_qr_code.Name = "pb_img_qr_code";
            pb_img_qr_code.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pb_img_qr_code.Size = new Size(406, 391);
            pb_img_qr_code.SizeMode = PictureBoxSizeMode.Zoom;
            pb_img_qr_code.TabIndex = 8;
            pb_img_qr_code.TabStop = false;
            // 
            // cb_tipo_arquivo
            // 
            cb_tipo_arquivo.BackColor = Color.Transparent;
            cb_tipo_arquivo.BorderColor = Color.FromArgb(66, 66, 66);
            cb_tipo_arquivo.BorderRadius = 15;
            cb_tipo_arquivo.CustomizableEdges = customizableEdges1;
            cb_tipo_arquivo.DrawMode = DrawMode.OwnerDrawFixed;
            cb_tipo_arquivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipo_arquivo.FocusedColor = Color.FromArgb(94, 148, 255);
            cb_tipo_arquivo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cb_tipo_arquivo.Font = new Font("Segoe UI", 10F);
            cb_tipo_arquivo.ForeColor = Color.FromArgb(22, 22, 22);
            cb_tipo_arquivo.ItemHeight = 30;
            cb_tipo_arquivo.Items.AddRange(new object[] { "PNG", "PDF" });
            cb_tipo_arquivo.Location = new Point(259, 501);
            cb_tipo_arquivo.Name = "cb_tipo_arquivo";
            cb_tipo_arquivo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cb_tipo_arquivo.Size = new Size(140, 36);
            cb_tipo_arquivo.TabIndex = 9;
            cb_tipo_arquivo.UseWaitCursor = true;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Location = new Point(259, 480);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(88, 17);
            guna2HtmlLabel2.TabIndex = 10;
            guna2HtmlLabel2.Text = "Tipo de arquivo:";
            // 
            // qrcode_salvo_notify
            // 
            qrcode_salvo_notify.Icon = (Icon)resources.GetObject("qrcode_salvo_notify.Icon");
            qrcode_salvo_notify.Text = "ArquivoSalvo";
            qrcode_salvo_notify.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(434, 559);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(cb_tipo_arquivo);
            Controls.Add(pb_img_qr_code);
            Controls.Add(btn_salvar);
            Controls.Add(btn_gerar);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(tb_url);
            Controls.Add(guna2ControlBox2);
            Controls.Add(guna2ControlBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pb_img_qr_code).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox tb_url;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn_salvar;
        private Guna.UI2.WinForms.Guna2Button btn_gerar;
        private Guna.UI2.WinForms.Guna2PictureBox pb_img_qr_code;
        private FolderBrowserDialog path_save_file;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cb_tipo_arquivo;
        private NotifyIcon qrcode_salvo_notify;
    }
}
