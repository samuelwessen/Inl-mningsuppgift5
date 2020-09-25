using Microsoft.Azure.Devices.Client;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DeviceApp.Tests
{
    public class SetTelemetryIntervalTests
    {
        private DeviceClient deviceClient = DeviceClient.CreateFromConnectionString("HostName=ec-win20-samuelw-iothub.azure-devices.net;DeviceId=inlamningsuppgift5test;SharedAccessKey=lrBGEWyZ7/W3JdK8HTsEBr/QA05nbnPlnrg3CX4tr+s=", TransportType.Mqtt);

        public SetTelemetryIntervalTests()
        {

        }


        [Theory]
        [InlineData("SetTelemetryInterval","10", 200)]
        public void SetTelemetryInterval_ShouldChangeTheInterval(string methodName, string payload, int statusCode)
        {
            deviceClient.SetMethodHandlerAsync(methodName, SetTelemetryInterval, null).Wait();
            Assert.Contains(methodName, payload, statusCode);
        }

        public Task<MethodResponse> SetTelemetryInterval(MethodRequest methodRequest, object userContext)
        {
            throw new NotImplementedException();
        }
    }
}
