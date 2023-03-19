
while(true) {
    ﻿System.Console.WriteLine("enter domain name:");
    var address = System.Console.ReadLine()!;
    var ipv4address = (await System.Net.Dns.GetHostAddressesAsync(address,System.Net.Sockets.AddressFamily.InterNetwork)).FirstOrDefault();
    var ipv6address = (await System.Net.Dns.GetHostAddressesAsync(address,System.Net.Sockets.AddressFamily.InterNetworkV6)).FirstOrDefault();
    System.Console.WriteLine($"ipv4:{ipv4} ipv6:{ipv6}");
    //System.Console.WriteLine($"v4:{ipv4}");
}
