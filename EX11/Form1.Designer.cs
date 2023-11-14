namespace EX11
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
            menuStrip1 = new MenuStrip();
            formatarToolStripMenuItem = new ToolStripMenuItem();
            corDeTipoELetraToolStripMenuItem = new ToolStripMenuItem();
            corToolStripMenuItem = new ToolStripMenuItem();
            tipoDeLetraToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { formatarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(542, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // formatarToolStripMenuItem
            // 
            formatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { corDeTipoELetraToolStripMenuItem });
            formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            formatarToolStripMenuItem.Size = new Size(67, 20);
            formatarToolStripMenuItem.Text = "Formatar";
            // 
            // corDeTipoELetraToolStripMenuItem
            // 
            corDeTipoELetraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { corToolStripMenuItem, tipoDeLetraToolStripMenuItem });
            corDeTipoELetraToolStripMenuItem.Name = "corDeTipoELetraToolStripMenuItem";
            corDeTipoELetraToolStripMenuItem.Size = new Size(180, 22);
            corDeTipoELetraToolStripMenuItem.Text = "Cor e tipo e letra";
            // 
            // corToolStripMenuItem
            // 
            corToolStripMenuItem.Name = "corToolStripMenuItem";
            corToolStripMenuItem.Size = new Size(180, 22);
            corToolStripMenuItem.Text = "Cor";
            corToolStripMenuItem.Click += corToolStripMenuItem_Click;
            // 
            // tipoDeLetraToolStripMenuItem
            // 
            tipoDeLetraToolStripMenuItem.Name = "tipoDeLetraToolStripMenuItem";
            tipoDeLetraToolStripMenuItem.Size = new Size(180, 22);
            tipoDeLetraToolStripMenuItem.Text = "Tipo de letra";
            tipoDeLetraToolStripMenuItem.Click += tipoDeLetraToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 207);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "POO em C#";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 327);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem corDeTipoELetraToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem corToolStripMenuItem;
        private ToolStripMenuItem tipoDeLetraToolStripMenuItem;
    }
}