#load "FormDefinitionExamples\RaySampleForm.csx"
#load "FormDefinitionExamples\HS_OperationalChange.csx"

using System;
using System.Net;
using Newtonsoft.Json;

private static readonly string ADMIN_USER_CONFIG_KEY = "SharePointAdminUser";
private static readonly string ADMIN_PASSWORD_CONFIG_KEY = "SharePointAdminPassword";

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("GetPerForm-FormSchemaV1 processed a request.");

    RaySampleForm formTwo = new RaySampleForm();
    var formTwoFieldJSON = formTwo.GetFormJson();

    HS_OperationalChange formOne = new HS_OperationalChange();
    var formOneFieldJSON =formOne.GetFormJson();    

    log.Info("GetPerForm-FormSchemaV1 JSON is "+ formOneFieldJSON);

    return req.CreateResponse(HttpStatusCode.OK,  formOneFieldJSON);
}
















