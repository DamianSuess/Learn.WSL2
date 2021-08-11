# Fix WSL 2 Network Connectivity

Unable to run `sudo apt update`? Try this out.

## Add Firewall Rules

First, search network adapters

Next, Add firewall rules

```powershell
New-NetFirewallRule -DisplayName "WSL" -Direction Inbound  -InterfaceAlias "vEthernet (WSL)"  -Action Allow
New-NetFirewallRule -DisplayName "WSL" -Direction Outbound -InterfaceAlias "vEthernet (WSL)"  -Action Allow
```

## TEST

## Ping by IP but not Name

This is because the nameserver is set to an internal wsl proxy nameserver used to resolve the Hyper-V private internal network.

The issue has to do with the /etc/resolv.conf pointing to the wrong name server, not so much wrong, but the proxy nameserver that does not seem to resolv local network hostnames

A simple test goes as follows:

1. Test pinging Google
   1. ping 8.8.8.8
   2. ping 172.217.2.110
   3. ping google.com
2. If you're able to ping by IP, continue reading.



### Cisco AnyConnect

1. Open, Cisco Any Connect, go to Settings.
2. Click, Preferences.
3. Check, "Allow local (LAN) access when using VPN (if configured).

### References
* [https://colhountech.com/2021/04/01/wsl2-ubuntu-ping-hostname-temporary-failure-in-name-resolution/]
* [Reference](https://github.com/microsoft/WSL/issues/4277#issuecomment-891683842)

## Resources

* [https://github.com/microsoft/WSL/issues/4277]
* [https://docs.microsoft.com/en-us/windows/wsl/troubleshooting#bash-loses-network-connectivity-once-connected-to-a-vpn]
