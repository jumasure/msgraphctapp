using Newtonsoft.Json;
using System;

namespace msgraphapp.Models
{
   
    public class ResourceData
    {
  [JsonProperty(PropertyName="id")]
        public string Id{get;set;}

         [JsonProperty(PropertyName="@odata.etag")]
        public string ODataEtag{get;set;}

         [JsonProperty(PropertyName="@odata.id")]
        public string ODataId{get;set;}


         [JsonProperty(PropertyName="@odata.type")]
        public string SubscriptionId{get;set;}

        [JsonProperty(PropertyName="resourceData")]
        public string OdataType{get;set;}

    }
}