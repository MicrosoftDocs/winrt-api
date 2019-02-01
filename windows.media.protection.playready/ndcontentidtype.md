---
-api-id: T:Windows.Media.Protection.PlayReady.NDContentIDType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Protection.PlayReady.NDContentIDType : int
-->

# NDContentIDType

## -description
Indicates the types of content that PlayReady can use in different scenarios.

## -enum-fields
### -field KeyID:1
License key identifier.

### -field PlayReadyObject:2
**PlayReadyObject** can be one of the following two objects.


+ A full PlayReady Object (PRO), which is a binary format defined by PlayReady.
+ A raw XML WRMHeader.
Both of these types of objects are described in the *Supporting In-Home Content Distribution with PlayReady for Network Devices* document located on the [Microsoft PlayReady Documents](https://www.microsoft.com/PlayReady/documents/) Web page.

### -field Custom:3
Custom object specific to the transmitter. It is expected that the transmitter will understand the data contained therein. PlayReady does not define a standard format for custom content identifiers.


## -remarks

## -examples

## -see-also