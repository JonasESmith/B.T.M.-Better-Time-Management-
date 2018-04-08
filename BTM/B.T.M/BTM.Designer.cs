namespace B.T.M
{
  partial class BTM
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
      this.myStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
      this.AppListPanel = new MetroFramework.Controls.MetroPanel();
      this.myContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
      this.reloadApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.myBackGroundWorker = new System.ComponentModel.BackgroundWorker();
      this.iconLabel = new MetroFramework.Controls.MetroLabel();
      this.processLabel = new MetroFramework.Controls.MetroLabel();
      this.statusLabel = new MetroFramework.Controls.MetroLabel();
      this.allPanel = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.myStyleManager)).BeginInit();
      this.myContextMenu.SuspendLayout();
      this.allPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // myStyleManager
      // 
      this.myStyleManager.Owner = this;
      this.myStyleManager.Style = MetroFramework.MetroColorStyle.Teal;
      this.myStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
      // 
      // AppListPanel
      // 
      this.AppListPanel.AutoScroll = true;
      this.AppListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.AppListPanel.HorizontalScrollbar = true;
      this.AppListPanel.HorizontalScrollbarBarColor = true;
      this.AppListPanel.HorizontalScrollbarHighlightOnWheel = false;
      this.AppListPanel.HorizontalScrollbarSize = 10;
      this.AppListPanel.Location = new System.Drawing.Point(3, 26);
      this.AppListPanel.Name = "AppListPanel";
      this.AppListPanel.Size = new System.Drawing.Size(305, 271);
      this.AppListPanel.TabIndex = 0;
      this.AppListPanel.VerticalScrollbar = true;
      this.AppListPanel.VerticalScrollbarBarColor = true;
      this.AppListPanel.VerticalScrollbarHighlightOnWheel = false;
      this.AppListPanel.VerticalScrollbarSize = 10;
      // 
      // myContextMenu
      // 
      this.myContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadApplicationsToolStripMenuItem});
      this.myContextMenu.Name = "myContextMenu";
      this.myContextMenu.Size = new System.Drawing.Size(178, 26);
      // 
      // reloadApplicationsToolStripMenuItem
      // 
      this.reloadApplicationsToolStripMenuItem.Name = "reloadApplicationsToolStripMenuItem";
      this.reloadApplicationsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
      this.reloadApplicationsToolStripMenuItem.Text = "Reload applications";
      this.reloadApplicationsToolStripMenuItem.Click += new System.EventHandler(this.reloadApplicationsToolStripMenuItem_Click);
      // 
      // iconLabel
      // 
      this.iconLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.iconLabel.Location = new System.Drawing.Point(3, 3);
      this.iconLabel.Name = "iconLabel";
      this.iconLabel.Size = new System.Drawing.Size(41, 22);
      this.iconLabel.TabIndex = 1;
      this.iconLabel.Text = "icon";
      this.iconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // processLabel
      // 
      this.processLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.processLabel.Location = new System.Drawing.Point(45, 3);
      this.processLabel.Name = "processLabel";
      this.processLabel.Size = new System.Drawing.Size(207, 22);
      this.processLabel.TabIndex = 2;
      this.processLabel.Text = "Process";
      this.processLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // statusLabel
      // 
      this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.statusLabel.Location = new System.Drawing.Point(253, 3);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(55, 22);
      this.statusLabel.TabIndex = 3;
      this.statusLabel.Text = "status";
      this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // allPanel
      // 
      this.allPanel.Controls.Add(this.AppListPanel);
      this.allPanel.Controls.Add(this.statusLabel);
      this.allPanel.Controls.Add(this.iconLabel);
      this.allPanel.Controls.Add(this.processLabel);
      this.allPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.allPanel.Location = new System.Drawing.Point(20, 60);
      this.allPanel.Name = "allPanel";
      this.allPanel.Size = new System.Drawing.Size(316, 305);
      this.allPanel.TabIndex = 4;
      // 
      // BTM
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(356, 385);
      this.ContextMenuStrip = this.myContextMenu;
      this.Controls.Add(this.allPanel);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(360, 390);
      this.MinimumSize = new System.Drawing.Size(350, 385);
      this.Name = "BTM";
      this.Text = "B.T.M.";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BTM_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.myStyleManager)).EndInit();
      this.myContextMenu.ResumeLayout(false);
      this.allPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private MetroFramework.Components.MetroStyleManager myStyleManager;
    private MetroFramework.Controls.MetroPanel AppListPanel;
    private MetroFramework.Controls.MetroScrollBar metroScrollBar1;
    private MetroFramework.Controls.MetroContextMenu myContextMenu;
    private System.Windows.Forms.ToolStripMenuItem reloadApplicationsToolStripMenuItem;
    private System.ComponentModel.BackgroundWorker myBackGroundWorker;
    private MetroFramework.Controls.MetroLabel processLabel;
    private MetroFramework.Controls.MetroLabel iconLabel;
    private MetroFramework.Controls.MetroLabel statusLabel;
    private System.Windows.Forms.Panel allPanel;
  }
}

