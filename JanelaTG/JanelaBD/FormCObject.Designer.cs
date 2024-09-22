namespace JanelaBD
{
    partial class CreateObject
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
            label1 = new Label();
            tbNome = new TextBox();
            ckboxPonto = new CheckBox();
            ckboxReta = new CheckBox();
            lbCreate = new Button();
            closeWind = new Button();
            cord_X = new TextBox();
            label2 = new Label();
            cord_Y = new TextBox();
            label3 = new Label();
            cord_Z = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 31);
            label1.Name = "label1";
            label1.Size = new Size(54, 18);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(73, 31);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(167, 23);
            tbNome.TabIndex = 1;
            tbNome.TextChanged += tbNome_TextChanged;
            // 
            // ckboxPonto
            // 
            ckboxPonto.AutoSize = true;
            ckboxPonto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckboxPonto.Location = new Point(23, 87);
            ckboxPonto.Name = "ckboxPonto";
            ckboxPonto.Size = new Size(80, 29);
            ckboxPonto.TabIndex = 2;
            ckboxPonto.Text = "Ponto";
            ckboxPonto.UseVisualStyleBackColor = true;
            ckboxPonto.CheckedChanged += ckbxPonto_CheckedChanged;
            // 
            // ckboxReta
            // 
            ckboxReta.AutoSize = true;
            ckboxReta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckboxReta.Location = new Point(133, 87);
            ckboxReta.Name = "ckboxReta";
            ckboxReta.Size = new Size(67, 29);
            ckboxReta.TabIndex = 3;
            ckboxReta.Text = "Reta";
            ckboxReta.UseVisualStyleBackColor = true;
            ckboxReta.CheckedChanged += ckbxReta_CheckedChanged;
            // 
            // lbCreate
            // 
            lbCreate.Location = new Point(133, 199);
            lbCreate.Name = "lbCreate";
            lbCreate.Size = new Size(128, 36);
            lbCreate.TabIndex = 4;
            lbCreate.Text = "Create";
            lbCreate.UseVisualStyleBackColor = true;
            lbCreate.Click += btnCreate_Click;
            // 
            // closeWind
            // 
            closeWind.Location = new Point(282, 199);
            closeWind.Name = "closeWind";
            closeWind.Size = new Size(128, 36);
            closeWind.TabIndex = 5;
            closeWind.Text = "Close";
            closeWind.UseVisualStyleBackColor = true;
            closeWind.Click += closeWind_Click;
            // 
            // cord_X
            // 
            cord_X.Location = new Point(379, 31);
            cord_X.Name = "cord_X";
            cord_X.Size = new Size(167, 23);
            cord_X.TabIndex = 7;
            cord_X.TextChanged += cord_X_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(353, 31);
            label2.Name = "label2";
            label2.Size = new Size(23, 18);
            label2.TabIndex = 6;
            label2.Text = "X:";
            // 
            // cord_Y
            // 
            cord_Y.Location = new Point(379, 74);
            cord_Y.Name = "cord_Y";
            cord_Y.Size = new Size(167, 23);
            cord_Y.TabIndex = 9;
            cord_Y.TextChanged += cord_Y_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(353, 74);
            label3.Name = "label3";
            label3.Size = new Size(20, 18);
            label3.TabIndex = 8;
            label3.Text = "Y:";
            // 
            // cord_Z
            // 
            cord_Z.Location = new Point(379, 117);
            cord_Z.Name = "cord_Z";
            cord_Z.Size = new Size(167, 23);
            cord_Z.TabIndex = 11;
            cord_Z.TextChanged += cord_Z_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(353, 117);
            label4.Name = "label4";
            label4.Size = new Size(21, 18);
            label4.TabIndex = 10;
            label4.Text = "Z:";
            // 
            // CreateObject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 247);
            Controls.Add(cord_Z);
            Controls.Add(label4);
            Controls.Add(cord_Y);
            Controls.Add(label3);
            Controls.Add(cord_X);
            Controls.Add(label2);
            Controls.Add(closeWind);
            Controls.Add(lbCreate);
            Controls.Add(ckboxReta);
            Controls.Add(ckboxPonto);
            Controls.Add(tbNome);
            Controls.Add(label1);
            Name = "CreateObject";
            Text = "Criar Objeto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNome;
        private CheckBox ckboxPonto;
        private CheckBox ckboxReta;
        private Button lbCreate;
        private Button closeWind;
        private TextBox cord_X;
        private Label label2;
        private TextBox cord_Y;
        private Label label3;
        private TextBox cord_Z;
        private Label label4;
    }
}