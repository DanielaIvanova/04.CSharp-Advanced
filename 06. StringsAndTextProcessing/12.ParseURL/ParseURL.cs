using System;

class ParseURL
{
    static void Main()
    {
        //[protocol]://[server]/[resource]

        string address = Console.ReadLine();

        int indexOfProtocol = address.IndexOf("://");
        string protocol = address.Substring(0, indexOfProtocol);

        int indexOfServerStart = indexOfProtocol + 3;
        int indexOfServerEnd = address.IndexOf("/", indexOfServerStart);
        string server = address.Substring(indexOfServerStart, indexOfServerEnd - indexOfServerStart);

        string resource = address.Substring(indexOfServerEnd);


        Console.WriteLine("[protocol] = {0}",protocol);
        Console.WriteLine("[server] = {0}",server);
        Console.WriteLine("[resource] = {0}",resource);


        
    }
}
