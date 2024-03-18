using System.Net.NetworkInformation;
using System.Text;

// Pinging Google DNS Server 4.2.2.2
// Followed Teddy Smiths tutorial
// https://www.youtube.com/watch?v=mHf0suaB8aQ&list=PL82C6-O4XrHfoN_Y4MwGvJz5BntiL0z0D&index=7

Ping pingSender = new Ping();
PingOptions options = new PingOptions();

options.DontFragment = true;

string data = "Learn to code";
byte[] buffer = Encoding.ASCII.GetBytes(data);
int timeout = 120;
string address = "4.2.2.2";
PingReply reply = pingSender.Send(address, timeout, buffer, options);
if (reply.Status == IPStatus.Success)
{
    Console.WriteLine("Response: {0}", reply.Status.ToString());
    Console.WriteLine("RoundTrip: {0}", reply.RoundtripTime);
    Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
    Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
}