using System;
using System.Net;
using Newtonsoft.Json;

private static readonly string ADMIN_USER_CONFIG_KEY = "SharePointAdminUser";
private static readonly string ADMIN_PASSWORD_CONFIG_KEY = "SharePointAdminPassword";

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("GetPerForm-FormSchemaV1 processed a request.");

    var fieldJSON = GetJson();

    log.Info("GetPerForm-FormSchemaV1 JSON is "+ fieldJSON);

    return req.CreateResponse(HttpStatusCode.OK,  fieldJSON);
}

public static string GetJson() 
{
  #region Fields

  List<Field> fields = new List<Field>();

    var fieldFour = new Field();
  fieldFour.type = "select";
  fieldFour.content = "2";
  fieldFour.dataMapping = "prefix";
  fieldFour.label = "Title";
  fieldFour.showLabel = false;
  fieldFour.required = true;
  fieldFour.readOnly = true;
  fieldFour.showDescription = false;
  fieldFour.description = "Please supply your title";
  fieldFour.cssClass = "prefix";
  fieldFour.maxLength = 50;

  var fieldOne = new Field();
  fieldOne.type = "input";
  fieldOne.content = "Raymond";
  fieldOne.dataMapping = "FirstName";
  fieldOne.label = "First Name";
  fieldOne.showLabel = false;
  fieldOne.required = true;
  fieldOne.readOnly = true;
  fieldOne.showDescription = false;
  fieldOne.description = "Please supply your first name";
  fieldOne.cssClass = "firstName";
  fieldOne.maxLength = 50;

  var fieldFive = new Field();
  fieldFive.type = "input";
  fieldFive.content = "william";
  fieldFive.dataMapping = "MiddleName";
  fieldFive.label = "Middle Name";
  fieldFive.showLabel = false;
  fieldFive.required = true;
  fieldFive.readOnly = true;
  fieldFive.showDescription = false;
  fieldFive.description = "Please supply your middle name";
  fieldFive.cssClass = "middleName";
  fieldFive.maxLength = 50;
   
  var fieldTwo = new Field();
  fieldTwo.type = "input";
  fieldTwo.content = "Little";
  fieldTwo.dataMapping = "SecondName";
  fieldTwo.label = "Second Name";
  fieldTwo.showLabel = false;
  fieldTwo.required = true;
  fieldTwo.readOnly = true;
  fieldTwo.showDescription = false;
  fieldTwo.description = "Please supply your last name";
  fieldTwo.cssClass = "lastName";
  fieldTwo.maxLength = 50;
   
  var fieldThree = new Field();
  fieldThree.type = "input";
  fieldThree.content = "11/08/1982";
  fieldThree.dataMapping = "DoB";
  fieldThree.label = "Date of Birth";
  fieldThree.showLabel = false;
  fieldThree.required = true;
  fieldThree.readOnly = true;
  fieldThree.showDescription = false;
  fieldThree.description = "Please supply your DoB";
  fieldThree.cssClass = "dob";
  fieldThree.maxLength = 50;

    fields.Add(fieldOne);
    fields.Add(fieldTwo);
    fields.Add(fieldThree);
    fields.Add(fieldFour);
    fields.Add(fieldFive);

#endregion

#region Sections

#region Tab One Sections

List<Section> tabOneSections = new List<Section>();
Section tabOneSectionOne = new Section();
tabOneSectionOne.title="Section One";
tabOneSectionOne.titleVisible= true;
tabOneSectionOne.columnLayout="twoColumn";
tabOneSectionOne.collapsed= false;
tabOneSectionOne.fieldCollection = fields;
tabOneSectionOne.visible = true;

Section tabOneSectionTwo = new Section();
tabOneSectionTwo.title="Section Two";
tabOneSectionTwo.titleVisible= true;
tabOneSectionTwo.columnLayout="oneColumn";
tabOneSectionTwo.collapsed= false;
tabOneSectionTwo.fieldCollection = fields;
tabOneSectionTwo.visible = true;

tabOneSections.Add(tabOneSectionOne);
tabOneSections.Add(tabOneSectionTwo);

#endregion

#region Tab Two Sections

List<Section> tabTwoSections = new List<Section>();
Section tabTwoSectionOne = new Section();
tabTwoSectionOne.title="Section One";
tabTwoSectionOne.titleVisible= true;
tabTwoSectionOne.columnLayout="threeColumn";
tabTwoSectionOne.collapsed= false;
tabTwoSectionOne.fieldCollection = fields;
tabTwoSectionOne.visible = true;

Section tabTwoSectionTwo = new Section();
tabTwoSectionTwo.title="Section Two";
tabTwoSectionTwo.titleVisible= true;
tabTwoSectionTwo.columnLayout="twoColumn";
tabTwoSectionTwo.collapsed= false;
tabTwoSectionTwo.fieldCollection = fields;
tabTwoSectionTwo.visible = true;

Section tabTwoSectionThree = new Section();
tabTwoSectionThree.title="Section Three";
tabTwoSectionThree.titleVisible= true;
tabTwoSectionThree.columnLayout="twoColumn";
tabTwoSectionThree.collapsed= false;
tabTwoSectionThree.fieldCollection = fields;
tabTwoSectionThree.visible = false;

Section tabTwoSectionFour = new Section();
tabTwoSectionFour.title="Section Four";
tabTwoSectionFour.titleVisible= true;
tabTwoSectionFour.columnLayout="twoColumn";
tabTwoSectionFour.collapsed= false;
tabTwoSectionFour.fieldCollection = fields;
tabTwoSectionFour.visible = true;

tabTwoSections.Add(tabTwoSectionOne);
tabTwoSections.Add(tabTwoSectionTwo);
tabTwoSections.Add(tabTwoSectionThree);
tabTwoSections.Add(tabTwoSectionFour);

#endregion

#region Tab Three Sections

List<Section> tabThreeSections = new List<Section>();
Section tabThreeSectionOne = new Section();
tabThreeSectionOne.title="Section One";
tabThreeSectionOne.titleVisible= true;
tabThreeSectionOne.columnLayout="threeColumn";
tabThreeSectionOne.collapsed= false;
tabThreeSectionOne.fieldCollection = fields;
tabThreeSectionOne.visible = true;

Section tabThreeSectionTwo = new Section();
tabThreeSectionTwo.title="Section Two";
tabThreeSectionTwo.titleVisible= true;
tabThreeSectionTwo.columnLayout="twoColumn";
tabThreeSectionTwo.collapsed= false;
tabThreeSectionTwo.fieldCollection = fields;
tabThreeSectionTwo.visible = true;

tabThreeSections.Add(tabThreeSectionOne);
tabThreeSections.Add(tabThreeSectionTwo);

#endregion

#region Tab Four Sections

List<Section> tabFourSections = new List<Section>();
Section tabFourSectionOne = new Section();
tabFourSectionOne.title="Section One";
tabFourSectionOne.titleVisible= true;
tabFourSectionOne.columnLayout="threeColumn";
tabFourSectionOne.collapsed= false;
tabFourSectionOne.fieldCollection = fields;
tabFourSectionOne.visible = true;

tabFourSections.Add(tabFourSectionOne);

#endregion

#endregion

#region Tabs

  List<TabContentItem> contentTabs = new List<TabContentItem>();

  TabContentItem tabOne = new TabContentItem();
  tabOne.title="Tab One" ;
  tabOne.visible = true;
  tabOne.titleVisible = true;
  tabOne.sectionCollection = tabOneSections;  

  TabContentItem tabTwo = new TabContentItem();
  tabTwo.title="Tab Two" ;
  tabTwo.visible = false;
  tabTwo.titleVisible = true;
  tabTwo.sectionCollection = tabTwoSections;
  
  TabContentItem tabThree = new TabContentItem();
  tabThree.title="Tab Three" ;
  tabThree.visible = true;
  tabThree.titleVisible = true;
  tabThree.sectionCollection = tabThreeSections;

  TabContentItem tabFour = new TabContentItem();
  tabFour.title="Tab Four" ;
  tabFour.visible = true;
  tabFour.titleVisible = false;
  tabFour.sectionCollection = tabFourSections;
  
  contentTabs.Add(tabOne);
  contentTabs.Add(tabTwo);
  contentTabs.Add(tabThree);
  contentTabs.Add(tabFour);

  Tabs tabs = new Tabs();
  tabs.flattenTabs = false;
  tabs.tabDetails = contentTabs;

  #endregion

  FormDefintionOverview fd = new  FormDefintionOverview();
  fd.client = "Test Client";
  fd.internalName="field_internal_name";
  fd.name="field name";
  fd.tabs = tabs;
    
  return JsonConvert.SerializeObject(fd);
}

public class Field 
{
  public string type { get; set; }
  public string content { get; set; }
  public string dataMapping { get; set; }
  public string label { get; set; }
  public bool showLabel { get; set; }
  public bool required { get; set; }
  public bool readOnly { get; set; }
  public bool showDescription { get; set; }
  public string description { get; set; }
  public string cssClass { get; set; }
  public int maxLength { get; set; }

}

public class Section 
{
  public string title { get; set; }
  public bool titleVisible { get; set; }
  public bool visible { get; set; }
  public string columnLayout { get; set; }
  public bool collapsed { get; set; }

  public List<Field> fieldCollection { get; set; }
}

public class TabContentItem 
{
  public string title { get; set; }
  public bool titleVisible { get; set; }
  public bool visible { get; set; }

  public List<Section> sectionCollection { get; set; }
}

public class TabContent 
{
  public List<TabContentItem> tabsCollection { get; set; }
}

public class Tabs 
{
  public List<TabContentItem> tabDetails { get; set; }
  public bool flattenTabs { get; set; }
}
public class FormDefintionOverview 
{
  public string internalName { get; set; }
  public string name { get; set; }
  public string client { get; set; }
  public Tabs tabs { get; set; }  
}