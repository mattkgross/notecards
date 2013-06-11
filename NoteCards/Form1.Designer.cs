namespace NoteCards
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ContentCard = new System.Windows.Forms.PictureBox();
            this.Tab1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.CardNumLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CardNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CardTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CardMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CardDeleteCard = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForCardNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ContentCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentCard
            // 
            this.ContentCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentCard.Image = ((System.Drawing.Image)(resources.GetObject("ContentCard.Image")));
            this.ContentCard.InitialImage = ((System.Drawing.Image)(resources.GetObject("ContentCard.InitialImage")));
            this.ContentCard.Location = new System.Drawing.Point(12, 76);
            this.ContentCard.Name = "ContentCard";
            this.ContentCard.Size = new System.Drawing.Size(381, 208);
            this.ContentCard.TabIndex = 0;
            this.ContentCard.TabStop = false;
            this.ContentCard.WaitOnLoad = true;
            this.ContentCard.Click += new System.EventHandler(this.ContentCard_Click);
            // 
            // Tab1
            // 
            this.Tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab1.Image = ((System.Drawing.Image)(resources.GetObject("Tab1.Image")));
            this.Tab1.InitialImage = ((System.Drawing.Image)(resources.GetObject("Tab1.InitialImage")));
            this.Tab1.Location = new System.Drawing.Point(35, 52);
            this.Tab1.Name = "Tab1";
            this.Tab1.Size = new System.Drawing.Size(381, 208);
            this.Tab1.TabIndex = 1;
            this.Tab1.TabStop = false;
            this.Tab1.WaitOnLoad = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 208);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CardNumLabel,
            this.CardNum,
            this.toolStripStatusLabel1,
            this.CardTotal});
            this.statusStrip.Location = new System.Drawing.Point(0, 293);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(478, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // CardNumLabel
            // 
            this.CardNumLabel.Name = "CardNumLabel";
            this.CardNumLabel.Size = new System.Drawing.Size(88, 17);
            this.CardNumLabel.Text = " Card Number: ";
            // 
            // CardNum
            // 
            this.CardNum.Name = "CardNum";
            this.CardNum.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "/";
            // 
            // CardTotal
            // 
            this.CardTotal.Name = "CardTotal";
            this.CardTotal.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu,
            this.ViewMenu,
            this.CardMenu,
            this.SearchMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.FileOpen,
            this.FileSave,
            this.FileSaveAs});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cardFileToolStripMenuItem,
            this.cardToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // cardFileToolStripMenuItem
            // 
            this.cardFileToolStripMenuItem.Name = "cardFileToolStripMenuItem";
            this.cardFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cardFileToolStripMenuItem.Text = "Card File";
            this.cardFileToolStripMenuItem.Click += new System.EventHandler(this.cardFileToolStripMenuItem_Click);
            // 
            // cardToolStripMenuItem
            // 
            this.cardToolStripMenuItem.Name = "cardToolStripMenuItem";
            this.cardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cardToolStripMenuItem.Text = "Card";
            this.cardToolStripMenuItem.Click += new System.EventHandler(this.cardToolStripMenuItem_Click);
            // 
            // FileOpen
            // 
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.FileOpen.Size = new System.Drawing.Size(195, 22);
            this.FileOpen.Text = "Open...";
            // 
            // FileSave
            // 
            this.FileSave.Name = "FileSave";
            this.FileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FileSave.Size = new System.Drawing.Size(195, 22);
            this.FileSave.Text = "Save";
            this.FileSave.Click += new System.EventHandler(this.FileSave_Click);
            // 
            // FileSaveAs
            // 
            this.FileSaveAs.Name = "FileSaveAs";
            this.FileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.FileSaveAs.Size = new System.Drawing.Size(195, 22);
            this.FileSaveAs.Text = "Save As...";
            // 
            // EditMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditCopy,
            this.EditCut,
            this.EditPaste});
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(39, 20);
            this.EditMenu.Text = "Edit";
            // 
            // EditCopy
            // 
            this.EditCopy.Name = "EditCopy";
            this.EditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.EditCopy.Size = new System.Drawing.Size(144, 22);
            this.EditCopy.Text = "Copy";
            // 
            // EditCut
            // 
            this.EditCut.Name = "EditCut";
            this.EditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.EditCut.Size = new System.Drawing.Size(144, 22);
            this.EditCut.Text = "Cut";
            // 
            // EditPaste
            // 
            this.EditPaste.Name = "EditPaste";
            this.EditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.EditPaste.Size = new System.Drawing.Size(144, 22);
            this.EditPaste.Text = "Paste";
            // 
            // ViewMenu
            // 
            this.ViewMenu.Name = "ViewMenu";
            this.ViewMenu.Size = new System.Drawing.Size(44, 20);
            this.ViewMenu.Text = "View";
            // 
            // CardMenu
            // 
            this.CardMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CardDeleteCard});
            this.CardMenu.Name = "CardMenu";
            this.CardMenu.Size = new System.Drawing.Size(44, 20);
            this.CardMenu.Text = "Card";
            // 
            // CardDeleteCard
            // 
            this.CardDeleteCard.Name = "CardDeleteCard";
            this.CardDeleteCard.Size = new System.Drawing.Size(178, 22);
            this.CardDeleteCard.Text = "Delete Current Card";
            // 
            // SearchMenu
            // 
            this.SearchMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.findReplaceToolStripMenuItem,
            this.searchForCardNumberToolStripMenuItem});
            this.SearchMenu.Name = "SearchMenu";
            this.SearchMenu.Size = new System.Drawing.Size(54, 20);
            this.SearchMenu.Text = "Search";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.findToolStripMenuItem.Text = "Find...";
            // 
            // findReplaceToolStripMenuItem
            // 
            this.findReplaceToolStripMenuItem.Name = "findReplaceToolStripMenuItem";
            this.findReplaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.findReplaceToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.findReplaceToolStripMenuItem.Text = "Find and Replace...";
            // 
            // searchForCardNumberToolStripMenuItem
            // 
            this.searchForCardNumberToolStripMenuItem.Name = "searchForCardNumberToolStripMenuItem";
            this.searchForCardNumberToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.searchForCardNumberToolStripMenuItem.Text = "Search for Card Number";
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpMenu.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 184);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 315);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ContentCard);
            this.Controls.Add(this.Tab1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Note Cards";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContentCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ContentCard;
        private System.Windows.Forms.PictureBox Tab1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem FileOpen;
        private System.Windows.Forms.ToolStripMenuItem FileSave;
        private System.Windows.Forms.ToolStripMenuItem FileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewMenu;
        private System.Windows.Forms.ToolStripMenuItem CardMenu;
        private System.Windows.Forms.ToolStripMenuItem SearchMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditCopy;
        private System.Windows.Forms.ToolStripMenuItem EditCut;
        private System.Windows.Forms.ToolStripMenuItem EditPaste;
        private System.Windows.Forms.ToolStripMenuItem CardDeleteCard;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForCardNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel CardNumLabel;
        private System.Windows.Forms.ToolStripStatusLabel CardNum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel CardTotal;
        private System.Windows.Forms.TextBox textBox1;
    }
}

