#load "FormDefinitionExamples\RaySampleForm.csx"
#load "..\FormDefintionOverview\FieldDetails.csx"
#load "..\FormDefintionOverview\Section.csx"
#load "..\FormDefintionOverview\TabContent.csx"
#load "..\FormDefintionOverview\TabContentItem.csx"
#load "..\FormDefintionOverview\Tabs.csx"
#load "..\FormDefintionOverview\TabActionItem.csx"
#load "..\FormDefintionOverview\TabAction.csx"
#load "..\FormDefintionOverview\TabActions.csx"
#load "..\FormDefintionOverview\FormDefintionOverview.csx"

using System;
using System.Net;
using Newtonsoft.Json;

private static readonly string ADMIN_USER_CONFIG_KEY = "SharePointAdminUser";
private static readonly string ADMIN_PASSWORD_CONFIG_KEY = "SharePointAdminPassword";

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("GetPerForm-FormSchemaV1 processed a request.");

    RaySampleForm formOne = new RaySampleForm();
    var fieldJSON =formOne.GetFormJson();    

    log.Info("GetPerForm-FormSchemaV1 JSON is "+ fieldJSON);

    return req.CreateResponse(HttpStatusCode.OK,  fieldJSON);
}
















