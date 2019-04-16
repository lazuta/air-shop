namespace Lazuta
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.Menu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Button_Contact = new System.Windows.Forms.Button();
            this.Button_add = new System.Windows.Forms.Button();
            this.Button_catalog = new System.Windows.Forms.Button();
            this.BHome = new System.Windows.Forms.Button();
            this.title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toppanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.svipe = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.park1 = new Lazuta.park();
            this.section_home1 = new Lazuta.home();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TransitionSideBar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu.BackgroundImage")));
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu.Controls.Add(this.SidePanel);
            this.Menu.Controls.Add(this.Button_Contact);
            this.Menu.Controls.Add(this.Button_add);
            this.Menu.Controls.Add(this.Button_catalog);
            this.Menu.Controls.Add(this.BHome);
            this.Menu.Controls.Add(this.title);
            this.Menu.Controls.Add(this.logo);
            this.Menu.Controls.Add(this.panel1);
            this.Menu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TransitionSideBar.SetDecoration(this.Menu, BunifuAnimatorNS.DecorationType.None);
            this.Menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Menu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(172)))));
            this.Menu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.Menu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(100)))));
            this.Menu.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Quality = 256;
            this.Menu.Size = new System.Drawing.Size(260, 540);
            this.Menu.TabIndex = 1;
            // 
            // SidePanel
            // 
            this.SidePanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.TransitionSideBar.SetDecoration(this.SidePanel, BunifuAnimatorNS.DecorationType.None);
            this.SidePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 150);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SidePanel.Size = new System.Drawing.Size(12, 58);
            this.SidePanel.TabIndex = 8;
            // 
            // Button_Contact
            // 
            this.Button_Contact.BackColor = System.Drawing.Color.Transparent;
            this.Button_Contact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionSideBar.SetDecoration(this.Button_Contact, BunifuAnimatorNS.DecorationType.None);
            this.Button_Contact.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Button_Contact.FlatAppearance.BorderSize = 0;
            this.Button_Contact.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Button_Contact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Contact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(201)))));
            this.Button_Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Contact.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Contact.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Contact.Image = ((System.Drawing.Image)(resources.GetObject("Button_Contact.Image")));
            this.Button_Contact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Contact.Location = new System.Drawing.Point(12, 327);
            this.Button_Contact.Name = "Button_Contact";
            this.Button_Contact.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_Contact.Size = new System.Drawing.Size(247, 58);
            this.Button_Contact.TabIndex = 7;
            this.Button_Contact.Text = "   Контакты";
            this.Button_Contact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Contact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Contact.UseVisualStyleBackColor = false;
            this.Button_Contact.Click += new System.EventHandler(this.Button_Contact_Click);
            // 
            // Button_add
            // 
            this.Button_add.BackColor = System.Drawing.Color.Transparent;
            this.Button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionSideBar.SetDecoration(this.Button_add, BunifuAnimatorNS.DecorationType.None);
            this.Button_add.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Button_add.FlatAppearance.BorderSize = 0;
            this.Button_add.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(201)))));
            this.Button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_add.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_add.Image = ((System.Drawing.Image)(resources.GetObject("Button_add.Image")));
            this.Button_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_add.Location = new System.Drawing.Point(12, 268);
            this.Button_add.Name = "Button_add";
            this.Button_add.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_add.Size = new System.Drawing.Size(247, 58);
            this.Button_add.TabIndex = 6;
            this.Button_add.Text = "   Заказ";
            this.Button_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_add.UseVisualStyleBackColor = false;
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // Button_catalog
            // 
            this.Button_catalog.BackColor = System.Drawing.Color.Transparent;
            this.Button_catalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionSideBar.SetDecoration(this.Button_catalog, BunifuAnimatorNS.DecorationType.None);
            this.Button_catalog.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Button_catalog.FlatAppearance.BorderSize = 0;
            this.Button_catalog.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Button_catalog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_catalog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(201)))));
            this.Button_catalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_catalog.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_catalog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_catalog.Image = ((System.Drawing.Image)(resources.GetObject("Button_catalog.Image")));
            this.Button_catalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_catalog.Location = new System.Drawing.Point(12, 209);
            this.Button_catalog.Name = "Button_catalog";
            this.Button_catalog.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_catalog.Size = new System.Drawing.Size(247, 58);
            this.Button_catalog.TabIndex = 5;
            this.Button_catalog.Text = "   Парк";
            this.Button_catalog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_catalog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_catalog.UseVisualStyleBackColor = false;
            this.Button_catalog.Click += new System.EventHandler(this.Button_catalog_Click);
            // 
            // BHome
            // 
            this.BHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BHome.BackColor = System.Drawing.Color.Transparent;
            this.BHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionSideBar.SetDecoration(this.BHome, BunifuAnimatorNS.DecorationType.None);
            this.BHome.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.BHome.FlatAppearance.BorderSize = 0;
            this.BHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(201)))));
            this.BHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BHome.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BHome.ForeColor = System.Drawing.SystemColors.Menu;
            this.BHome.Image = ((System.Drawing.Image)(resources.GetObject("BHome.Image")));
            this.BHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BHome.Location = new System.Drawing.Point(12, 150);
            this.BHome.Name = "BHome";
            this.BHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BHome.Size = new System.Drawing.Size(247, 58);
            this.BHome.TabIndex = 3;
            this.BHome.Text = "   Главная";
            this.BHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BHome.UseVisualStyleBackColor = false;
            this.BHome.Click += new System.EventHandler(this.BHome_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.TransitionSideBar.SetDecoration(this.title, BunifuAnimatorNS.DecorationType.None);
            this.title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.title.Location = new System.Drawing.Point(45, 65);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(171, 13);
            this.title.TabIndex = 4;
            this.title.Text = "ОФИЦИАЛЬНЫЙ ДИЛЕР AIRBUS";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.TransitionSideBar.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(48, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(168, 50);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // panel1
            // 
            this.TransitionSideBar.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(259, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 513);
            this.panel1.TabIndex = 2;
            // 
            // toppanel
            // 
            this.toppanel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.toppanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toppanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toppanel.BackgroundImage")));
            this.toppanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toppanel.Controls.Add(this.svipe);
            this.toppanel.Controls.Add(this.bunifuImageButton1);
            this.toppanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TransitionSideBar.SetDecoration(this.toppanel, BunifuAnimatorNS.DecorationType.None);
            this.toppanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toppanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.toppanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.toppanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.toppanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.toppanel.Location = new System.Drawing.Point(260, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Quality = 1;
            this.toppanel.Size = new System.Drawing.Size(704, 25);
            this.toppanel.TabIndex = 2;
            // 
            // svipe
            // 
            this.svipe.BackColor = System.Drawing.Color.Transparent;
            this.svipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionSideBar.SetDecoration(this.svipe, BunifuAnimatorNS.DecorationType.None);
            this.svipe.Image = ((System.Drawing.Image)(resources.GetObject("svipe.Image")));
            this.svipe.ImageActive = ((System.Drawing.Image)(resources.GetObject("svipe.ImageActive")));
            this.svipe.Location = new System.Drawing.Point(650, 3);
            this.svipe.Name = "svipe";
            this.svipe.Size = new System.Drawing.Size(19, 19);
            this.svipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.svipe.TabIndex = 4;
            this.svipe.TabStop = false;
            this.svipe.WaitOnLoad = true;
            this.svipe.Zoom = 6;
            this.svipe.Click += new System.EventHandler(this.svipe_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionSideBar.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ImageActive")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(675, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.WaitOnLoad = true;
            this.bunifuImageButton1.Zoom = 6;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // park1
            // 
            this.TransitionSideBar.SetDecoration(this.park1, BunifuAnimatorNS.DecorationType.None);
            this.park1.Location = new System.Drawing.Point(259, 27);
            this.park1.Name = "park1";
            this.park1.Size = new System.Drawing.Size(715, 524);
            this.park1.TabIndex = 3;
            // 
            // section_home1
            // 
            this.TransitionSideBar.SetDecoration(this.section_home1, BunifuAnimatorNS.DecorationType.None);
            this.section_home1.Location = new System.Drawing.Point(259, 24);
            this.section_home1.Name = "section_home1";
            this.section_home1.Size = new System.Drawing.Size(701, 513);
            this.section_home1.TabIndex = 4;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TransitionSideBar
            // 
            this.TransitionSideBar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.TransitionSideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.TransitionSideBar.DefaultAnimation = animation1;
            this.TransitionSideBar.Interval = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.section_home1);
            this.Controls.Add(this.park1);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.Menu);
            this.TransitionSideBar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.toppanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel Menu;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button Button_Contact;
        private System.Windows.Forms.Button Button_add;
        private System.Windows.Forms.Button Button_catalog;
        private System.Windows.Forms.Button BHome;
        private Bunifu.Framework.UI.BunifuCustomLabel title;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel toppanel;
        private Bunifu.Framework.UI.BunifuImageButton svipe;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private park park1;
        private home section_home1;
        internal BunifuAnimatorNS.BunifuTransition TransitionSideBar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}