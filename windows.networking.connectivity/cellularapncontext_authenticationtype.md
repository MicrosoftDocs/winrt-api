---
-api-id: P:Windows.Networking.Connectivity.CellularApnContext.AuthenticationType
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Connectivity.CellularApnAuthenticationType AuthenticationType { get;  set; }
-->

# Windows.Networking.Connectivity.CellularApnContext.AuthenticationType

## -description
Specifies the APN authentication method (see [CellularApnAuthenticationType](cellularapnauthenticationtype.md)).

## -property-value
A [CellularApnAuthenticationType](cellularapnauthenticationtype.md) value indicating the protocol used; defaults to **None** if not set.

## -remarks
### Supported values
| Value | Meaning |
| -- | -- |
| None | No authentication (open / default APN) |
| Pap | Password Authentication Protocol (cleartext password exchange) |
| Chap | Challenge Handshake Authentication Protocol (shared secret challenge) |
| Mschapv2 | Microsoft CHAP v2 (mutual authentication improvements over CHAP) |

### Guidance
- Use the minimal required method published by the carrier; stronger methods are not always accepted.
- Provide **UserName** / **Password** only when the authentication type requires them (avoid sending empty credentials).
- Do not downgrade automatically (e.g., from MSCHAPv2 to PAP) without explicit user/carrier guidance.

### Security considerations
| Method | Relative security | Notes |
| -- | -- | -- |
| None | Lowest | Suitable only for carrier plans that mandate unauthenticated APN |
| Pap | Low | Cleartext password (inside lower-layer encryption if present) |
| Chap | Moderate | Challenge/response avoids sending password directly |
| Mschapv2 | Higher | Mutual auth aspects; still rely on secure transport for confidentiality |

> [!NOTE]  
> Even with an authentication method set, transport encryption of user payloads (TLS / VPN) is still recommended.


## -examples

## -see-also
