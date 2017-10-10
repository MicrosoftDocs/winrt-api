---
-api-id: M:Windows.ApplicationModel.UserActivities.UserActivityContentInfo.FromJson(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public UserActivityContentInfo UserActivityContentInfo.FromJson(String value)
-->

# Windows.ApplicationModel.UserActivities.UserActivityContentInfo.FromJson

## -description
Creates a **UserActivityContentInfo** from a JSON string.

## -parameters
### -param value
The content to store in JSON format.

## -returns
A **UserActivityContentInfo** that contains the JSON data.

## -remarks

## -see-also

## -examples
```csharp
userActivity.ContentInfo = UserActivityContentInfo.FromJson(
    @"{
    ""@context"": ""~~http~~://schema.org"",
    ""@type"": ""Article"",
    ""author"": ""John Doe"",
    ""name"": ""How to Tie a Reef Knot""
    }");
```
