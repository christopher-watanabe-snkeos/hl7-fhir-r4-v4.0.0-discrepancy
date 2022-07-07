using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;

var pocoStructureDefinitionProvider = new PocoStructureDefinitionSummaryProvider();

// Attempt to turn the DeviceComponent json data into a R4 TypedElement representation does not work!
string deviceComponentJsonContent = File.ReadAllText("data/DeviceComponent.json");
try
{
  var deviceComponentTypedElement = FhirJsonNode.Parse(deviceComponentJsonContent).ToTypedElement(pocoStructureDefinitionProvider);
}
catch 
{
  Console.WriteLine("Error thrown when parsing DeviceComponent to TypedElement!");
}

// Attempt to turn the ProcessRequest json data into a R4 TypedElement representation works!
string processRequestJsonContent = File.ReadAllText("data/ProcessRequest.json");
try
{
  var processRequestTypedElement = FhirJsonNode.Parse(processRequestJsonContent).ToTypedElement(pocoStructureDefinitionProvider);
}
catch
{
  Console.WriteLine("Error thrown when parsing ProcessRequest to TypedElement!");
}

// Attempt to turn the ProcessResponse json data into a R4 TypedElement representation works!
string processResponseJsonContent = File.ReadAllText("data/ProcessResponse.json");
try
{
  var typedElement = FhirJsonNode.Parse(processResponseJsonContent).ToTypedElement(pocoStructureDefinitionProvider);
}
catch
{
  Console.WriteLine("Error thrown when parsing ProcessResponse to TypedElement!");
}

