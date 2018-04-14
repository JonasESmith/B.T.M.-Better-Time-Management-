
/// Programmer : Jonas Smith
/// Program    : Better Time Managment
/// Purpose    : Fun project to test my use of UI's and my ability to track
///              data with system applications

using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using MetroFramework.Controls;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Diagnostics;
using System.Drawing;
using MetroFramework;
using System.Linq;
using System;

namespace B.T.M
{
  public partial class BTM : MetroForm
  {
    public Timer         AppTimer, 
                         GraphTimer;
    public Process[]     processes;
    public List<AppDeet> appList    = new List<AppDeet>();
    public List<AppHist> appHistory = new List<AppHist>();
    public bool tracking;

    /*<Methods> FormLoading/Closing Methods </Methods> */
    #region Application Start / Close
    public BTM() {
      InitializeComponent();
      this.StyleManager = myStyleManager;
      LoadChartAreaThemes();

      trackToggle.CheckState = CheckState.Checked;
      tracking = true;

      LoadAppHistory();  UpdateAppList();
      UpdateChart();     StartTimers();
    }

    private void BTM_FormClosing(object sender, FormClosingEventArgs e)
    {
      string runTime = "";
      string saveSettings = "";

      for (int i = 0; i < appList.Count; i++) {
        /// Need to change this area to store a userSetting that will properly save the total amount
        /// that each application used, since the begining of time. Shouldnt be too hard. Just need
        /// to add the time for the current application run time. to the time stored for the local 
        /// variable. 

        runTime = appList[i].toggleTime(false);

        var item = appHistory.FirstOrDefault(o => o.Name == appList[i].Name);

        if (appHistory.Contains(item)) {
          //int index = (appHistory.FindIndex(x => x.Name.Contains(appList[i].Name)));
          //appHistory[index].AddTime(runTime);
        } else {
          appHistory.Add(new AppHist(appList[i].Name, runTime, appList[i].Name, true, appList[i].Path));
          saveSettings += (appList[i].Name + "," + runTime); }
      }

      saveSettings = appHistory.Count.ToString() + ",";
      for (int i = 0; i < appHistory.Count; i++)
      {
        saveSettings += appHistory[i].Name   + "," + appHistory[i].TotalTime + "," 
                     +  appHistory[i]._Alias + "," + appHistory[i].Track     + ","
                     +  appHistory[i]._Path  + ",";
      }

      Properties.Settings.Default.settingAppHistory = saveSettings;
      Properties.Settings.Default.Save();
    }
    #endregion


    /*<Methods> Update Methods </Methods> */
    #region Update
    public void SortAppHistory() {

      List<AppHist> SortedList = appHistory.OrderBy(o => o.TotalTime).ToList();

      appHistory.Clear();
      for(int i = 0; i < SortedList.Count; i++)
      {
        appHistory.Add(new AppHist(SortedList[i].Name,   SortedList[i].TotalTime,
                                   SortedList[i]._Alias, SortedList[i].Track, 
                                   SortedList[i]._Path));
      }
    }

    public void UpdateAppButtons()
    {
      /// clears all previouse controls from the panel
      AppListPanel.Controls.Clear();

      /// This sets the proper dementions for the buttons and 
      ///   their corresponding images. 
      int buttonHeight = 32;
      int margin       = 5;
      int topMargin    = margin;
      int nameCount    = 1;
      int leftMargin   = margin + buttonHeight + 5;
      int buttonLength = AppListPanel.Width - buttonHeight * 2 - 4;


      /// Gets all processes and sets an image/button for each
      ///   also adds application to list to be tested for
      ///   currently running applications. 
      ///   
      appHistory.Reverse();

      for(int i = 0; i < appHistory.Count; i++)
      {
        {
          MetroButton onlineButton = new MetroButton();
          MetroButton button       = new MetroButton();
          PictureBox  icon         = new PictureBox();

          try
          { Icon appIcon = Icon.ExtractAssociatedIcon(appHistory[i]._Path);
            icon.Image = appIcon.ToBitmap();
          }
          catch
          {/* */}

          icon.Size = new Size(buttonHeight, buttonHeight);
          icon.Left = margin;
          icon.Top  = topMargin;


          button.Size         = new Size(buttonLength - buttonHeight, buttonHeight);
          button.TextAlign    = ContentAlignment.MiddleLeft;
          button.Name         = "button" + nameCount;
          button.Text         = appHistory[i]._Alias;
          button.Left         = leftMargin;
          button.Top          = topMargin;
          button.TabIndex     = 0;
          button.TabStop      = false;
          button.Click       += this.button_Click;
          button.StyleManager = myStyleManager;

          onlineButton.UseCustomBackColor = true;
          onlineButton.UseCustomForeColor = true;

          if(appHistory[i].Track) {
            onlineButton.BackColor = Color.FromArgb(45, 60, 90);
            onlineButton.Text      = "yes";
            onlineButton.ForeColor = Color.DarkGray;
          }
          else{ // The same color as the other buttons.

            onlineButton.BackColor = Color.FromArgb(35, 35, 35);
            onlineButton.Text      = "no";
            onlineButton.ForeColor = Color.Gray;
          }

          onlineButton.TextAlign    = ContentAlignment.MiddleCenter;
          onlineButton.Size         = new Size(buttonHeight + 20, buttonHeight);
          onlineButton.Left         = buttonLength + 12;
          onlineButton.Top          = topMargin;
          onlineButton.TabIndex     = 0;
          onlineButton.TabStop      = false;
          onlineButton.StyleManager = myStyleManager;

          topMargin += buttonHeight + 4;

          AppListPanel.Controls.Add(onlineButton);
          AppListPanel.Controls.Add(button);
          AppListPanel.Controls.Add(icon);
          nameCount++;
        }
      }
      appHistory.Reverse();
    }

