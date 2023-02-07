namespace MenuStrip
{
    partial class FormularioUsuário
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
            this.BtFechar = new System.Windows.Forms.Button();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtFechar
            // 
            this.BtFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtFechar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BtFechar.FlatAppearance.BorderSize = 5;
            this.BtFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtFechar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtFechar.ForeColor = System.Drawing.Color.White;
            this.BtFechar.Location = new System.Drawing.Point(671, 411);
            this.BtFechar.Name = "BtFechar";
            this.BtFechar.Size = new System.Drawing.Size(110, 56);
            this.BtFechar.TabIndex = 0;
            this.BtFechar.Text = "Fechar";
            this.BtFechar.UseVisualStyleBackColor = false;
            this.BtFechar.Click += new System.EventHandler(this.BtFechar_Click);
            // 
            // DataGV
            // 
            this.DataGV.AllowUserToAddRows = false;
            this.DataGV.AllowUserToDeleteRows = false;
            this.DataGV.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGV.Location = new System.Drawing.Point(0, 0);
            this.DataGV.Name = "DataGV";
            this.DataGV.ReadOnly = true;
            this.DataGV.RowHeadersWidth = 50;
            this.DataGV.RowTemplate.Height = 29;
            this.DataGV.Size = new System.Drawing.Size(886, 570);
            this.DataGV.TabIndex = 1;
            this.DataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGV_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(753, 246);
            this.dataGridView1.TabIndex = 2;
            // 
            // FormularioUsuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(886, 570);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtFechar);
            this.Controls.Add(this.DataGV);
            this.Name = "FormularioUsuário";
            this.Text = "FormularioUsuário";
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtFechar;
        private DataGridView DataGV;
        private DataGridView dataGridView1;
    }
}