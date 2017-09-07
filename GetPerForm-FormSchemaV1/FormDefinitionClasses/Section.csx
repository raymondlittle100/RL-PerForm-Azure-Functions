public class Section 
{
  public string title { get; set; }
  public bool titleHidden { get; set; }
  public string internalName { get; set; }
  public bool hidden { get; set; }
  public int columnLayout { get; set; }
  public bool collapsed { get; set; }

  public List<Field> fieldCollection { get; set; }
}