#load "Section.csx"

public class TabContentItem 
{
  public string title { get; set; }  
  public bool titleHidden { get; set; }
  public string internalName { get; set; }
  public bool hidden { get; set; }

  public List<Section> sectionCollection { get; set; }
}