---
-api-id: T:Windows.System.Profile.EducationSettings
-api-type: winrt class
---

<!-- Class syntax.
public class EducationSettings 
-->

# Windows.System.Profile.EducationSettings

## -description
Indicates if an app is running in an education environment.  

## -remarks
Examples of changes you might make in an education environment:  

-	Simplify the user interface
-	Not launch the first-run experience
-	Do not collect data or personally identifiable information (PII).
-	Change default content

## -see-also

## -examples
``` cs
if (Windows.System.Profile.EducationSettings.IsEducationEnvironment)
{
    SetHomePage("about:EDU");
}
else
{
    SetHomePage("about:start");
}
```  