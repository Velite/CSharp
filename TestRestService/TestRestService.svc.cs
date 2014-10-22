using System;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace TestRestService
{
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	[ServiceContract]
	public class TestRestService
	{
		[OperationContract]
		[WebGet(UriTemplate = "/", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
		public string Hello()
		{
			return string.Format("Hello world!");
		}

		[OperationContract]
		[WebGet(UriTemplate = "/{name}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
		public string HelloName(string name)
		{
			return string.Format("Hello: {0}", !string.IsNullOrWhiteSpace(name) ? name : "Anonymouse");
		}
	}

	public sealed class TestItem
	{
		public int Id { get; set; }
		public DateTime Created { get; set; }
		public string Comment { get; set; }
	}
}