---
-api-id: P:Windows.Networking.Connectivity.CellularApnContext.AuthenticationType
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Connectivity.CellularApnAuthenticationType AuthenticationType { get;  set; }
-->

# Windows.Networking.Connectivity.CellularApnContext.AuthenticationType

## -description
Indicates the authentication method, as defined by [CellularApnAuthenticationType](cellularapnauthenticationtype.md), that is used by the access point.

## -property-value
The authentication type.

## -remarks
This property can have one of the following values:<table>
   <tr><th>Value</th><th>Description</th></tr>
   <tr><td>NONE</td><td>No authentication protocol.</td></tr>
   <tr><td>PAP</td><td>Unencrypted password authentication.</td></tr>
   <tr><td>CHAP</td><td>Challenge Handshake Authentication Protocol(CHAP).</td></tr>
   <tr><td>MsCHAPv2</td><td>Use Microsoft’s Challenge Handshake Authentication Protocol(CHAP) v2.0.</td></tr>
</table>

## -examples

## -see-also
