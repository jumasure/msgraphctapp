using Newtonsoft.Json;
using System;

namespace msgraphapp.Models
{
    public class Notifications
    {
        [JsonProperty(PropertyName="value")]
        public Notification[] items{get;set;}
    }

    // A change Notification
    public class Notification
    {

        
        [JsonProperty(PropertyName="changeType")]
        public string ChangeType{get;set;}

         [JsonProperty(PropertyName="clientState")]
        public string ClientState{get;set;}

         [JsonProperty(PropertyName="resource")]
        public string Resource{get;set;}

         [JsonProperty(PropertyName="subscriptionExpirationDateTime")]
        public DateTimeOffset SubscriptionExpirationDateTime{get;set;}

         [JsonProperty(PropertyName="subscriptionId")]
        public string SubscriptionId{get;set;}

        [JsonProperty(PropertyName="resourceData")]
        public string ResourceData{get;set;}

    }
}