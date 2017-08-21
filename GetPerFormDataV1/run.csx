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

    var fieldFour = new FieldDetails();
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

  var fieldOne = new FieldDetails();
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
   
  var fieldTwo = new FieldDetails();
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
   
  var fieldThree = new FieldDetails();
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