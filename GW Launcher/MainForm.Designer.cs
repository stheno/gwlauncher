namespace GW_Launcher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listViewAccounts = new System.Windows.Forms.ListView();
            this.columnIcon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAlias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripAccounts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.launchGWInstanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxDebug = new System.Windows.Forms.CheckBox();
            this.debugModeOutput = new System.Windows.Forms.TextBox();
            this.contextMenuStripAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewAccounts
            // 
            this.listViewAccounts.BackColor = System.Drawing.SystemColors.Window;
            this.listViewAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIcon,
            this.columnAlias,
            this.columnName,
            this.columnStatus});
            this.listViewAccounts.ContextMenuStrip = this.contextMenuStripAccounts;
            this.listViewAccounts.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewAccounts.FullRowSelect = true;
            this.listViewAccounts.Location = new System.Drawing.Point(0, 0);
            this.listViewAccounts.Name = "listViewAccounts";
            this.listViewAccounts.Size = new System.Drawing.Size(304, 245);
            this.listViewAccounts.TabIndex = 0;
            this.listViewAccounts.UseCompatibleStateImageBehavior = false;
            this.listViewAccounts.View = System.Windows.Forms.View.Details;
            this.listViewAccounts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewAccounts_MouseDoubleClick);
            // 
            // columnIcon
            // 
            this.columnIcon.Text = "";
            this.columnIcon.Width = 20;
            // 
            // columnAlias
            // 
            this.columnAlias.Text = "Alias";
            this.columnAlias.Width = 100;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 120;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            // 
            // contextMenuStripAccounts
            // 
            this.contextMenuStripAccounts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshAccountsToolStripMenuItem,
            this.toolStripSeparator2,
            this.addNewToolStripMenuItem,
            this.editSelectedToolStripMenuItem,
            this.removeSelectedToolStripMenuItem,
            this.toolStripSeparator1,
            this.launchGWInstanceToolStripMenuItem});
            this.contextMenuStripAccounts.Name = "contextMenuStripAccounts";
            this.contextMenuStripAccounts.Size = new System.Drawing.Size(197, 126);
            this.contextMenuStripAccounts.Text = "Options.";
            // 
            // refreshAccountsToolStripMenuItem
            // 
            this.refreshAccountsToolStripMenuItem.Name = "refreshAccountsToolStripMenuItem";
            this.refreshAccountsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.refreshAccountsToolStripMenuItem.Text = "Refresh Accounts";
            this.refreshAccountsToolStripMenuItem.Click += new System.EventHandler(this.refreshAccountsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // editSelectedToolStripMenuItem
            // 
            this.editSelectedToolStripMenuItem.Name = "editSelectedToolStripMenuItem";
            this.editSelectedToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.editSelectedToolStripMenuItem.Text = "Edit Selected";
            this.editSelectedToolStripMenuItem.Click += new System.EventHandler(this.editSelectedToolStripMenuItem_Click);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove Selected";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // launchGWInstanceToolStripMenuItem
            // 
            this.launchGWInstanceToolStripMenuItem.Name = "launchGWInstanceToolStripMenuItem";
            this.launchGWInstanceToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.launchGWInstanceToolStripMenuItem.Text = "Launch Default GW Client";
            this.launchGWInstanceToolStripMenuItem.Click += new System.EventHandler(this.launchGWInstanceToolStripMenuItem_Click);
            // 
            // checkBoxDebug
            // 
            this.checkBoxDebug.AutoSize = true;
            this.checkBoxDebug.Location = new System.Drawing.Point(5, 3);
            this.checkBoxDebug.Name = "checkBoxDebug";
            this.checkBoxDebug.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDebug.TabIndex = 104;
            this.checkBoxDebug.UseVisualStyleBackColor = true;
            this.checkBoxDebug.CheckedChanged += new System.EventHandler(this.checkBoxDebug_CheckedChanged);
            // 
            // debugModeOutput
            // 
            this.debugModeOutput.BackColor = System.Drawing.Color.Black;
            this.debugModeOutput.ForeColor = System.Drawing.Color.Red;
            this.debugModeOutput.Location = new System.Drawing.Point(310, 0);
            this.debugModeOutput.Multiline = true;
            this.debugModeOutput.Name = "debugModeOutput";
            this.debugModeOutput.ReadOnly = true;
            this.debugModeOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.debugModeOutput.Size = new System.Drawing.Size(304, 245);
            this.debugModeOutput.TabIndex = 105;
            this.debugModeOutput.Text = "test";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 245);
            this.Controls.Add(this.debugModeOutput);
            this.Controls.Add(this.checkBoxDebug);
            this.Controls.Add(this.listViewAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GW Launcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStripAccounts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAccounts;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAccounts;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchGWInstanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ColumnHeader columnAlias;
        private System.Windows.Forms.ColumnHeader columnIcon;
        private System.Windows.Forms.CheckBox checkBoxDebug;
        private System.Windows.Forms.TextBox debugModeOutput;
    }
}

