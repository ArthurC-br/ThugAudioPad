namespace ThugAudioPad
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CB_list_devices = new System.Windows.Forms.ComboBox();
            this.listView_mp3Files = new System.Windows.Forms.ListView();
            this.mp3_files = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comandos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_list_devices
            // 
            this.CB_list_devices.FormattingEnabled = true;
            this.CB_list_devices.Location = new System.Drawing.Point(572, 12);
            this.CB_list_devices.Name = "CB_list_devices";
            this.CB_list_devices.Size = new System.Drawing.Size(216, 21);
            this.CB_list_devices.TabIndex = 2;
            // 
            // listView_mp3Files
            // 
            this.listView_mp3Files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mp3_files,
            this.comandos});
            this.listView_mp3Files.HideSelection = false;
            this.listView_mp3Files.Location = new System.Drawing.Point(12, 32);
            this.listView_mp3Files.Name = "listView_mp3Files";
            this.listView_mp3Files.Size = new System.Drawing.Size(554, 228);
            this.listView_mp3Files.TabIndex = 4;
            this.listView_mp3Files.UseCompatibleStateImageBehavior = false;
            this.listView_mp3Files.View = System.Windows.Forms.View.List;
            // 
            // mp3_files
            // 
            this.mp3_files.Width = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecione seu audio:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThugAudioPad.Properties.Resources.toppng_com_thug_life_text_logo_big_1500x1500;
            this.pictureBox1.Location = new System.Drawing.Point(572, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 272);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_mp3Files);
            this.Controls.Add(this.CB_list_devices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CB_list_devices;
        private System.Windows.Forms.ListView listView_mp3Files;
        private System.Windows.Forms.ColumnHeader mp3_files;
        private System.Windows.Forms.ColumnHeader comandos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

