---
-api-id: M:Windows.ApplicationModel.Calls.PhoneLine.Dial(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public void Dial(System.String number, System.String displayName)
-->

# Windows.ApplicationModel.Calls.PhoneLine.Dial

## -description
Place a phone call on the phone line. The caller must be in the foreground.

## -parameters
### -param number
The number to dial.

### -param displayName
The display name of the party receiving the phone call. This parameter is optional.

## -remarks
In order to use this method, the [PhoneLine](phoneline.md) instance needs to support outbound calls. Use [CanDial](phoneline_candial.md) to verify whether or not that is supported.

## -examples

## -see-also
