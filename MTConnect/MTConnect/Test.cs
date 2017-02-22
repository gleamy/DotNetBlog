using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTConnectDevices = MTConnect.MTConnectDevices;
using MTConnectStreams = MTConnect.MTConnectStreams;
using MTConnect.Clients;

namespace MTConnect
{
    class Test
    {

        MTConnectClient client;

        public void Start()
        {
            // The base address for the MTConnect Agent
            string baseUrl = "http://agent.mtconnect.org";
            // The base address for the MTConnect Agent
            //string baseUrl = "http://74.203.109.245:5001";

            // Execute the Current request and get an MTConnectStreams.Document object back
            var current = new Current(baseUrl).Execute();
            Console.WriteLine(current);

            var sample = new Sample(baseUrl, 200, 500).Execute();

            Console.WriteLine(current);

            // Execute the Probe request asynchronously and return the MTConnectDevices.Document using the event handler
            var probe = new Probe(baseUrl);
            //probe.Successful += Probe_Successful;
            //probe.ExecuteAsync();

            Console.WriteLine(probe);


            // Create a new MTConnectClient using the baseUrl
            client = new MTConnectClient(baseUrl, "VMC-3Axis");
            ///client.Interval = 1000;

            // Subscribe to the Event handlers to receive the MTConnect documents
            client.ProbeReceived += DevicesSuccessful;
            client.CurrentReceived += StreamsSuccessful;
            client.SampleReceived += StreamsSuccessful;

            // Start the MTConnectClient
            client.Start();
        }

        private void Probe_Successful(MTConnectDevices.Document document)
        {
            foreach (var device in document.Devices)
            {
                var dataItems = device.GetDataItems();
                foreach (var dataItem in dataItems) Console.WriteLine(dataItem.Id + " : " + dataItem.Name);
            }
        }

        void Stop()
        {
            client.Stop();
        }

        // --- Event Handlers ---

        void DevicesSuccessful(MTConnectDevices.Document document)
        {
            foreach (var device in document.Devices)
            {
                var dataItems = device.GetDataItems();
                foreach (var dataItem in dataItems) Console.WriteLine(dataItem.Id + " : " + dataItem.Name);
            }
        }

        void StreamsSuccessful(MTConnectStreams.Document document)
        {
            foreach (var deviceStream in document.DeviceStreams)
            {
                foreach (var dataItem in deviceStream.DataItems)
                    
                    Console.WriteLine(dataItem.Timestamp + " - " + dataItem.DataItemId + " = " + dataItem.CDATA);
            }
        }
    }
}
