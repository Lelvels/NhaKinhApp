using Azure.Messaging.EventHubs.Consumer;
using CommandLine;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;

namespace MainMenu2
{
    public partial class Form1 : Form
    {
        private Parameters _parameters;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _parameters = new Parameters();
            BeginListening();
        }

        private async Task BeginListening()
        {
            using var cts = new CancellationTokenSource();

            // Run the sample
            await ReceiveMessagesFromDeviceAsync(cts.Token);
        }

        private async Task ReceiveMessagesFromDeviceAsync(CancellationToken ct)
        {
            StatusLabel.Text = "Starting listening";
            string connectionString = "Endpoint=sb://ihsuprodsgres009dednamespace.servicebus.windows.net/;SharedAccessKeyName=iothubowner;SharedAccessKey=V8qIEwqJ2WUjMq8cQBP+s6IX47icOMqdHjI210v9KJQ=;EntityPath=iothub-ehub-nha-kinh-i-18331173-02ded39cc1";
            await using var consumer = new EventHubConsumerClient(
                EventHubConsumerClient.DefaultConsumerGroupName,
                connectionString,
                "iothub-ehub-nha-kinh-i-18331173-02ded39cc1");

            Console.WriteLine("Listening for messages on all partitions.");

            try
            {
                // Begin reading events for all partitions, starting with the first event in each partition and waiting indefinitely for
                // events to become available. Reading can be canceled by breaking out of the loop when an event is processed or by
                // signaling the cancellation token.
                //
                // The "ReadEventsAsync" method on the consumer is a good starting point for consuming events for prototypes
                // and samples. For real-world production scenarios, it is strongly recommended that you consider using the
                // "EventProcessorClient" from the "Azure.Messaging.EventHubs.Processor" package.
                //
                // More information on the "EventProcessorClient" and its benefits can be found here:
                //   https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/eventhub/Azure.Messaging.EventHubs.Processor/README.md
                await foreach (PartitionEvent partitionEvent in consumer.ReadEventsAsync(ct))
                {
                    string data = Encoding.UTF8.GetString(partitionEvent.Data.Body.ToArray());
                    StatusLabel.Text = "Data received from iot hub, displaying";
                    Receive1_txt.Text = data;
                    ReportedData? reportedData = JsonSerializer.Deserialize<ReportedData>(data);
                    MessageId_txt.Text = $"{reportedData?.MessageId}";
                    Temperature_txt.Text = $"{reportedData?.Temperature}";
                    Humidity_txt.Text = $"{reportedData?.Humidity}";
                    CO2_txt.Text = $"{reportedData?.CO2}";
                    SM_txt.Text = $"{reportedData?.SoilMoisture}";
                    foreach (KeyValuePair<string, object> prop in partitionEvent.Data.SystemProperties)
                    {
                        Receive2_txt.Text = prop.Value.ToString();
                    }
                }
            }
            catch (TaskCanceledException)
            {
                // This is expected when the token is signaled; it should not be considered an
                // error in this scenario.
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}