﻿using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;

namespace B.T.M
{
  public class AppDeet
  {
    string name, startTime, totalTime, path;
    DateTime timeOne, timeTwo;

    public AppDeet(string name, string _path, int nothing)
    {
      this.name = name;
      this.path = _path;
    }

    public AppDeet(string name, string time)
    {
      this.name = name;
      this.totalTime = time;
    }

    public string Path
    {
      get
      {
        return path;
      }
    }


    public AppDeet(string name)
    {
      this.name = name;
      toggleTime(true);
    }

    public string Name
    {
     get
      {
        return name;
      }
      set
      {
        this.name = value;
      }
    }

    public string TotalTime
    {
      get
      {
        return name;
      }
      set
      {
        this.name = value;
      }
    }

    public string toggleTime(bool toggle)
    {
      if(toggle)
      {
        timeOne = DateTime.Now;
        startTime = DateTime.Now.ToShortTimeString();
      }
      else
      {
        timeTwo = DateTime.Now;
      }

      TimeSpan ts = (timeTwo - timeOne);

      return ts.ToString(@"hh\:mm\:ss");
    }

    public string Time
    {
      get
      {
        return startTime;
      }
    }
  }
}
