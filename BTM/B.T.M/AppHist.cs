using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;

namespace B.T.M
{
  public class AppHist
  {
    string name, totalTime, alias;

    public AppHist(string name, string time)
    {
      this.name = name;
      this.totalTime = time;
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

    public string Alias
    {
      get
      {
        return alias;
      }
    }

    public void AddTime(string time)
    {
      int hours = 0, minutes = 0, seconds = 0;
      TimeSpan addedTime, totTime;

      var words = time.Split(':');
      hours   = Convert.ToInt32(words[0]);
      minutes = Convert.ToInt32(words[1]);
      seconds = Convert.ToInt32(words[2]);

      addedTime = new TimeSpan(hours, minutes, seconds);

      words = TotalTime.Split(':');
      hours   = Convert.ToInt32(words[0]);
      minutes = Convert.ToInt32(words[1]);
      seconds = Convert.ToInt32(words[2]);

      totTime = new TimeSpan(hours,minutes,seconds);

      totalTime = (totTime + addedTime).ToString();
    }

    public string TotalTime
    {
      get
      {
        return totalTime;
      }
    }

    public string Time
    {
      get
      {
        int hours, minutes, seconds;

        var words = totalTime.Split(':');
        hours = Convert.ToInt32(words[0]);
        minutes = Convert.ToInt32(words[1]);
        seconds = Convert.ToInt32(words[2]);

        TimeSpan timeSpan = new TimeSpan(hours, minutes, seconds);
        return timeSpan.TotalHours.ToString();
      }
    }
  }
}