    public void UpdateAppList()
    {
      List<string> tempList = new List<string>();
      List<string> runningPaths = new List<string>();
      List<string> currentAppList = new List<string>();
      List<string> nameList = new List<string>();

      tempList = RunningApps();

      for(int i = 0; i < tempList.Count; i++) {
        var words = tempList[i].Split(',');

        currentAppList.Add(words[0]);
        runningPaths.Add(words[1]);
      }

      for (int i = 0; i < appList.Count; i++)
      { nameList.Add(appList[i].Name); }

      // End execution time of Applist Items and Remove. 
      var listOne = nameList.Except(currentAppList).ToList();
      if (listOne.Count > 0){
        for (int i = 0; i < listOne.Count; i++){
          for (int j = 0; j < appList.Count; j++){
            if (appList[j].Name == listOne[i]){
              appList[j].toggleTime(false);
              appList.RemoveAt(j);
              UpdateAppButtons();
            } } } }

      // Add new elements to AppList
      var listTwo = currentAppList.Except(nameList).ToList();
      if (listTwo.Count > 0) {
        int index = 0;
        for (int i = 0; i < listTwo.Count; i++) {

          for(int j = 0; j < currentAppList.Count; j++)
          {
            if(currentAppList[j].Contains(listTwo[i]))
            {
              index = j;
              break;
            }
          }

          appList.Add(new AppDeet(listTwo[i], runningPaths[index], 0));
          UpdateAppButtons();

        } }

      for (int i = 0; i < appHistory.Count; i++)
      { nameList.Add(appHistory[i].Name); }

      var listThree = currentAppList.Except(nameList).ToList();
      if (listThree.Count > 0){
        int index = 0;
        for (int i = 0; i < listThree.Count; i++){

          index = currentAppList.FindIndex(a => a == listThree[i]);


          appHistory.Add(new AppHist(listThree[i], "00:00:00", listThree[i], true, runningPaths[index]));
          UpdateAppButtons(); 
        } }

    }

    public void UpdateChart() {
      UpdateSeriesData();

      foreach (var seri in appChart.Series)
      { seri.Points.Clear(); }

      appChart.Series.Clear();

      Series series = new Series()
      { Name = "series1", IsVisibleInLegend = false, ChartType = SeriesChartType.Bar };

      appChart.Series.Add(series);
      appChart.ChartAreas[0].AxisY.Title          = "(hours)";
      appChart.ChartAreas[0].AxisY.TitleForeColor = Color.Gray;

      for (int i = 0; i < appHistory.Count; i++) {
        if (appHistory[i].Track) {
          DataPoint points          = new DataPoint(0, appHistory[i].Time);
          points.AxisLabel          = appHistory[i]._Alias;
          points.Label              = (appHistory[i].TimeLabel);

          if (i % 2 == 0) {
            points.Color            = Color.FromArgb(45, 60, 90);
            points.LabelForeColor   = Color.Gray;
            points.LabelBackColor   = Color.FromArgb(45, 60, 90);
            points.LabelBorderColor = Color.FromArgb(45, 60, 90);

          } else {
            points.Color            = Color.FromArgb(60, 60, 90);
            points.LabelForeColor   = Color.Gray;
            points.LabelBackColor   = Color.FromArgb(60, 60, 90);
            points.LabelBorderColor = Color.FromArgb(60, 60, 90);

          } series.Points.Add(points); }
      }
    }

