---
-api-id: M:Windows.System.Diagnostics.ProcessDiagnosticInfo.GetForProcesses
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.System.Diagnostics.ProcessDiagnosticInfo> GetForProcesses()
-->

# Windows.System.Diagnostics.ProcessDiagnosticInfo.GetForProcesses

## -description

Gets a list of [ProcessDiagnosticInfo](processdiagnosticinfo.md) objects for all running processes that are accessible to the caller.

## -returns

A list of [ProcessDiagnosticInfo](processdiagnosticinfo.md) objects for all running processes.

## -remarks

For UWP apps, processes must be in the same **AppContainer**.

To correlate `ProcessDiagnosticInfo` to `AppDiagnosticInfo` and retrieve the package name for a process, you can use the `AppDiagnosticInfo` class. The `AppDiagnosticInfo` class provides diagnostic information about an app, including its package details.

Here’s how you can retrieve the package name for a process:

1. Use the `ProcessDiagnosticInfo.GetForProcesses()` method to get a list of `ProcessDiagnosticInfo` objects.
1. For each `ProcessDiagnosticInfo` object, call the `AppDiagnosticInfo.TryGetForProcess()` method to retrieve the associated `AppDiagnosticInfo`.
1. Access the `AppInfo` property of the `AppDiagnosticInfo` object to get the `AppInfo` instance, which contains the package name.

The following example demonstrates how to achieve this:

```csharp
using System;
using System.Collections.Generic;
using Windows.System.Diagnostics;
using Windows.System;

class Program
{
    static void Main(string[] args)
    {
        IReadOnlyList<ProcessDiagnosticInfo> processes = ProcessDiagnosticInfo.GetForProcesses();

        foreach (var process in processes)
        {
            if (process.IsPackaged)
            {
                var appDiagnosticInfos = AppDiagnosticInfo.TryGetForProcess(process);

                if (appDiagnosticInfos != null)
                {
                    foreach (var appDiagnosticInfo in appDiagnosticInfos)
                    {
                    var appInfo = appDiagnosticInfo.AppInfo;
                    if (appInfo != null)
                    {
                        Console.WriteLine($"Process ID: {process.ProcessId}, Package Name: {appInfo.PackageFamilyName}");
                    }
                    else
                    {
                        Console.WriteLine($"Process ID: {process.ProcessId} has no associated AppInfo.");
                    }}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Process ID: {process.ProcessId} is not associated with an app package.");
            }
        }
    }
}
```

Some things to note:

- The `IsPackaged` property indicates whether the process is part of a packaged app. If `IsPackaged` is `false`, the process is not associated with an app package, and `AppDiagnosticInfo.TryGetForProcess()` will return `null`.
- Ensure your app has the necessary capabilities declared in the app manifest to access process and app diagnostic information.

## -examples

## -see-also
