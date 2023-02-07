namespace MenuStrip
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.CadsUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SairApp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuConsulta});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 28);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadsUser,
            this.toolStripSeparator1,
            this.SairApp});
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(88, 24);
            this.MenuCadastro.Text = "Cadastros";
            // 
            // CadsUser
            // 
            this.CadsUser.Name = "CadsUser";
            this.CadsUser.Size = new System.Drawing.Size(226, 26);
            this.CadsUser.Text = "Cadastro de Usuário";
            this.CadsUser.Click += new System.EventHandler(this.CadsUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // SairApp
            // 
            this.SairApp.Image = ((System.Drawing.Image)(resources.GetObject("SairApp.Image")));
            this.SairApp.Name = "SairApp";
            this.SairApp.Size = new System.Drawing.Size(226, 26);
            this.SairApp.Text = "Sair";
            this.SairApp.Click += new System.EventHandler(this.SairApp_Click);
            // 
            // MenuConsulta
            // 
            this.MenuConsulta.Name = "MenuConsulta";
            this.MenuConsulta.Size = new System.Drawing.Size(86, 24);
            this.MenuConsulta.Text = "Consultas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "TESTAR DATAGRIDVIEW E MENUSTRIP";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private ToolStripMenuItem MenuCadastro;
        private ToolStripMenuItem CadsUser;
        private ToolStripMenuItem MenuConsulta;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem SairApp;
    }
}