    public void UpdateSeriesData() {
      for (int i = 0; i < appList.Count; i++) {
        var item = appHistory.FirstOrDefault(o => o.Name == appList[i].Name);

        if (appHistory.Contains(item)) {
          int index = (appHistory.FindIndex(x => x.Name.Contains(appList[i].Name)));
          if(appHistory[index].Track)
          { appHistory[index].AddTime("0:00:15"); }

        }}
    }

    public List<string> RunningApps()
    { List<string> applicationList = new List<string>();
      processes = Process.GetProcesses();
      foreach (Process p in processes) {
        if (!String.IsNullOrEmpty(p.MainWindowTitle) && (p.ProcessName != "devenv")) {
          try { applicationList.Add(p.ProcessName + "," + p.MainModule.FileName); }
          catch { } } }
      return applicationList;
    }
    #endregion


    /*<Methods> Load Methods </Methods> */
    #region Load
    public void LoadChartAreaThemes() {
      

      appChart.BackColor = Color.FromArgb(17, 17, 17);

      appChart.ChartAreas[0].AxisX.LineColor            = Color.Gray;
      appChart.ChartAreas[0].AxisX.Interval             = 1;
      appChart.ChartAreas[0].AxisX.MajorGrid.LineColor  = Color.Gray;
      appChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Gray;
      appChart.ChartAreas[0].AxisX.RoundAxisValues();

      appChart.ChartAreas[0].AxisY.LineColor            = Color.Gray;
      appChart.ChartAreas[0].AxisY.MajorGrid.LineColor  = Color.Gray;
      appChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Gray;

      appSaveBtn.BackColor = MetroColors.Green;
      appSaveBtn.ForeColor = Color.Black;

      appClosePanel.BackColor = Color.Gray;
      appClosePanel.ForeColor = Color.Black;
    }

    public void LoadAppHistory()
    {
      //Properties.Settings.Default.settingAppHistory = "0";
      //Properties.Settings.Default.Save();

      string appHist = Properties.Settings.Default.settingAppHistory;

      var words = appHist.Split(',');

      int appCount = Convert.ToInt32(words[0]);

      int j = 0;
      for (int i = 1; i <= appCount; i++)
      {
        j *= 5;
        appHistory.Add( new AppHist(words[1 + j], words[2 + j], words[3 + j], Convert.ToBoolean(words[4 + j]), words[5 + j]));
        j = i;
      }
    }
    #endregion


    /*<Methods> Timer Methods </Methods> */
    #region Timers
    public void StartTimers()
    {
      AppTimer = new Timer();
      AppTimer.Interval = 1000;
      AppTimer.Enabled = true;
      AppTimer.Tick += new EventHandler(timer1_Tick);

      GraphTimer = new Timer();
      GraphTimer.Enabled = true;
      GraphTimer.Interval = 15000;
      GraphTimer.Tick += new EventHandler(timer2_tick);
    }

    private void timer2_tick(object sender, EventArgs e)
    { if (tracking) {
        UpdateChart();
        SortAppHistory();
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    { if (tracking) {
        UpdateAppList();
        SortAppHistory();
      }
    }
    #endregion


    /*<Methods> Button Methods </Methods> */
    #region Buttons
    private void appClosePanel_Click(object sender, EventArgs e)
    {
      appSaveBtn.Enabled = false;
      appDataPanel.Visible = false;
      appDataPanel.Enabled = false;
    }

    private void button_Click(object sender, EventArgs e)
    {
      MetroButton button = sender as MetroButton;

      appSaveBtn.Enabled = true;
      appDataPanel.Enabled = true;
      appDataPanel.Visible = true;

      int index = appHistory.FindIndex(a => a._Alias == button.Text);

      if (appHistory[index].Track)
      {
        appTrackingCmb.SelectedIndex = 0;
      }
      else
      {
        appTrackingCmb.SelectedIndex = 1;
      }

      appSettingsBanner.Text  = appHistory[index]._Alias + " Settings";
      appSettingsBanner.ForeColor = Color.White;
      appAliasDisplay.Text = appHistory[index].Alias;
      appLabelName.Text = appHistory[index].Name;

      if (appHistory[index].Track)
        appTrackingCmb.SelectedIndex = 0;
      else
        appTrackingCmb.SelectedIndex = 1;
    }

    private void trackToggle_CheckedChanged(object sender, EventArgs e)
    {
      if (tracking)
        tracking = false;
      else
        tracking = true;
    }

    private void appSaveBtn_Click(object sender, EventArgs e)
    {
      int index = appHistory.FindIndex(a => a.Name == appLabelName.Text);

      if (appTrackingCmb.SelectedIndex == 0)
        appHistory[index].Track = true;
      else
        appHistory[index].Track = false;

      appHistory[index]._Alias = appAliasDisplay.Text;

      UpdateAppButtons();
      UpdateChart();
    }
    #endregion
  }
}
