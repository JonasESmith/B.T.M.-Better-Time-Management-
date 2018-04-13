
/// Programmer : Jonas Smith
/// Program    : Better Time Managment
/// Purpose    : Fun project to test my use of UI's and my ability to track
///              data with system applications

using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using MetroFramework.Controls;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using MetroFramework;
using System.Linq;
using System;

namespace B.T.M
{
  public partial class BTM : MetroFramework.Forms.MetroForm
  {
    public Timer         AppTimer, 
                         GraphTimer;
    public Process[]     processes;
    public List<AppDeet> appList    = new List<AppDeet>();
    public List<AppHist> appHistory = new List<AppHist>();

    /*<Methods> FormLoading/Closing Methods </Methods> */
    public BTM() {
      InitializeComponent();
      this.StyleManager = myStyleManager;
      LoadChartAreas();

      LoadAppHistory();  UpdateAppList();
      UpdateChart();     StartTimers();
    }
    private void BTM_FormClosing(object sender, FormClosingEventArgs e)
    {
      string runTime = "";
      string saveSettings = "";

      for (int i = 0; i < appList.Count; i++)
      {
        /// Need to change this area to store a userSetting that will properly save the total amount
        /// that each application used, since the begining of time. Shouldnt be too hard. Just need
        /// to add the time for the current application run time. to the time stored for the local 
        /// variable. 

        runTime = appList[i].toggleTime(false);

        var item = appHistory.FirstOrDefault(o => o.Name == appList[i].Name);

        if (appHistory.Contains(item))
        {
          int index = (appHistory.FindIndex(x => x.Name.Contains(appList[i].Name)));

          appHistory[index].AddTime(runTime);
        }
        else
        {
          appHistory.Add(new AppHist(appList[i].Name, runTime));
          saveSettings += (appList[i].Name + "," + runTime);
        }
      }

      saveSettings = appHistory.Count.ToString() + ",";
      for (int i = 0; i < appHistory.Count; i++)
      {
        saveSettings += appHistory[i].Name + "," + appHistory[i].TotalTime + ",";
      }

      Properties.Settings.Default.settingAppHistory = saveSettings;
      Properties.Settings.Default.Save();
    }


    /*<Methods> Application ListMethods </Methods> */
    public void SortAppHistory()
    {
      List<AppHist> SortedList = appHistory.OrderBy(o => o.TotalTime).ToList();
      SortedList.Reverse();

      appHistory.Clear();
      for(int i = 0; i < SortedList.Count; i++)
      {
        appHistory.Add(new AppHist(SortedList[i].Name, SortedList[i].TotalTime));
      }
    }
    public List<string> RunningApps()
    {
      List<string> applicationList = new List<string>();

      processes = Process.GetProcesses();
      foreach (Process p in processes)
      {
        if (!String.IsNullOrEmpty(p.MainWindowTitle) && (p.ProcessName != "devenv") && 
           (p.ProcessName != "ShellExperienceHost") && (p.ProcessName != "NVIDIA Share"))
        {
          applicationList.Add(p.ProcessName);
        }
      }
      return applicationList;
    }


    /*<Methods> Update Methods </Methods> */
    public void UpdateAppList()
    {
      List<string> currentAppList = new List<string>();
      List<string> nameList = new List<string>();

      currentAppList = RunningApps();

      for (int i = 0; i < appList.Count; i++)
      {
        nameList.Add(appList[i].Name);
      }

      // End execution time of Applist Items and Remove. 
      var listOne = nameList.Except(currentAppList).ToList();
      if (listOne.Count > 0)
      {
        for (int i = 0; i < listOne.Count; i++)
        {
          for (int j = 0; j < appList.Count; j++)
          {
            if (appList[j].Name == listOne[i])
            {
              appList[j].toggleTime(false);
              appList.RemoveAt(j);
              LoadAppList();
            }
          }
        }
      }

      // Add new elements to AppList
      var listTwo = currentAppList.Except(nameList).ToList();
      if (listTwo.Count > 0)
      {
        for (int i = 0; i < listTwo.Count; i++)
        {
          appList.Add(new AppDeet(listTwo[i]));
          LoadAppList();
        }
      }
    }
    public void UpdateSeriesData()
    {
      for (int i = 0; i < appList.Count; i++)
      {

        var item = appHistory.FirstOrDefault(o => o.Name == appList[i].Name);

        if (appHistory.Contains(item))
        {
          int index = (appHistory.FindIndex(x => x.Name.Contains(appList[i].Name)));
          appHistory[index].AddTime("0:01:00");
        }
      }
    }
    public void UpdateChart() {
      UpdateSeriesData(); SortAppHistory();

      foreach (var seri in appChart.Series)
      { seri.Points.Clear(); } appChart.Series.Clear();

      Series series = new Series()
      { Name = "series1",
        IsVisibleInLegend = false,
        ChartType = SeriesChartType.Bar };

      appChart.Series.Add(series);

      for(int i = 0; i < appHistory.Count; i++)
      { DataPoint points = new DataPoint(0, appHistory[i].Time);
        points.Label     = Math.Round(Convert.ToDouble(appHistory[i].Time), 2).ToString("n2");
        points.AxisLabel = appHistory[i].Name;

        if (i % 2 == 0){
          points.Color            = MetroColors.Teal;
          points.LabelBackColor   = MetroColors.Teal;
          points.LabelBorderColor = MetroColors.Teal;
        } else {
          points.Color            = Color.Gray;
          points.LabelBorderColor = Color.Gray;
          points.LabelBackColor   = Color.Gray;
        } series.Points.Add(points);
      }
    }


