
/// Programmer : Jonas Smith
/// Program    : Better Time Managment
/// Purpose    : Fun project to test my use of UI's and my ability to track
///              data with system applications

using System.Collections.Generic;
using MetroFramework.Controls;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Drawing;
using MetroFramework;
using System;
using System.Linq;
using System.IO;

namespace B.T.M
{
  public partial class BTM : MetroFramework.Forms.MetroForm
  {
    public string path = "Data.txt";
    public string greenCheck = @"greenTick.png";
    public Process[] processes;
    public List<AppDeet> appList = new List<AppDeet>();
    public Timer timer;

    public BTM()
    {
      InitializeComponent();
      this.StyleManager = myStyleManager;

      timer = new Timer();
      timer.Interval = 1000;
      timer.Enabled = true;
      timer.Tick += new EventHandler(timer1_Tick);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      //myBackGroundWorker.RunWorkerAsync();

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
              AppendReport(appList[j]);
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

    public List<string> RunningApps()
    {
      List<string> applicationList = new List<string>();

      processes = Process.GetProcesses();
      foreach (Process p in processes)
      {
        if (!String.IsNullOrEmpty(p.MainWindowTitle) && (p.ProcessName != "devenv"))
        {
          applicationList.Add(p.ProcessName);
        }
      }

      return applicationList;
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
        if (!String.IsNullOrEmpty(p.MainWindowTitle) && (p.ProcessName != "devenv"))
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
          //button.Click += this.button_Click;

          onlineButton.UseCustomBackColor = true;
          onlineButton.UseCustomForeColor = true;

          onlineButton.BackColor = MetroColors.Green;
          onlineButton.TextAlign = ContentAlignment.MiddleCenter;
          onlineButton.Style     = MetroColorStyle.Teal;
          onlineButton.Theme     = MetroThemeStyle.Dark;
          onlineButton.Image     = Image.FromFile(greenCheck);
          onlineButton.Size      = new Size(buttonHeight + 20, buttonHeight);
          onlineButton.Text      = "Online";
          onlineButton.ForeColor = Color.Black;
          onlineButton.Left      = buttonLength + 12;
          onlineButton.Top       = topMargin;

          topMargin += buttonHeight + 4;

          AppListPanel.Controls.Add(onlineButton);
          AppListPanel.Controls.Add(button);
          AppListPanel.Controls.Add(icon);
          nameCount++;
        }
      }
    }

    private void reloadApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LoadAppList();
    }

    private void AppendReport(AppDeet Data)
    {
      StreamWriter sw = File.AppendText(path);

      sw.WriteLine("{0},{1},{2}",Data.Name, Data.Time, Data.toggleTime(false));

      sw.Close();
    }

    private void BTM_FormClosing(object sender, FormClosingEventArgs e)
    {
      for(int i = 0; i < appList.Count; i++)
      {
        appList[i].toggleTime(false);
        AppendReport(appList[i]);
      }
    }
  }
}
