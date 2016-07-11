using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace spt103portal
{
	public class TodoItem
	{
		string id;
		string name;
	    string assignedto;
	    string emailaddr;
		bool done;

		[JsonProperty(PropertyName = "id")]
		public string Id
		{
			get { return id; }
			set { id = value;}
		}

		[JsonProperty(PropertyName = "text")]
		public string Name
		{
			get { return name; }
			set { name = value;}
		}

        [JsonProperty(PropertyName = "assignedto")]
        public string AssignedTo
        {
            get { return assignedto; }
            set { assignedto = value; }
        }

        [JsonProperty(PropertyName = "emailaddr")]
        public string EmailAddr
        {
            get { return emailaddr; }
            set { emailaddr = value; }
        }

        [JsonProperty(PropertyName = "complete")]
		public bool Done
		{
			get { return done; }
			set { done = value;}
		}

        [Version]
        public string Version { get; set; }
	}
}

