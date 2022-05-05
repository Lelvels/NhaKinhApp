using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu2
{
    internal class Parameters
    {
        internal const string IotHubSharedAccessKeyName = "service";
        public string EventHubCompatibleEndpoint { get; set; }
        public string EventHubName { get; set; }
        public string SharedAccessKey { get; set; }
        public string EventHubConnectionString { get; set; }

        public string GetEventHubConnectionString()
        {
            //return EventHubConnectionString ?? $"Endpoint={EventHubCompatibleEndpoint};SharedAccessKeyName={IotHubSharedAccessKeyName};SharedAccessKey={SharedAccessKey}";
            return "Endpoint=sb://ihsuprodsgres009dednamespace.servicebus.windows.net/;SharedAccessKeyName=iothubowner;SharedAccessKey=V8qIEwqJ2WUjMq8cQBP+s6IX47icOMqdHjI210v9KJQ=;EntityPath=iothub-ehub-nha-kinh-i-18331173-02ded39cc1";
        }
    }
}
