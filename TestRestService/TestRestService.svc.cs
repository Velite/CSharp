using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using Newtonsoft.Json;

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

		[OperationContract]
		[WebGet(UriTemplate = "/Items", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
		public string GetItems()
		{
			List<TestItem> items = new List<TestItem>
			{
				new TestItem
				{
					Id = 1,
					Created = DateTime.Now,
					Comment = "Test 1"
				},
				new TestItem
				{
					Id = 2,
					Created = DateTime.Now.AddDays(-1),
					Comment = "Test 2"
				},
				new TestItem
				{
					Id = 3,
					Created = DateTime.Now.AddDays(-2),
					Comment = "Test 3"
				}
			};

			return JsonConvert.SerializeObject(items);
		}

		[OperationContract]
		[WebGet(UriTemplate = "/Item/{id}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
		public string GetItemById(string id)
		{
			List<TestItem> items = new List<TestItem>
			{
				new TestItem
				{
					Id = 1,
					Created = DateTime.Now,
					Comment = "Test 1"
				},
				new TestItem
				{
					Id = 2,
					Created = DateTime.Now.AddDays(-1),
					Comment = "Test 2"
				},
				new TestItem
				{
					Id = 3,
					Created = DateTime.Now.AddDays(-2),
					Comment = "Test 3"
				}
			};

			int realId = int.Parse(id);

			return realId > 0 ? JsonConvert.SerializeObject(items.AsParallel().Where(i => i.Id == realId)) : "{Ошибка: \"Значение Id < 0\"}";
		}
	}

	public sealed class TestItem
	{
		public int Id { get; set; }
		public DateTime Created { get; set; }
		public string Comment { get; set; }
	}
}