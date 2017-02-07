---
-api-id: T:Windows.Media.Protection.PlayReady.PlayReadyDecryptorSetup
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Protection.PlayReady.PlayReadyDecryptorSetup : int
-->

# PlayReadyDecryptorSetup

## -description
Defines decryptor setup requirements indicating when to acquire licenses for the content.

## -enum-fields
### -field Uninitialized:0
Indicates the DECRYPTORSETUP is not present in the rights management header. This indicates that a player app can guarantee that the license (chain) for the content is available prior to setting up the media graph.

### -field OnDemand:1
Indicates that a player app cannot guarantee that the license (chain) for the content is available prior to setting up the media graph.


## -remarks

## -examples

## -see-also