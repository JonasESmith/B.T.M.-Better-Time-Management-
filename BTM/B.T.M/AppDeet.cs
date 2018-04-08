using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;

namespace B.T.M
{
  public class AppDeet
  {
    string name;
    string timeToggle = "";

    public AppDeet(string name)
    {
      this.name = name;
      toggleTime(true, "");
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

    public string toggleTime(bool toggle, string startTime)
    {
      timeToggle = "";
      if(toggle)
      {
        timeToggle = "START:" + DateTime.Now.ToShortTimeString() + ",";
      }
      else
      {
        timeToggle = startTime + "END:" + DateTime.Now.ToShortTimeString();
      }

      return timeToggle;
    }

    public string Time
    {
      get
      {
        return timeToggle;
      }
    }
  }
}
