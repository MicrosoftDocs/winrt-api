---
-api-id: M:Windows.Foundation.Metadata.ApiInformation.IsEventPresent(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool IsEventPresent(System.String typeName, System.String eventName)
-->

# Windows.Foundation.Metadata.ApiInformation.IsEventPresent

## -description
Returns true or false to indicate whether a specified event is present for a specified type.

## -parameters
### -param typeName
The namespace-qualified name of the type.

### -param eventName
The name of the event.

## -returns
**True** if the specified event is present for the type; otherwise, **false**.

## -remarks

## -examples
```cs
if (Windows.Foundation.Metadata.ApiInformation.IsEventPresent("Windows.Media.Core.AudioTrack", "OpenFailed"))
{
    Debug.WriteLine("Windows.Media.Core.AudioTrack.OpenFailed event found");
}
else
{
    Debug.WriteLine("Windows.Media.Core.AudioTrack.OpenFailed event NOT found");
}
```
## -see-also
