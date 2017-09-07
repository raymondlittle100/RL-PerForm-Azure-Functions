public class TabAction
{  
  public string title { get; set; }
  public string validation { get; set; }

  public bool triggerSave { get; set; }
  public string clickCall { get; set; }
  public string clickCallMode { get; set; }
  public bool allTabs { get; set; }
  public List<TabActionItem> tabReference { get; set; }  
}