using System;
using System.Net;
using Newtonsoft.Json;

private static readonly string ADMIN_USER_CONFIG_KEY = "SharePointAdminUser";
private static readonly string ADMIN_PASSWORD_CONFIG_KEY = "SharePointAdminPassword";

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("C# HTTP trigger function processed a request.");

    var fieldJSON = GetJson();

    return req.CreateResponse(HttpStatusCode.OK,  fieldJSON);
}

public static string GetJson() 
{
    List<FieldDetails> fields = new List<FieldDetails>();
  var fieldOne = new FieldDetails();
  fieldOne.type = "input";
  fieldOne.content = "Raymond";
  fieldOne.dataMapping = "FirstName";
  fieldOne.label = "First Name";
  fieldOne.showLabel = true;
  fieldOne.required = true;
  fieldOne.readOnly = true;
  fieldOne.showDescription = false;
  fieldOne.description = "Please supply your first name";
  fieldOne.cssClass = "firstName";
  fieldOne.maxLength = 50;

    fields.Add(fieldOne);
  return JsonConvert.SerializeObject(fields);
}

public class FieldDetails 
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