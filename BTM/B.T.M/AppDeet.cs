using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;

namespace B.T.M
{
  public class AppDeet
  {
    string name, startTime;
    DateTime timeOne, timeTwo;

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
