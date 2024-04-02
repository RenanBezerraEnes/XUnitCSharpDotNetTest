namespace XUnitCSharpDotNetTest.Ping
{
    public class NetworkService
    {
        public string SendPing()
        {
            return "SUCCESS: Ping Sent";
        }

        public int PingTimeOut(int a, int b)
        {
            return a + b;
        }
    }
}
