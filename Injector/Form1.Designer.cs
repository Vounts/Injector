
namespace Injector
{
    partial class Form1
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
            this.ProcessList = new System.Windows.Forms.ListView();
            this.btnInject = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtTargetPID = new System.Windows.Forms.TextBox();
            this.txtTargetName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessList
            // 
            this.ProcessList.HideSelection = false;
            this.ProcessList.Location = new System.Drawing.Point(10, 27);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(382, 176);
            this.ProcessList.TabIndex = 0;
            this.ProcessList.UseCompatibleStateImageBehavior = false;
            this.ProcessList.SelectedIndexChanged += new System.EventHandler(this.ProcessList_SelectedIndexChanged);
            // 
            // btnInject
            // 
            this.btnInject.Location = new System.Drawing.Point(10, 263);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(75, 23);
            this.btnInject.TabIndex = 1;
            this.btnInject.Text = "Inject";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 211);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(380, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtTargetPID
            // 
            this.txtTargetPID.Location = new System.Drawing.Point(91, 263);
            this.txtTargetPID.Name = "txtTargetPID";
            this.txtTargetPID.ReadOnly = true;
            this.txtTargetPID.Size = new System.Drawing.Size(111, 20);
            this.txtTargetPID.TabIndex = 4;
            // 
            // txtTargetName
            // 
            this.txtTargetName.Location = new System.Drawing.Point(208, 263);
            this.txtTargetName.Name = "txtTargetName";
            this.txtTargetName.ReadOnly = true;
            this.txtTargetName.Size = new System.Drawing.Size(184, 20);
            this.txtTargetName.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitToolStripMenuItem,
            this.bitToolStripMenuItem1});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.optionToolStripMenuItem.Text = "Filter";
            // 
            // bitToolStripMenuItem
            // 
            this.bitToolStripMenuItem.Name = "bitToolStripMenuItem";
            this.bitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bitToolStripMenuItem.Text = "32-Bit";
            this.bitToolStripMenuItem.Click += new System.EventHandler(this.bitToolStripMenuItem_Click);
            // 
            // bitToolStripMenuItem1
            // 
            this.bitToolStripMenuItem1.Name = "bitToolStripMenuItem1";
            this.bitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bitToolStripMenuItem1.Text = "64-Bit";
            this.bitToolStripMenuItem1.Click += new System.EventHandler(this.bitToolStripMenuItem1_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(91, 237);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(301, 20);
            this.txtFile.TabIndex = 7;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(10, 237);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 295);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtTargetName);
            this.Controls.Add(this.txtTargetPID);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnInject);
            this.Controls.Add(this.ProcessList);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "svchost";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ProcessList;
        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtTargetPID;
        private System.Windows.Forms.TextBox txtTargetName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnOpen;
    }
}

