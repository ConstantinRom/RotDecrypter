namespace RotDecrypter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CryptButton = new System.Windows.Forms.Button();
            this.numbersBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outputTextBox2 = new System.Windows.Forms.RichTextBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.openmenuitem = new System.Windows.Forms.MenuItem();
            this.savemenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.exitmenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.aendernmenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.editablebemenuitem = new System.Windows.Forms.MenuItem();
            this.aboutmenuitem = new System.Windows.Forms.MenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CryptButton
            // 
            this.CryptButton.Location = new System.Drawing.Point(179, 3);
            this.CryptButton.Name = "CryptButton";
            this.CryptButton.Size = new System.Drawing.Size(93, 23);
            this.CryptButton.TabIndex = 2;
            this.CryptButton.Text = "Decrypt/Encrypt";
            this.CryptButton.UseVisualStyleBackColor = true;
            this.CryptButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // numbersBox1
            // 
            this.numbersBox1.FormattingEnabled = true;
            this.numbersBox1.Location = new System.Drawing.Point(3, 3);
            this.numbersBox1.Name = "numbersBox1";
            this.numbersBox1.Size = new System.Drawing.Size(170, 21);
            this.numbersBox1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.numbersBox1);
            this.panel1.Controls.Add(this.CryptButton);
            this.panel1.Location = new System.Drawing.Point(0, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 32);
            this.panel1.TabIndex = 5;
            // 
            // outputTextBox2
            // 
            this.outputTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox2.Location = new System.Drawing.Point(0, 186);
            this.outputTextBox2.Name = "outputTextBox2";
            this.outputTextBox2.Size = new System.Drawing.Size(538, 168);
            this.outputTextBox2.TabIndex = 6;
            this.outputTextBox2.Text = "";
            this.outputTextBox2.TextChanged += new System.EventHandler(this.outputTextBox2_TextChanged);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.aboutmenuitem});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.openmenuitem,
            this.savemenuItem,
            this.menuItem8,
            this.exitmenuItem});
            this.menuItem1.Text = "File";
            // 
            // openmenuitem
            // 
            this.openmenuitem.Index = 0;
            this.openmenuitem.Text = "Open";
            this.openmenuitem.Click += new System.EventHandler(this.openmenuitem_Click);
            // 
            // savemenuItem
            // 
            this.savemenuItem.Index = 1;
            this.savemenuItem.Text = "Save";
            this.savemenuItem.Click += new System.EventHandler(this.savemenuItem_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.menuItem8.Text = "-";
            // 
            // exitmenuItem
            // 
            this.exitmenuItem.Index = 3;
            this.exitmenuItem.Text = "Exit";
            this.exitmenuItem.Click += new System.EventHandler(this.exitmenuItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.editablebemenuitem});
            this.menuItem2.Text = "Settings";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.aendernmenuItem,
            this.menuItem6});
            this.menuItem3.Text = "Font";
            // 
            // aendernmenuItem
            // 
            this.aendernmenuItem.Index = 0;
            this.aendernmenuItem.Text = "Change";
            this.aendernmenuItem.Click += new System.EventHandler(this.aendernmenuItem_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "Reset";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // editablebemenuitem
            // 
            this.editablebemenuitem.Checked = true;
            this.editablebemenuitem.Index = 1;
            this.editablebemenuitem.Text = "Edit";
            this.editablebemenuitem.Click += new System.EventHandler(this.editablebemenuitem_Click);
            // 
            // aboutmenuitem
            // 
            this.aboutmenuitem.Index = 2;
            this.aboutmenuitem.Text = "About";
            this.aboutmenuitem.Click += new System.EventHandler(this.aboutmenuitem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.Color.Purple;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.Location = new System.Drawing.Point(0, 0);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(538, 168);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 387);
            this.Controls.Add(this.outputTextBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(553, 423);
            this.Name = "Form1";
            this.Text = "Rot Decrypter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CryptButton;
        private System.Windows.Forms.ComboBox numbersBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox outputTextBox2;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem openmenuitem;
        private System.Windows.Forms.MenuItem exitmenuItem;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem aboutmenuitem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem aendernmenuItem;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem savemenuItem;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.MenuItem editablebemenuitem;
    }


}

