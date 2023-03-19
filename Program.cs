
while(true) {
    ﻿System.Console.WriteLine("enter domain name:");
    var address = System.Console.ReadLine()!;
    var ipv4 = (await System.Net.Dns.GetHostAddressesAsync(address,System.Net.Sockets.AddressFamily.InterNetwork)).FirstOrDefault();
    var ipv6 = (await System.Net.Dns.GetHostAddressesAsync(address,System.Net.Sockets.AddressFamily.InterNetworkV6)).FirstOrDefault();
    System.Console.WriteLine($"v4:{ipv4} v6:{ipv6}");
}
