namespace VS_Web
{
    partial class Form1
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
            this.painelNavegacao = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnFecharMenu = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnHome = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnGoogle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnPesquisar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnRecarregar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAvancar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnVoltar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tboxURL = new Guna.UI2.WinForms.Guna2TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pbox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSair = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.painelNavegacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelNavegacao
            // 
            this.painelNavegacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.painelNavegacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.painelNavegacao.Controls.Add(this.btnMenu);
            this.painelNavegacao.Controls.Add(this.btnFecharMenu);
            this.painelNavegacao.Controls.Add(this.btnHome);
            this.painelNavegacao.Controls.Add(this.btnGoogle);
            this.painelNavegacao.Controls.Add(this.btnPesquisar);
            this.painelNavegacao.Controls.Add(this.btnRecarregar);
            this.painelNavegacao.Controls.Add(this.btnAvancar);
            this.painelNavegacao.Controls.Add(this.btnVoltar);
            this.painelNavegacao.Controls.Add(this.tboxURL);
            this.painelNavegacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelNavegacao.Location = new System.Drawing.Point(0, 0);
            this.painelNavegacao.Name = "painelNavegacao";
            this.painelNavegacao.Size = new System.Drawing.Size(803, 46);
            this.painelNavegacao.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.Animated = true;
            this.btnMenu.BackgroundImage = global::VS_Web.Properties.Resources.menu_vertical_48px;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.BorderColor = System.Drawing.Color.Aqua;
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnMenu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(778, 13);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMenu.Size = new System.Drawing.Size(22, 19);
            this.btnMenu.TabIndex = 19;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnFecharMenu
            // 
            this.btnFecharMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFecharMenu.Animated = true;
            this.btnFecharMenu.BackgroundImage = global::VS_Web.Properties.Resources.menu_vertical_48px;
            this.btnFecharMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFecharMenu.BorderColor = System.Drawing.Color.Aqua;
            this.btnFecharMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFecharMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFecharMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFecharMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFecharMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnFecharMenu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharMenu.ForeColor = System.Drawing.Color.White;
            this.btnFecharMenu.Location = new System.Drawing.Point(778, 12);
            this.btnFecharMenu.Name = "btnFecharMenu";
            this.btnFecharMenu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnFecharMenu.Size = new System.Drawing.Size(22, 23);
            this.btnFecharMenu.TabIndex = 20;
            this.btnFecharMenu.Visible = false;
            this.btnFecharMenu.Click += new System.EventHandler(this.btnFecharMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.Animated = true;
            this.btnHome.BackgroundImage = global::VS_Web.Properties.Resources.home_52px;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.BorderColor = System.Drawing.Color.Aqua;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(83, 11);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnHome.Size = new System.Drawing.Size(22, 19);
            this.btnHome.TabIndex = 18;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoogle.Animated = true;
            this.btnGoogle.BackgroundImage = global::VS_Web.Properties.Resources.google_48px;
            this.btnGoogle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoogle.BorderColor = System.Drawing.Color.Aqua;
            this.btnGoogle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGoogle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGoogle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGoogle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGoogle.FillColor = System.Drawing.Color.Transparent;
            this.btnGoogle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoogle.ForeColor = System.Drawing.Color.White;
            this.btnGoogle.Location = new System.Drawing.Point(687, 11);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnGoogle.Size = new System.Drawing.Size(22, 19);
            this.btnGoogle.TabIndex = 17;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Animated = true;
            this.btnPesquisar.BackColor = System.Drawing.Color.DimGray;
            this.btnPesquisar.BackgroundImage = global::VS_Web.Properties.Resources.search_64px;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisar.BorderColor = System.Drawing.Color.Aqua;
            this.btnPesquisar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPesquisar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPesquisar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPesquisar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPesquisar.FillColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(651, 13);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPesquisar.Size = new System.Drawing.Size(19, 18);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Animated = true;
            this.btnRecarregar.BackgroundImage = global::VS_Web.Properties.Resources.refresh_64px;
            this.btnRecarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecarregar.BorderColor = System.Drawing.Color.Aqua;
            this.btnRecarregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecarregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRecarregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecarregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRecarregar.FillColor = System.Drawing.Color.Transparent;
            this.btnRecarregar.Font = new System.Drawing.Font("Cambria", 12F);
            this.btnRecarregar.ForeColor = System.Drawing.Color.White;
            this.btnRecarregar.Location = new System.Drawing.Point(56, 12);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRecarregar.Size = new System.Drawing.Size(22, 19);
            this.btnRecarregar.TabIndex = 15;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.Animated = true;
            this.btnAvancar.BackgroundImage = global::VS_Web.Properties.Resources.double_right_52px;
            this.btnAvancar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAvancar.BorderColor = System.Drawing.Color.Aqua;
            this.btnAvancar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAvancar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAvancar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAvancar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAvancar.FillColor = System.Drawing.Color.Transparent;
            this.btnAvancar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancar.ForeColor = System.Drawing.Color.White;
            this.btnAvancar.Location = new System.Drawing.Point(32, 12);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAvancar.Size = new System.Drawing.Size(22, 19);
            this.btnAvancar.TabIndex = 14;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Animated = true;
            this.btnVoltar.BackgroundImage = global::VS_Web.Properties.Resources.double_left_52px;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.BorderColor = System.Drawing.Color.Aqua;
            this.btnVoltar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoltar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVoltar.FillColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(4, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnVoltar.Size = new System.Drawing.Size(22, 19);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tboxURL
            // 
            this.tboxURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxURL.Animated = true;
            this.tboxURL.BorderRadius = 10;
            this.tboxURL.BorderThickness = 0;
            this.tboxURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxURL.DefaultText = "";
            this.tboxURL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxURL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxURL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxURL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxURL.FillColor = System.Drawing.Color.DimGray;
            this.tboxURL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxURL.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxURL.ForeColor = System.Drawing.Color.White;
            this.tboxURL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxURL.Location = new System.Drawing.Point(114, 10);
            this.tboxURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxURL.Name = "tboxURL";
            this.tboxURL.PasswordChar = '\0';
            this.tboxURL.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxURL.PlaceholderText = "Pesquisar";
            this.tboxURL.SelectedText = "";
            this.tboxURL.Size = new System.Drawing.Size(566, 24);
            this.tboxURL.TabIndex = 12;
            this.tboxURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxURL_KeyDown);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 46);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(803, 461);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Visible = false;
            // 
            // pbox
            // 
            this.pbox.BackColor = System.Drawing.Color.Transparent;
            this.pbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox.Image = global::VS_Web.Properties.Resources.computer_engineering_science_tech_wallpaper_preview;
            this.pbox.ImageRotate = 0F;
            this.pbox.Location = new System.Drawing.Point(0, 46);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(803, 461);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox.TabIndex = 2;
            this.pbox.TabStop = false;
            this.pbox.UseTransparentBackground = true;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.pnlMenu.Controls.Add(this.guna2Button1);
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenu.Location = new System.Drawing.Point(651, 46);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(152, 461);
            this.pnlMenu.TabIndex = 3;
            this.pnlMenu.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.BorderRadius = 10;
            this.btnSair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSair.FillColor = System.Drawing.Color.Transparent;
            this.btnSair.FocusedColor = System.Drawing.Color.Transparent;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSair.ForeColor = System.Drawing.Color.Aqua;
            this.btnSair.Image = global::VS_Web.Properties.Resources.exit_48px;
            this.btnSair.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSair.ImageSize = new System.Drawing.Size(34, 34);
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(30, 428);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(94, 30);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSair.TextFormatNoPrefix = true;
            this.btnSair.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Aqua;
            this.guna2Button1.Image = global::VS_Web.Properties.Resources.exit_48px;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.ImageSize = new System.Drawing.Size(34, 34);
            this.guna2Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2Button1.Location = new System.Drawing.Point(30, 15);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(94, 30);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Sair";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextFormatNoPrefix = true;
            this.guna2Button1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 507);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.painelNavegacao);
            this.MinimumSize = new System.Drawing.Size(819, 546);
            this.Name = "Form1";
            this.Text = "Form1";
            this.painelNavegacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel painelNavegacao;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2PictureBox pbox;
        private Guna.UI2.WinForms.Guna2CircleButton btnMenu;
        private Guna.UI2.WinForms.Guna2CircleButton btnHome;
        private Guna.UI2.WinForms.Guna2CircleButton btnGoogle;
        private Guna.UI2.WinForms.Guna2CircleButton btnPesquisar;
        private Guna.UI2.WinForms.Guna2CircleButton btnRecarregar;
        private Guna.UI2.WinForms.Guna2CircleButton btnAvancar;
        private Guna.UI2.WinForms.Guna2CircleButton btnVoltar;
        private Guna.UI2.WinForms.Guna2TextBox tboxURL;
        private System.Windows.Forms.Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2CircleButton btnFecharMenu;
        private Guna.UI2.WinForms.Guna2Button btnSair;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;

    }
}

