namespace JanelaBD
{
    partial class FormPrin
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
            lbObjetos = new ListBox();
            pbCaixaDesenho = new PictureBox();
            btnRight = new Button();
            btnUp = new Button();
            BtnLeft = new Button();
            btnDown = new Button();
            btnLimpar = new Button();
            btnRemover = new Button();
            btnAdicionar = new Button();
            Nome = new Label();
            boxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            corX = new TextBox();
            corY = new TextBox();
            corZ = new TextBox();
            cbPonto = new CheckBox();
            cbReta = new CheckBox();
            button1 = new Button();
            btnZoomOut = new Button();
            cbPoli = new CheckBox();
            cordenate = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbCaixaDesenho).BeginInit();
            SuspendLayout();
            // 
            // lbObjetos
            // 
            lbObjetos.FormattingEnabled = true;
            lbObjetos.ItemHeight = 15;
            lbObjetos.Location = new Point(722, 4);
            lbObjetos.Name = "lbObjetos";
            lbObjetos.Size = new Size(266, 409);
            lbObjetos.TabIndex = 0;
            lbObjetos.SelectedIndexChanged += lbObjetos_SelectedIndexChanged;
            // 
            // pbCaixaDesenho
            // 
            pbCaixaDesenho.BorderStyle = BorderStyle.FixedSingle;
            pbCaixaDesenho.Location = new Point(208, 4);
            pbCaixaDesenho.Name = "pbCaixaDesenho";
            pbCaixaDesenho.Size = new Size(500, 500);
            pbCaixaDesenho.TabIndex = 1;
            pbCaixaDesenho.TabStop = false;
            pbCaixaDesenho.Click += pictureBox1_Click;
            pbCaixaDesenho.Paint += pbCaixaDesenho_Paint;
            pbCaixaDesenho.MouseDown += drawing_MouseDown;
            pbCaixaDesenho.MouseMove += pbCaixaDesenho_MouseMove;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(128, 419);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(57, 34);
            btnRight.TabIndex = 3;
            btnRight.Text = "Right";
            btnRight.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            btnUp.Location = new Point(74, 379);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(57, 34);
            btnUp.TabIndex = 4;
            btnUp.Text = "Up";
            btnUp.UseVisualStyleBackColor = true;
            // 
            // BtnLeft
            // 
            BtnLeft.Location = new Point(18, 419);
            BtnLeft.Name = "BtnLeft";
            BtnLeft.Size = new Size(57, 34);
            BtnLeft.TabIndex = 5;
            BtnLeft.Text = "Left";
            BtnLeft.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(74, 459);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(57, 34);
            btnDown.TabIndex = 6;
            btnDown.Text = "Down";
            btnDown.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(806, 433);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(96, 60);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar Tudo";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(106, 24);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(80, 34);
            btnRemover.TabIndex = 10;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(12, 24);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(80, 34);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(12, 80);
            Nome.Name = "Nome";
            Nome.Size = new Size(43, 15);
            Nome.TabIndex = 12;
            Nome.Text = "Nome:";
            Nome.Click += label1_Click;
            // 
            // boxName
            // 
            boxName.Location = new Point(61, 77);
            boxName.Name = "boxName";
            boxName.Size = new Size(141, 23);
            boxName.TabIndex = 13;
            boxName.TextChanged += bName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(32, 123);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 14;
            label1.Text = "X";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(32, 155);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 15;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(32, 187);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 16;
            label3.Text = "Z";
            // 
            // corX
            // 
            corX.Location = new Point(61, 128);
            corX.Name = "corX";
            corX.Size = new Size(70, 23);
            corX.TabIndex = 17;
            // 
            // corY
            // 
            corY.Location = new Point(61, 160);
            corY.Name = "corY";
            corY.Size = new Size(70, 23);
            corY.TabIndex = 18;
            // 
            // corZ
            // 
            corZ.Location = new Point(61, 189);
            corZ.Name = "corZ";
            corZ.Size = new Size(70, 23);
            corZ.TabIndex = 19;
            // 
            // cbPonto
            // 
            cbPonto.AutoSize = true;
            cbPonto.Location = new Point(18, 244);
            cbPonto.Name = "cbPonto";
            cbPonto.Size = new Size(58, 19);
            cbPonto.TabIndex = 20;
            cbPonto.Text = "Ponto";
            cbPonto.UseVisualStyleBackColor = true;
            cbPonto.CheckedChanged += cbPonto_CheckedChanged;
            // 
            // cbReta
            // 
            cbReta.AutoSize = true;
            cbReta.Location = new Point(18, 269);
            cbReta.Name = "cbReta";
            cbReta.Size = new Size(49, 19);
            cbReta.TabIndex = 21;
            cbReta.Text = "Reta";
            cbReta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 316);
            button1.Name = "button1";
            button1.Size = new Size(80, 34);
            button1.TabIndex = 22;
            button1.Text = "Zoom In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnZoomIn_Click;
            // 
            // btnZoomOut
            // 
            btnZoomOut.Location = new Point(106, 316);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new Size(80, 34);
            btnZoomOut.TabIndex = 23;
            btnZoomOut.Text = "Zoom Out";
            btnZoomOut.UseVisualStyleBackColor = true;
            btnZoomOut.Click += btnZoomOut_Click;
            // 
            // cbPoli
            // 
            cbPoli.AutoSize = true;
            cbPoli.Location = new Point(95, 244);
            cbPoli.Name = "cbPoli";
            cbPoli.Size = new Size(74, 19);
            cbPoli.TabIndex = 24;
            cbPoli.Text = "Poligono";
            cbPoli.UseVisualStyleBackColor = true;
            cbPoli.CheckedChanged += cbPoli_CheckedChanged;
            // 
            // cordenate
            // 
            cordenate.AutoSize = true;
            cordenate.Location = new Point(722, 419);
            cordenate.Name = "cordenate";
            cordenate.Size = new Size(38, 15);
            cordenate.TabIndex = 25;
            cordenate.Text = "label4";
            cordenate.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(722, 446);
            button2.Name = "button2";
            button2.Size = new Size(57, 34);
            button2.TabIndex = 26;
            button2.Text = "Right";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // FormPrin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 529);
            Controls.Add(button2);
            Controls.Add(cordenate);
            Controls.Add(cbPoli);
            Controls.Add(btnZoomOut);
            Controls.Add(button1);
            Controls.Add(cbReta);
            Controls.Add(cbPonto);
            Controls.Add(corZ);
            Controls.Add(corY);
            Controls.Add(corX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(boxName);
            Controls.Add(Nome);
            Controls.Add(btnAdicionar);
            Controls.Add(btnRemover);
            Controls.Add(btnLimpar);
            Controls.Add(btnDown);
            Controls.Add(BtnLeft);
            Controls.Add(btnUp);
            Controls.Add(btnRight);
            Controls.Add(pbCaixaDesenho);
            Controls.Add(lbObjetos);
            Name = "FormPrin";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbCaixaDesenho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbObjetos;
        private PictureBox pbCaixaDesenho;
        private Button btnRight;
        private Button btnUp;
        private Button BtnLeft;
        private Button btnDown;
        private Button btnLimpar;
        private Button btnRemover;
        private Button btnAdicionar;
        private Label Nome;
        private TextBox boxName;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox corX;
        private TextBox corY;
        private TextBox corZ;
        private CheckBox cbPonto;
        private CheckBox cbReta;
        private Button button1;
        private Button btnZoomOut;
        private CheckBox cbPoli;
        private Label cordenate;
        private Button button2;
    }
}
