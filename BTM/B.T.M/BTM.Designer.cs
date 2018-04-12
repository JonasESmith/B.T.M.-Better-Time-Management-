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
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.myStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
      this.AppListPanel = new MetroFramework.Controls.MetroPanel();
      this.myContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
      this.reloadApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.myBackGroundWorker = new System.ComponentModel.BackgroundWorker();
      this.iconLabel = new MetroFramework.Controls.MetroLabel();
      this.processLabel = new MetroFramework.Controls.MetroLabel();
      this.statusLabel = new MetroFramework.Controls.MetroLabel();
      this.allPanel = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.appChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.panel1 = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.myStyleManager)).BeginInit();
      this.myContextMenu.SuspendLayout();
      this.allPanel.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.appChart)).BeginInit();
      this.panel1.SuspendLayout();
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
      this.AppListPanel.Location = new System.Drawing.Point(5, 30);
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
      // 
      // iconLabel
      // 
      this.iconLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.iconLabel.Location = new System.Drawing.Point(5, 7);
      this.iconLabel.Name = "iconLabel";
      this.iconLabel.Size = new System.Drawing.Size(41, 22);
      this.iconLabel.TabIndex = 1;
      this.iconLabel.Text = "icon";
      this.iconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // processLabel
      // 
      this.processLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.processLabel.Location = new System.Drawing.Point(47, 7);
      this.processLabel.Name = "processLabel";
      this.processLabel.Size = new System.Drawing.Size(207, 22);
      this.processLabel.TabIndex = 2;
      this.processLabel.Text = "Process";
      this.processLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // statusLabel
      // 
      this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.statusLabel.Location = new System.Drawing.Point(255, 7);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(55, 22);
      this.statusLabel.TabIndex = 3;
      this.statusLabel.Text = "status";
      this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // allPanel
      // 
      this.allPanel.Controls.Add(this.panel2);
      this.allPanel.Controls.Add(this.panel1);
      this.allPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.allPanel.Location = new System.Drawing.Point(20, 60);
      this.allPanel.Name = "allPanel";
      this.allPanel.Size = new System.Drawing.Size(708, 305);
      this.allPanel.TabIndex = 4;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.appChart);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(317, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(391, 305);
      this.panel2.TabIndex = 5;
      // 
      // appChart
      // 
      this.appChart.BackColor = System.Drawing.Color.DimGray;
      chartArea1.Name = "ChartArea1";
      this.appChart.ChartAreas.Add(chartArea1);
      this.appChart.Dock = System.Windows.Forms.DockStyle.Fill;
      legend1.Name = "appLegend";
      legend1.TitleBackColor = System.Drawing.SystemColors.AppWorkspace;
      this.appChart.Legends.Add(legend1);
      this.appChart.Location = new System.Drawing.Point(0, 0);
      this.appChart.Name = "appChart";
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
      series1.Legend = "appLegend";
      series1.Name = "apps";
      this.appChart.Series.Add(series1);
      this.appChart.Size = new System.Drawing.Size(391, 305);
      this.appChart.TabIndex = 0;
      this.appChart.Text = "chart1";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.AppListPanel);
      this.panel1.Controls.Add(this.processLabel);
      this.panel1.Controls.Add(this.statusLabel);
      this.panel1.Controls.Add(this.iconLabel);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(317, 305);
      this.panel1.TabIndex = 4;
      // 
      // BTM
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(748, 385);
      this.ContextMenuStrip = this.myContextMenu;
      this.Controls.Add(this.allPanel);
      this.MaximizeBox = false;
      this.Name = "BTM";
      this.Resizable = false;
      this.Text = "B.T.M.";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BTM_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.myStyleManager)).EndInit();
      this.myContextMenu.ResumeLayout(false);
      this.allPanel.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.appChart)).EndInit();
      this.panel1.ResumeLayout(false);
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
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.DataVisualization.Charting.Chart appChart;
  }
}

