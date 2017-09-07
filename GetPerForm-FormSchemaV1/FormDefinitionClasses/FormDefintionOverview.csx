#load "..\FormDefintionOverview\TabActions.csx"
#load "..\FormDefintionOverview\Tabs.csx"

public class FormDefintionOverview 
{
  public string internalName { get; set; }
  public string name { get; set; }
  public string client { get; set; }
  public Tabs tabs { get; set; }  
  public TabActions tabActions { get; set; }  
}