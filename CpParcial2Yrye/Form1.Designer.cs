namespace CpParcial2Yrye
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
            panelMenu = new Panel();
            button3 = new Button();
            button2 = new Button();
            Ver = new Button();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 64, 64);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(Ver);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 579);
            panelMenu.TabIndex = 0;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Window;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 381);
            button3.Name = "button3";
            button3.Size = new Size(200, 117);
            button3.TabIndex = 3;
            button3.Text = " Actualizar";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Window;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 243);
            button2.Name = "button2";
            button2.Size = new Size(200, 138);
            button2.TabIndex = 2;
            button2.Text = " Crear";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // Ver
            // 
            Ver.Dock = DockStyle.Top;
            Ver.FlatStyle = FlatStyle.Flat;
            Ver.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Ver.ForeColor = SystemColors.Window;
            Ver.Image = (Image)resources.GetObject("Ver.Image");
            Ver.ImageAlign = ContentAlignment.MiddleLeft;
            Ver.Location = new Point(0, 121);
            Ver.Name = "Ver";
            Ver.Size = new Size(200, 122);
            Ver.TabIndex = 1;
            Ver.Text = "  Ver";
            Ver.TextAlign = ContentAlignment.MiddleLeft;
            Ver.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ver.UseVisualStyleBackColor = true;
            Ver.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 121);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(43, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(126, 117);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(725, 121);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(285, 35);
            label2.Name = "label2";
            label2.Size = new Size(306, 47);
            label2.TabIndex = 4;
            label2.Text = "BIENVENIDO(A)";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(562, 157);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(351, 422);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(265, 234);
            label3.Name = "label3";
            label3.Size = new Size(362, 230);
            label3.TabIndex = 6;
            label3.Text = resources.GetString("label3.Text");
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(925, 579);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelMenu;
        private Panel panel1;
        private Button Ver;
        private Button button3;
        private Button button2;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label2;
    }
}