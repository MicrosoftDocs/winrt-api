---
-api-id: P:Windows.Web.Http.Headers.HttpResponseHeaderCollection.Age
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.TimeSpan> Age { get;  set; }
-->

# Windows.Web.Http.Headers.HttpResponseHeaderCollection.Age

## -description
Gets or sets the [TimeSpan](../windows.foundation/timespan.md) object that represents the value of an **Age** HTTP header on an HTTP response.

## -property-value
The object that represents the value of an **Age** HTTP header on an HTTP response. A **null** value means that the header is absent.

## -remarks
The Age property represents the value of he **Age** header on an HTTP response. The **Age** header is the age of the entity in the cache.

When programming with .NET, this structure is hidden and developers should use the [System.TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true) structure. The value can be **null**, because it's typed as `TimeSpan?` (a nullable [TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true)).

In JavaScript, this structure is accessed as a value, not as an object. For example, use `var a = 10000`, not `var a = { duration: 10000 }`.

> [!NOTE]
> In JavaScript, this structure is treated as the number of millisecond intervals, not the number of 100-nanosecond intervals. Therefore, [Windows.Foundation.TimeSpan](../windows.foundation/timespan.md) values can lose precision when being ported between languages.

For more detailed information, see the [Windows.Foundation.TimeSpan](../windows.foundation/timespan.md) interface.



The following sample code shows a method to set the **Age** header on an [HttpResponseMessage](../windows.web.http/httpresponsemessage.md) object using the Age property on the [HttpResponseHeaderCollection](httpresponseheadercollection.md) object.

```csharp
    public void DemonstrateHeaderResponseAge() {
        var response = new HttpResponseMessage();

        // Set the header with a strong type.
        DateTimeOffset value = DateTimeOffset.UtcNow;
        response.Headers.Age = new TimeSpan(1, 35, 55); // 1 hour, 35 minutes, 55 seconds.

        // Get the strong type out
        System.Diagnostics.Debug.WriteLine("Age value in minutes: {0}", response.Headers.Age.Value.TotalMinutes);

        // The ToString() is useful for diagnostics, too.
        System.Diagnostics.Debug.WriteLine("The Age ToString() results: {0}", response.Headers.Age.ToString());
    }

```



## -examples

## -see-also
[HttpResponseMessage](../windows.web.http/httpresponsemessage.md), [HttpResponseMessage.Headers](../windows.web.http/httpresponsemessage_headers.md), [Windows.Foundation.TimeSpan](../windows.foundation/timespan.md)
