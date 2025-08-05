namespace PRJ_MEDIA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnMedia = new System.Windows.Forms.Button();
            this.lbResposta = new System.Windows.Forms.Label();
            this.btnGeometrica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o numero A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtA
            // 
            this.txtA.AcceptsTab = true;
            this.txtA.AllowDrop = true;
            this.txtA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtA.Location = new System.Drawing.Point(26, 51);
            this.txtA.MaxLength = 12;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(475, 26);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "0";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(22, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o numero B";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtB
            // 
            this.txtB.AcceptsTab = true;
            this.txtB.AllowDrop = true;
            this.txtB.Location = new System.Drawing.Point(25, 125);
            this.txtB.MaxLength = 12;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(475, 26);
            this.txtB.TabIndex = 2;
            this.txtB.Text = "0";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMedia.Image = ((System.Drawing.Image)(resources.GetObject("btnMedia.Image")));
            this.btnMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMedia.Location = new System.Drawing.Point(25, 201);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(474, 63);
            this.btnMedia.TabIndex = 3;
            this.btnMedia.Text = "Calcular Média Aritmetica";
            this.btnMedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // lbResposta
            // 
            this.lbResposta.BackColor = System.Drawing.Color.White;
            this.lbResposta.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResposta.Location = new System.Drawing.Point(18, 458);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(478, 60);
            this.lbResposta.TabIndex = 4;
            this.lbResposta.Text = "0";
            this.lbResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbResposta.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnGeometrica
            // 
            this.btnGeometrica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGeometrica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeometrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeometrica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGeometrica.Image = ((System.Drawing.Image)(resources.GetObject("btnGeometrica.Image")));
            this.btnGeometrica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeometrica.Location = new System.Drawing.Point(25, 287);
            this.btnGeometrica.Name = "btnGeometrica";
            this.btnGeometrica.Size = new System.Drawing.Size(474, 63);
            this.btnGeometrica.TabIndex = 3;
            this.btnGeometrica.Text = "Calcular Média Geométrica";
            this.btnGeometrica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeometrica.UseVisualStyleBackColor = false;
            this.btnGeometrica.Click += new System.EventHandler(this.btnGeometrica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(533, 612);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.btnGeometrica);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Média";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.Button btnGeometrica;
    }
}