    /*<Methods> Load Methods </Methods> */
    public void LoadChartAreas() {
      appChart.BackColor = Color.FromArgb(17, 17, 17);

      appChart.ChartAreas[0].AxisX.LineColor            = Color.Gray;
      appChart.ChartAreas[0].AxisX.Interval             = 1;
      appChart.ChartAreas[0].AxisX.MajorGrid.LineColor  = Color.Gray;
      appChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Gray;
      appChart.ChartAreas[0].AxisX.RoundAxisValues();

      appChart.ChartAreas[0].AxisY.LineColor            = Color.Gray;
      appChart.ChartAreas[0].AxisY.MajorGrid.LineColor  = Color.Gray;
      appChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Gray;
    }
    public void LoadAppHistory()
    {
       /// Properties.Settings.Default.settingAppHistory = "0";
       /// Properties.Settings.Default.Save();

      string appHist = Properties.Settings.Default.settingAppHistory;

      var words = appHist.Split(',');

      int appCount = Convert.ToInt32(words[0]);

      int j = 0;
      for (int i = 1; i <= appCount; i++)
      {
        j *= 2;
        appHistory.Add( new AppHist(words[1 + j], words[2 + j]));
        j = i;
      }
    }
    public void LoadAppList()
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

      processes = Process.GetProcesses();
      foreach (Process p in processes)
      {
        if (!String.IsNullOrEmpty(p.MainWindowTitle) && (p.ProcessName != "devenv") &&
           (p.ProcessName != "ShellExperienceHost") && (p.ProcessName != "NVIDIA Share"))
        {
          MetroButton onlineButton = new MetroButton();
          MetroButton button       = new MetroButton();
          PictureBox  icon         = new PictureBox();

          try
          { Icon appIcon = Icon.ExtractAssociatedIcon(p.MainModule.FileName);
            icon.Image = appIcon.ToBitmap();
          }
          catch
          {/**/}

          icon.Size = new Size(buttonHeight, buttonHeight);
          icon.Left = margin;
          icon.Top  = topMargin;


          button.Size       = new Size(buttonLength - buttonHeight, buttonHeight);
          button.TextAlign  = ContentAlignment.MiddleLeft;
          button.Name       = "button" + nameCount;
          button.Text       = p.ProcessName;
          button.Style      = MetroColorStyle.Teal;
          button.Theme      = MetroThemeStyle.Dark;
          button.Left       = leftMargin;
          button.Top        = topMargin;
          button.TabIndex   = 0;
          button.TabStop    = false;
          //button.Click += this.button_Click;

          onlineButton.UseCustomBackColor = true;
          onlineButton.UseCustomForeColor = true;

          onlineButton.BackColor = MetroColors.Green;
          onlineButton.TextAlign = ContentAlignment.MiddleCenter;
          onlineButton.Style     = MetroColorStyle.Teal;
          onlineButton.Theme     = MetroThemeStyle.Dark;
          onlineButton.Size      = new Size(buttonHeight + 20, buttonHeight);
          onlineButton.Text      = "";
          onlineButton.ForeColor = Color.Black;
          onlineButton.Left      = buttonLength + 12;
          onlineButton.Top       = topMargin;
          onlineButton.TabIndex  = 0;
          onlineButton.TabStop   = false;

          topMargin += buttonHeight + 4;

          AppListPanel.Controls.Add(onlineButton);
          AppListPanel.Controls.Add(button);
          AppListPanel.Controls.Add(icon);
          nameCount++;
        }
      }
    }


    /*<Methods> Timer Methods </Methods> */
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
    {
      UpdateChart();
    }
    private void timer1_Tick(object sender, EventArgs e)
    {
      UpdateAppList();
    }
  }
}
