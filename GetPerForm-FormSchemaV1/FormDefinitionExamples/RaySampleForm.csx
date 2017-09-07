#load "..\FormDefintionOverview\FieldDetails.csx"
#load "..\FormDefintionOverview\Section.csx"
#load "..\FormDefintionOverview\TabContent.csx"
#load "..\FormDefintionOverview\TabContentItem.csx"
#load "..\FormDefintionOverview\Tabs.csx"
#load "..\FormDefintionOverview\TabActionItem.csx"
#load "..\FormDefintionOverview\TabAction.csx"
#load "..\FormDefintionOverview\TabActions.csx"
#load "..\FormDefintionOverview\FormDefintionOverview.csx"

public class RaySampleForm 
{
    public RaySampleForm()
    {

    }

    public string GetFormJson() 
    {

    #region Fields

    List<Field> fields = new List<Field>();

    var fieldFour = new Field();
    fieldFour.type = "select";
    fieldFour.hidden = false;
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
    fieldOne.hidden = false;
    fieldOne.dataMapping = "FirstName";
    fieldOne.label = "First Name";
    fieldOne.showLabel = true;
    fieldOne.required = true;
    fieldOne.readOnly = true;
    fieldOne.showDescription = false;
    fieldOne.description = "Please supply your first name";
    fieldOne.cssClass = "firstName";
    fieldOne.maxLength = 50;

    var fieldFive = new Field();
    fieldFive.type = "input";
    fieldFive.hidden = false;
    fieldFive.dataMapping = "MiddleName";
    fieldFive.label = "Middle Name";
    fieldFive.showLabel = true;
    fieldFive.required = false;
    fieldFive.readOnly = true;
    fieldFive.showDescription = false;
    fieldFive.description = "Please supply your middle name";
    fieldFive.cssClass = "middleName";
    fieldFive.maxLength = 50;
    
    var fieldTwo = new Field();
    fieldTwo.type = "input";
    fieldTwo.hidden = false;
    fieldTwo.dataMapping = "SecondName";
    fieldTwo.label = "Second Name";
    fieldTwo.showLabel = true;
    fieldTwo.required = true;
    fieldTwo.readOnly = true;
    fieldTwo.showDescription = false;
    fieldTwo.description = "Please supply your last name";
    fieldTwo.cssClass = "lastName";
    fieldTwo.maxLength = 50;
    
    var fieldThree = new Field();
    fieldThree.type = "date";
    fieldThree.hidden = false;
    fieldThree.dataMapping = "DoB";
    fieldThree.label = "Date of Birth";
    fieldThree.showLabel = true;
    fieldThree.required = true;
    fieldThree.readOnly = true;
    fieldThree.showDescription = false;
    fieldThree.description = "Please supply your DoB";
    fieldThree.cssClass = "dob";
    fieldThree.maxLength = 50;

    var fieldSix = new Field();
    fieldSix.type = "email";
    fieldSix.hidden = false;
    fieldSix.dataMapping = "email";
    fieldSix.label = "Email Address";
    fieldSix.showLabel = true;
    fieldSix.required = true;
    fieldSix.readOnly = false;
    fieldSix.showDescription = false;
    fieldSix.description = "Please supply your email address";
    fieldSix.cssClass = "email";  

    var fieldSeven = new Field();
    fieldSeven.type = "multiline";
    fieldSeven.hidden = false;
    fieldSeven.dataMapping = "TaskOneComments";
    fieldSeven.label = "Comments";
    fieldSeven.showLabel = true;
    fieldSeven.required = true;
    fieldSeven.readOnly = false;
    fieldSeven.showDescription = false;
    fieldSeven.description = "Please supply your comments";
    fieldSeven.cssClass = "comments";
    fieldSeven.maxLength = 300;

    var fieldEight = new Field();
    fieldEight.type = "input";
    fieldEight.hidden = true;
    fieldEight.dataMapping = "HiddenTest";
    fieldEight.label = "Hidden Test";
    fieldEight.showLabel = false;
    fieldEight.required = true;
    fieldEight.readOnly = true;
    fieldEight.showDescription = false;
    fieldEight.description = "should be hidden";
    fieldEight.cssClass = "hidden";
    fieldEight.maxLength = 50;

    var fieldNine = new Field();
    fieldNine.type = "input";
    fieldNine.hidden = false;
    fieldNine.dataMapping = "Brand";
    fieldNine.label = "Brand";
    fieldNine.showLabel = true;
    fieldNine.required = true;
    fieldNine.readOnly = false;
    fieldNine.showDescription = true;
    fieldNine.description = "Please set the brand";
    fieldNine.cssClass = "brand";
    fieldNine.maxLength = 100;

    var fieldTen = new Field();
    fieldTen.type = "input";
    fieldTen.hidden = false;
    fieldTen.dataMapping = "Markets";
    fieldTen.label = "Market";
    fieldTen.showLabel = true;
    fieldTen.required = true;
    fieldTen.readOnly = false;
    fieldTen.showDescription = true;
    fieldTen.description = "Please set market";
    fieldTen.cssClass = "market";
    fieldTen.maxLength = 100;

    var fieldEleven  = new Field();
    fieldEleven.type = "input";
    fieldEleven.hidden = false;
    fieldEleven.dataMapping = "TomTest";
    fieldEleven.label = "Tom Test";
    fieldEleven.showLabel = true;
    fieldEleven.required = true;
    fieldEleven.readOnly = false;
    fieldEleven.showDescription = true;
    fieldEleven.description = "Please set Tom Test";
    fieldEleven.cssClass = "TomTest";
    fieldEleven.maxLength = 100;

        fields.Add(fieldOne);
        fields.Add(fieldTwo);
        fields.Add(fieldThree);
        fields.Add(fieldFour);
        fields.Add(fieldFive);
        fields.Add(fieldSix);
        fields.Add(fieldSeven);
        fields.Add(fieldEight);    
        fields.Add(fieldNine);  
        fields.Add(fieldTen);  
        fields.Add(fieldEleven); 
        

    #endregion

    #region Sections

    #region Tab One Sections

    List<Section> tabOneSections = new List<Section>();
    Section tabOneSectionOne = new Section();
    tabOneSectionOne.title="Section One";
    tabOneSectionOne.internalName="sectionOne";
    tabOneSectionOne.titleHidden= false;
    tabOneSectionOne.columnLayout=2;
    tabOneSectionOne.collapsed= false;
    tabOneSectionOne.fieldCollection = fields;
    tabOneSectionOne.hidden = false;

    Section tabOneSectionTwo = new Section();
    tabOneSectionTwo.title="Section Two";
    tabOneSectionTwo.internalName="sectionTwo";
    tabOneSectionTwo.titleHidden= false;
    tabOneSectionTwo.columnLayout=1;
    tabOneSectionTwo.collapsed= false;
    tabOneSectionTwo.fieldCollection = fields;
    tabOneSectionTwo.hidden = false;

    tabOneSections.Add(tabOneSectionOne);
    tabOneSections.Add(tabOneSectionTwo);

    #endregion

    #region Tab Two Sections

    List<Section> tabTwoSections = new List<Section>();
    Section tabTwoSectionOne = new Section();
    tabTwoSectionOne.title="Section One";
    tabTwoSectionOne.internalName="sectionOne";
    tabTwoSectionOne.titleHidden= false;
    tabTwoSectionOne.columnLayout=3;
    tabTwoSectionOne.collapsed= false;
    tabTwoSectionOne.fieldCollection = fields;
    tabTwoSectionOne.hidden = false;

    Section tabTwoSectionTwo = new Section();
    tabTwoSectionTwo.title="Section Two";
    tabTwoSectionTwo.internalName="sectionTwo";
    tabTwoSectionTwo.titleHidden= false;
    tabTwoSectionTwo.columnLayout=4;
    tabTwoSectionTwo.collapsed= false;
    tabTwoSectionTwo.fieldCollection = fields;
    tabTwoSectionTwo.hidden = false;

    Section tabTwoSectionThree = new Section();
    tabTwoSectionThree.title="Section Three";
    tabTwoSectionThree.internalName="sectionThree";
    tabTwoSectionThree.titleHidden= false;
    tabTwoSectionThree.columnLayout=2;
    tabTwoSectionThree.collapsed= false;
    tabTwoSectionThree.fieldCollection = fields;
    tabTwoSectionThree.hidden = true;

    Section tabTwoSectionFour = new Section();
    tabTwoSectionFour.title="Section Four";
    tabTwoSectionFour.internalName="sectionFour";
    tabTwoSectionFour.titleHidden= false;
    tabTwoSectionFour.columnLayout=1;
    tabTwoSectionFour.collapsed= false;
    tabTwoSectionFour.fieldCollection = fields;
    tabTwoSectionFour.hidden = false;

    tabTwoSections.Add(tabTwoSectionOne);
    tabTwoSections.Add(tabTwoSectionTwo);
    tabTwoSections.Add(tabTwoSectionThree);
    tabTwoSections.Add(tabTwoSectionFour);

    #endregion

    #region Tab Three Sections

    List<Section> tabThreeSections = new List<Section>();
    Section tabThreeSectionOne = new Section();
    tabThreeSectionOne.title="Section One";
    tabThreeSectionOne.internalName="sectionOne";
    tabThreeSectionOne.titleHidden= false;
    tabThreeSectionOne.columnLayout=4;
    tabThreeSectionOne.collapsed= false;
    tabThreeSectionOne.fieldCollection = fields;
    tabThreeSectionOne.hidden = false;

    Section tabThreeSectionTwo = new Section();
    tabThreeSectionTwo.title="Section Two";
    tabThreeSectionTwo.internalName="sectionTwo";
    tabThreeSectionTwo.titleHidden= false;
    tabThreeSectionTwo.columnLayout=1;
    tabThreeSectionTwo.collapsed= false;
    tabThreeSectionTwo.fieldCollection = fields;
    tabThreeSectionTwo.hidden = false;

    tabThreeSections.Add(tabThreeSectionOne);
    tabThreeSections.Add(tabThreeSectionTwo);

    #endregion

    #region Tab Four Sections

    List<Section> tabFourSections = new List<Section>();
    Section tabFourSectionOne = new Section();
    tabFourSectionOne.title="Section One";
    tabFourSectionOne.internalName="sectionOne";
    tabFourSectionOne.titleHidden= false;
    tabFourSectionOne.columnLayout=3;
    tabFourSectionOne.collapsed= false;
    tabFourSectionOne.fieldCollection = fields;
    tabFourSectionOne.hidden = false;

    tabFourSections.Add(tabFourSectionOne);

    #endregion

    #endregion

    #region Tabs

    List<TabContentItem> contentTabs = new List<TabContentItem>();

    TabContentItem tabOne = new TabContentItem();
    tabOne.title="Tab One" ;
    tabOne.internalName="tabOne";
    tabOne.hidden = false;
    tabOne.titleHidden = false;
    tabOne.sectionCollection = tabOneSections;  

    TabContentItem tabTwo = new TabContentItem();
    tabTwo.title="Tab Two" ;
    tabTwo.internalName="tabTwo";
    tabTwo.hidden = true;
    tabTwo.titleHidden = false;
    tabTwo.sectionCollection = tabTwoSections;
    
    TabContentItem tabThree = new TabContentItem();
    tabThree.title="Tab Three" ;
    tabThree.internalName="tabThree";
    tabThree.hidden = false;
    tabThree.titleHidden = false;
    tabThree.sectionCollection = tabThreeSections;

    TabContentItem tabFour = new TabContentItem();
    tabFour.title="Tab Four" ;
    tabFour.internalName="tabFour";
    tabFour.hidden = false;
    tabFour.titleHidden = true;
    tabFour.sectionCollection = tabFourSections;
    
    contentTabs.Add(tabOne);
    contentTabs.Add(tabTwo);
    contentTabs.Add(tabThree);
    contentTabs.Add(tabFour);

    Tabs tabs = new Tabs();
    tabs.flattenTabs = false;
    tabs.tabDetails = contentTabs;

    #endregion

    #region Tab Actions

    List<TabActionItem> tabActionItems = new List<TabActionItem>();

    TabActionItem tabTwoAction = new TabActionItem();
    tabTwoAction.tabInternalName = "tabTwo";

    TabActionItem tabThreeAction = new TabActionItem();
    tabThreeAction.tabInternalName = "tabThree";

    TabActionItem tabFourAction = new TabActionItem();
    tabFourAction.tabInternalName = "tabFour";

    tabActionItems.Add(tabTwoAction);
    tabActionItems.Add(tabThreeAction);
    tabActionItems.Add(tabFourAction);

    TabAction tabConfirmAction = new TabAction();
    tabConfirmAction.title = "Confirm";
    tabConfirmAction.validation="";
    tabConfirmAction.triggerSave=true;
    tabConfirmAction.clickCall="";
    tabConfirmAction.clickCallMode="sync";
    tabConfirmAction.allTabs = false;
    tabConfirmAction.tabReference = tabActionItems;

    TabAction tabSaveAction = new TabAction();
    tabSaveAction.title = "Save";
    tabSaveAction.validation="";
    tabSaveAction.triggerSave=true;
    tabSaveAction.clickCall="";
    tabSaveAction.clickCallMode="sync";
    tabSaveAction.allTabs = true;

    TabAction tabCancelAction = new TabAction();
    tabCancelAction.title = "Cancel";
    tabCancelAction.validation="";
    tabCancelAction.triggerSave=false;
    tabCancelAction.clickCall="";
    tabCancelAction.clickCallMode="sync";
    tabCancelAction.allTabs = true;

    List<TabAction> tabActionsList = new List<TabAction>();
    tabActionsList.Add(tabSaveAction);
    tabActionsList.Add(tabCancelAction);
    tabActionsList.Add(tabConfirmAction);

    TabActions tabActions = new TabActions();
    tabActions.actions = tabActionsList;

    #endregion

    FormDefintionOverview fd = new  FormDefintionOverview();
    fd.client = "Test Client";
    fd.internalName="field_internal_name";
    fd.name="field name";
    fd.tabs = tabs;
    fd.tabActions = tabActions;
        
    return JsonConvert.SerializeObject(fd);
    }
}