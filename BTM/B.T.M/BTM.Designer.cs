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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      this.myStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
      this.AppListPanel = new MetroFramework.Controls.MetroPanel();
      this.myContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
      this.reloadApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.myBackGroundWorker = new System.ComponentModel.BackgroundWorker();
      this.iconLabel = new MetroFramework.Controls.MetroLabel();
      this.processLabel = new MetroFramework.Controls.MetroLabel();
      this.statusLabel = new MetroFramework.Controls.MetroLabel();
      this.allPanel = new System.Windows.Forms.Panel();
      this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
      this.appChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
      ((System.ComponentModel.ISupportInitialize)(this.myStyleManager)).BeginInit();
      this.myContextMenu.SuspendLayout();
      this.allPanel.SuspendLayout();
      this.metroPanel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.appChart)).BeginInit();
      this.panel1.SuspendLayout();
      this.metroPanel1.SuspendLayout();
      this.metroPanel2.SuspendLayout();
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
      this.AppListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.AppListPanel.HorizontalScrollbar = true;
      this.AppListPanel.HorizontalScrollbarBarColor = true;
      this.AppListPanel.HorizontalScrollbarHighlightOnWheel = false;
      this.AppListPanel.HorizontalScrollbarSize = 10;
      this.AppListPanel.Location = new System.Drawing.Point(0, 0);
      this.AppListPanel.Name = "AppListPanel";
      this.AppListPanel.Size = new System.Drawing.Size(314, 330);
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
      this.myContextMenu.Size = new System.Drawing.Size(95, 26);
      // 
      // reloadApplicationsToolStripMenuItem
      // 
      this.reloadApplicationsToolStripMenuItem.Name = "reloadApplicationsToolStripMenuItem";
      this.reloadApplicationsToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
      this.reloadApplicationsToolStripMenuItem.Text = "null";
      // 
      // iconLabel
      // 
      this.iconLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.iconLabel.Location = new System.Drawing.Point(0, 4);
      this.iconLabel.Name = "iconLabel";
      this.iconLabel.Size = new System.Drawing.Size(41, 22);
      this.iconLabel.TabIndex = 1;
      this.iconLabel.Text = "icon";
      this.iconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // processLabel
      // 
      this.processLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.processLabel.Location = new System.Drawing.Point(43, 4);
      this.processLabel.Name = "processLabel";
      this.processLabel.Size = new System.Drawing.Size(213, 22);
      this.processLabel.TabIndex = 2;
      this.processLabel.Text = "Process";
      this.processLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // statusLabel
      // 
      this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.statusLabel.Location = new System.Drawing.Point(258, 4);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(55, 22);
      this.statusLabel.TabIndex = 3;
      this.statusLabel.Text = "status";
      this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // allPanel
      // 
      this.allPanel.Controls.Add(this.metroPanel4);
      this.allPanel.Controls.Add(this.metroPanel3);
      this.allPanel.Controls.Add(this.panel1);
      this.allPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.allPanel.Location = new System.Drawing.Point(20, 60);
      this.allPanel.Name = "allPanel";
      this.allPanel.Size = new System.Drawing.Size(672, 359);
      this.allPanel.TabIndex = 4;
      // 
      // metroPanel4
      // 
      this.metroPanel4.Controls.Add(this.appChart);
      this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.metroPanel4.HorizontalScrollbarBarColor = true;
      this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
      this.metroPanel4.HorizontalScrollbarSize = 10;
      this.metroPanel4.Location = new System.Drawing.Point(324, 0);
      this.metroPanel4.Name = "metroPanel4";
      this.metroPanel4.Size = new System.Drawing.Size(348, 359);
      this.metroPanel4.TabIndex = 6;
      this.metroPanel4.VerticalScrollbarBarColor = true;
      this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
      this.metroPanel4.VerticalScrollbarSize = 10;
      // 
      // appChart
      // 
      this.appChart.BackColor = System.Drawing.Color.Black;
      this.appChart.BorderlineColor = System.Drawing.Color.Black;
      chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      chartArea1.Name = "ChartArea1";
      this.appChart.ChartAreas.Add(chartArea1);
      this.appChart.Dock = System.Windows.Forms.DockStyle.Fill;
      this.appChart.Location = new System.Drawing.Point(0, 0);
      this.appChart.Name = "appChart";
      this.appChart.Size = new System.Drawing.Size(348, 359);
      this.appChart.TabIndex = 0;
      this.appChart.Text = "chart1";
      // 
      // metroPanel3
      // 
      this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Left;
      this.metroPanel3.HorizontalScrollbarBarColor = true;
      this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
      this.metroPanel3.HorizontalScrollbarSize = 10;
      this.metroPanel3.Location = new System.Drawing.Point(314, 0);
      this.metroPanel3.Name = "metroPanel3";
      this.metroPanel3.Size = new System.Drawing.Size(10, 359);
      this.metroPanel3.TabIndex = 1;
      this.metroPanel3.VerticalScrollbarBarColor = true;
      this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
      this.metroPanel3.VerticalScrollbarSize = 10;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.metroPanel1);
      this.panel1.Controls.Add(this.metroPanel2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(314, 359);
      this.panel1.TabIndex = 4;
      // 
      // metroPanel1
      // 
      this.metroPanel1.Controls.Add(this.AppListPanel);
      this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.metroPanel1.HorizontalScrollbarBarColor = true;
      this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
      this.metroPanel1.HorizontalScrollbarSize = 10;
      this.metroPanel1.Location = new System.Drawing.Point(0, 29);
      this.metroPanel1.Name = "metroPanel1";
      this.metroPanel1.Size = new System.Drawing.Size(314, 330);
      this.metroPanel1.TabIndex = 6;
      this.metroPanel1.VerticalScrollbarBarColor = true;
      this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
      this.metroPanel1.VerticalScrollbarSize = 10;
      // 
      // metroPanel2
      // 
      this.metroPanel2.Controls.Add(this.processLabel);
      this.metroPanel2.Controls.Add(this.statusLabel);
      this.metroPanel2.Controls.Add(this.iconLabel);
      this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.metroPanel2.HorizontalScrollbarBarColor = true;
      this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
      this.metroPanel2.HorizontalScrollbarSize = 10;
      this.metroPanel2.Location = new System.Drawing.Point(0, 0);
      this.metroPanel2.Name = "metroPanel2";
      this.metroPanel2.Size = new System.Drawing.Size(314, 29);
      this.metroPanel2.TabIndex = 5;
      this.metroPanel2.VerticalScrollbarBarColor = true;
      this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
      this.metroPanel2.VerticalScrollbarSize = 10;
      // 
      // BTM
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(712, 439);
      this.ContextMenuStrip = this.myContextMenu;
      this.Controls.Add(this.allPanel);
      this.MaximizeBox = false;
      this.MinimumSize = new System.Drawing.Size(700, 300);
      this.Name = "BTM";
      this.Text = "B.T.M.";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BTM_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.myStyleManager)).EndInit();
      this.myContextMenu.ResumeLayout(false);
      this.allPanel.ResumeLayout(false);
      this.metroPanel4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.appChart)).EndInit();
      this.panel1.ResumeLayout(false);
      this.metroPanel1.ResumeLayout(false);
      this.metroPanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private MetroFramework.Components.MetroStyleManager myStyleManager;
    private MetroFramework.Controls.MetroPanel AppListPanel;
    private MetroFramework.Controls.MetroContextMenu myContextMenu;
    private System.Windows.Forms.ToolStripMenuItem reloadApplicationsToolStripMenuItem;
    private System.ComponentModel.BackgroundWorker myBackGroundWorker;
    private MetroFramework.Controls.MetroLabel processLabel;
    private MetroFramework.Controls.MetroLabel iconLabel;
    private MetroFramework.Controls.MetroLabel statusLabel;
    private System.Windows.Forms.Panel allPanel;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataVisualization.Charting.Chart appChart;
    private MetroFramework.Controls.MetroPanel metroPanel1;
    private MetroFramework.Controls.MetroPanel metroPanel2;
    private MetroFramework.Controls.MetroPanel metroPanel4;
    private MetroFramework.Controls.MetroPanel metroPanel3;
  }
}

