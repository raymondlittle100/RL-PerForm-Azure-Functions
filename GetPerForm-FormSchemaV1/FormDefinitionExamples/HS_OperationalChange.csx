using Newtonsoft.Json;
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

    List<Field> tabOneSectionOneFields = new List<Field>();
    List<Field> tabOneSectionTwoFields = new List<Field>();

    #region Tab One Section One Fields 

    var fieldOne = new Field();
    fieldOne.type = "multiline";
    fieldOne.hidden = false;
    fieldOne.dataMapping = "OpChange_Overview";
    fieldOne.label = "Overview";
    fieldOne.showLabel = true;
    fieldOne.required = true;
    fieldOne.readOnly = false;
    fieldOne.showDescription = false;
    fieldOne.description = "Please supply your overview";
    fieldOne.cssClass = "overview";
    fieldOne.maxLength = 300;

    var fieldTwo = new Field();
    fieldTwo.type = "metadata";
    fieldTwo.hidden = false;
    fieldTwo.dataMapping = "OpChange_ProdSite";
    fieldTwo.label = "Production Site";
    fieldTwo.showLabel = true;
    fieldTwo.required = true;
    fieldTwo.readOnly = false;
    fieldTwo.showDescription = false;
    fieldTwo.description = "Please supply the production site";
    fieldTwo.cssClass = "productionSite";   

    var fieldThree = new Field();
    fieldThree.type = "text";
    fieldThree.hidden = false;
    fieldThree.dataMapping = "OpChange_ItemCodes";
    fieldThree.label = "Item Code(s) Affected";
    fieldThree.showLabel = true;
    fieldThree.required = true;
    fieldThree.readOnly = false;
    fieldThree.showDescription = false;
    fieldThree.description = "Please supply the item codes affected";
    fieldThree.cssClass = "itemCodes";  
    fieldThree.maxLength = 255;

    var fieldFour  = new Field();
    fieldFour.type = "user";
    fieldFour.hidden = false;
    fieldFour.dataMapping = "OpChange_ProcessedBy";
    fieldFour.label = "Processed By";
    fieldFour.showLabel = true;
    fieldFour.required = true;
    fieldFour.readOnly = false;
    fieldFour.showDescription = false;
    fieldFour.description = "Please supply the processed by user";
    fieldFour.cssClass = "processedBy";

    var fieldFive  = new Field();
    fieldFive.type = "date";
    fieldFive.hidden = false;
    fieldFive.dataMapping = "OpChange_ProposalDate";
    fieldFive.label = "Date of Proposal";
    fieldFive.showLabel = true;
    fieldFive.required = true;
    fieldFive.readOnly = false;
    fieldFive.showDescription = false;
    fieldFive.description = "Please supply the date of the proposal";
    fieldFive.cssClass = "dateProposal";

    var fieldSix = new Field();
    fieldSix.type = "date";
    fieldSix.hidden = false;
    fieldSix.dataMapping = "OpChange_ProposalDateImpl";
    fieldSix.label = "Proposal Date of Implmentation";
    fieldSix.showLabel = true;
    fieldSix.required = true;
    fieldSix.readOnly = false;
    fieldSix.showDescription = false;
    fieldSix.description = "Please supply the proposal date of implementation";
    fieldSix.cssClass = "proposalDateImplmentation";
    
    tabOneSectionOneFields.Add(fieldOne);
    tabOneSectionOneFields.Add(fieldTwo);
    tabOneSectionOneFields.Add(fieldThree);
    tabOneSectionOneFields.Add(fieldFour);
    tabOneSectionOneFields.Add(fieldFive);
    tabOneSectionOneFields.Add(fieldSix);
    
    #endregion Tab One Section One Fields 

    #region Tab One Section Two Fields 

    var fieldSeven = new Field();
    fieldSeven.type = "metadata";
    fieldSeven.hidden = false;
    fieldSeven.dataMapping = "OpChange_ProposalChange";
    fieldSeven.label = "Proposal Change";
    fieldSeven.showLabel = true;
    fieldSeven.required = true;
    fieldSeven.readOnly = false;
    fieldSeven.showDescription = false;
    fieldSeven.description = "Please supply the proposed change";
    fieldSeven.cssClass = "proposedChange";

    var fieldEight = new Field();
    fieldEight.type = "multiline";
    fieldEight.hidden = false;
    fieldEight.dataMapping = "OpChange_ChangeFrom";
    fieldEight.label = "Change from";
    fieldEight.showLabel = true;
    fieldEight.required = true;
    fieldEight.readOnly = false;
    fieldEight.showDescription = false;
    fieldEight.description = "Please supply the change from";
    fieldEight.cssClass = "changeFrom";

    var fieldNine = new Field();
    fieldNine.type = "multiline";
    fieldNine.hidden = false;
    fieldNine.dataMapping = "OpChange_ChangeTo";
    fieldNine.label = "Change to";
    fieldNine.showLabel = true;
    fieldNine.required = true;
    fieldNine.readOnly = false;
    fieldNine.showDescription = false;
    fieldNine.description = "Please supply the change to";
    fieldNine.cssClass = "changeTo";

    var fieldTen = new Field();
    fieldTen.type = "multiline";
    fieldTen.hidden = false;
    fieldTen.dataMapping = "OpChange_ReasonChange";
    fieldTen.label = "Reason for change";
    fieldTen.showLabel = true;
    fieldTen.required = true;
    fieldTen.readOnly = false;
    fieldTen.showDescription = false;
    fieldTen.description = "Please supply the reason for change";
    fieldTen.cssClass = "reasonForChange";   

    var fieldEleven = new Field();
    fieldEleven.type = "multiline";
    fieldEleven.hidden = false;
    fieldEleven.dataMapping = "OpChange_BenefitChange";
    fieldEleven.label = "Benefit of change";
    fieldEleven.showLabel = true;
    fieldEleven.required = true;
    fieldEleven.readOnly = false;
    fieldEleven.showDescription = false;
    fieldEleven.description = "Please supply the benefit of the change";
    fieldEleven.cssClass = "benefitOfChange";  

    var fieldTweleve = new Field();
    fieldTweleve.type = "multiline";
    fieldTweleve.hidden = false;
    fieldTweleve.dataMapping = "OpChange_NegativeImpact";
    fieldTweleve.label = "Negative Impact of change";
    fieldTweleve.showLabel = true;
    fieldTweleve.required = true;
    fieldTweleve.readOnly = false;
    fieldTweleve.showDescription = false;
    fieldTweleve.description = "Please supply the negative impact of the change";
    fieldTweleve.cssClass = "negativeImpactOfChange";  

    var fieldThirteen = new Field();
    fieldThirteen.type = "currency";
    fieldThirteen.hidden = false;
    fieldThirteen.dataMapping = "OpChange_CostChange";
    fieldThirteen.label = "Cost of change";
    fieldThirteen.showLabel = true;
    fieldThirteen.required = true;
    fieldThirteen.readOnly = false;
    fieldThirteen.showDescription = false;
    fieldThirteen.description = "Please supply the cost of the  change";
    fieldThirteen.cssClass = "costOfChange"; 
    fieldThirteen.maxLength = 255;

    var fieldFourteen = new Field();
    fieldFourteen.type = "currency";
    fieldFourteen.hidden = false;
    fieldFourteen.dataMapping = "OpChange_CoveringCost";
    fieldFourteen.label = "Who is covering the cost?";
    fieldFourteen.showLabel = true;
    fieldFourteen.required = true;
    fieldFourteen.readOnly = false;
    fieldFourteen.showDescription = false;
    fieldFourteen.description = "Please supply who is covering the cost of the change";
    fieldFourteen.cssClass = "coveringCost";        

    tabOneSectionTwoFields.Add(fieldSeven);
    tabOneSectionTwoFields.Add(fieldEigth);
    tabOneSectionTwoFields.Add(fieldNine);
    tabOneSectionTwoFields.Add(fieldTen);
    tabOneSectionTwoFields.Add(fieldEleven);
    tabOneSectionTwoFields.Add(fieldTweleve);
    tabOneSectionTwoFields.Add(fieldThirteen);
    tabOneSectionTwoFields.Add(fieldFourteen);

    #endregion

    #region Sections

    #region Tab One Sections

    List<Section> tabOneSections = new List<Section>();
    Section tabOneSectionOne = new Section();
    tabOneSectionOne.title="Change Background";
    tabOneSectionOne.internalName="changeBackground";
    tabOneSectionOne.titleHidden= false;
    tabOneSectionOne.columnLayout=1;
    tabOneSectionOne.collapsed= false;
    tabOneSectionOne.fieldCollection = tabOneSectionOneFields;
    tabOneSectionOne.hidden = false;

    Section tabOneSectionTwo = new Section();
    tabOneSectionTwo.title="Change Specific";
    tabOneSectionTwo.internalName="changeSpecific";
    tabOneSectionTwo.titleHidden= false;
    tabOneSectionTwo.columnLayout=1;
    tabOneSectionTwo.collapsed= false;
    tabOneSectionTwo.fieldCollection = tabOneSectionTwoFields;
    tabOneSectionTwo.hidden = false;

    tabOneSections.Add(tabOneSectionOne);
    tabOneSections.Add(tabOneSectionTwo);

    #endregion

    #endregion

    #region Tabs

    List<TabContentItem> contentTabs = new List<TabContentItem>();

    TabContentItem tabOne = new TabContentItem();
    tabOne.title="New Project Proposal" ;
    tabOne.internalName="newProjectProposal";
    tabOne.hidden = false;
    tabOne.titleHidden = false;
    tabOne.sectionCollection = tabOneSections;  
    
    contentTabs.Add(tabOne);
 
    Tabs tabs = new Tabs();
    tabs.flattenTabs = false;
    tabs.tabDetails = contentTabs;

    #endregion

    #region Tab Actions

    TabAction tabSubmitAction = new TabAction();
    tabSubmitAction.title = "Submit";
    tabSubmitAction.validation="";
    tabSubmitAction.triggerSave=true;
    tabSubmitAction.clickCall="";
    tabSubmitAction.clickCallMode="sync";
    tabSubmitAction.allTabs = true;

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
    tabActionsList.Add(tabSubmitAction);
    tabActionsList.Add(tabSaveAction);
    tabActionsList.Add(tabCancelAction);   

    TabActions tabActions = new TabActions();
    tabActions.actions = tabActionsList;

    #endregion

    FormDefintionOverview fd = new  FormDefintionOverview();
    fd.client = "Highland Spring";
    fd.internalName="NewOperationalChange";
    fd.name="Operational Change";
    fd.tabs = tabs;
    fd.tabActions = tabActions;
        
    return JsonConvert.SerializeObject(fd);
    }
}