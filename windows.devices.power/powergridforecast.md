---
-api-id: T:Windows.Devices.Power.PowerGridForecast
-api-type: winrt class
---

# Windows.Devices.Power.PowerGridForecast

<!--
public sealed class PowerGridForecast
-->


## -description

Contains information about the power grid that the device is connected to. The data is meant to be used in a forecast for time-shifting the time at which workloads happen, or reducing energy consumption during intense times.

## -remarks

Windows exposes forecasts of power grid carbon emissions based on the power grid that the device is connected to. This data is already used by Windows Update, for example, to time-shift when updates happen in order to lessen carbon emissions. This API exposes these same forecasts to you so that you can reduce the carbon emissions of some of your workloads. For example, you could time-shift when updates of your apps/games happen; or throttle the bit-rate of audio playback, or some other rendering fidelity level; or enable an *efficiency mode*, if you have one.

The power grid forecast API provides two signals to you (to prompt time-shifting). One signal contains a normalized [Severity](./powergriddata_severity.md) value (between 0.0 and 1.0) of grid conditions to optimize for (carbon intensity). The other signal, [IsLowUserExperienceImpact](./powergriddata_islowuserexperienceimpact.md), is a Boolean value that represents when Windows thinks the user will be away from the device. You might choose to use only one signal instead of both; the signals have value individually as well as together.

*Time-shifting* means using the same energy to accomplish work, but doing so at a different time based on a signal.

*Severity* is a normalized value between 0.0 and 1.0, where 0 is considered best, and 1 is worst. That corresponds to power grid carbon severity based on where the device is located.

*Low user-experience impact*. A Boolean value that represents when Windows thinks the user will be away, or not using many resources. This can be thought of as inverse Active Hours. When the value is `true`, it's considered a good time to time-shift workloads to. When it's `false`, it's considered a bad time to time-shift workloads to, in terms of user experience.

## -see-also

## -examples

```csharp
using Windows.Devices.Power;

void PrintBestTimes(PowerGridForecast forecast)
{
    double bestSeverity = double.MaxValue;
    double bestLowImpactSeverity = double.MaxValue;
    DateTime bestTime = DateTime.MaxValue;
    DateTime bestLowImpactTime = DateTime.MaxValue;
    TimeSpan blockDuration = forecast.BlockDuration;
    DateTime startTime = forecast.StartTime;
    IList<PowerGridData> forecastSignals = forecast.Forecast;

    if (forecastSignals.Count == 0)
    {
        Console.WriteLine("Error encountered with getting forecast; try again later.");
        return;
    }

    foreach (PowerGridData data in forecastSignals)
    {
        if (data.Severity < bestSeverity)
        {
            bestSeverity = data.Severity;
            bestTime = startTime;
        }

        if (data.IsLowUserExperienceImpact && data.Severity < bestLowImpactSeverity)
        {
            bestLowImpactSeverity = data.Severity;
            bestLowImpactTime = startTime;
        }

        startTime = startTime + blockDuration;
    }

    if (bestLowImpactTime != DateTime.MaxValue)
    {
        DateTime endBestLowImpactTime = bestLowImpactTime + blockDuration;
        Console.WriteLine($"Lowest severity during low impact is {bestLowImpactSeverity}, which starts at {bestLowImpactTime.ToString()}, and ends at {endBestLowImpactTime}.");
    }
    else
    {
        Console.WriteLine("There's no low-user-impact time in which to do work.");
    }

    if (bestTime != DateTime.MaxValue)
    {
        DateTime endBestSeverity = bestTime + blockDuration;
        Console.WriteLine($"Lowest severity is {bestSeverity}, which starts at {bestTime.ToString()}, and ends at {endBestSeverity.ToString()}.");
    }
}

PowerGridForecast forecast = PowerGridForecast.GetForecast();
PrintBestTimes(forecast);
```

```cppwinrt
#include "pch.h"
#include <iostream>
#include <winrt/Windows.Foundation.Collections.h>
#include <winrt/Windows.Devices.Power.h>

using namespace winrt::Windows::Devices::Power;
using namespace winrt::Windows::Foundation::Collections;
using namespace winrt::Windows::Foundation;

void PrintFullForecast(PowerGridForecast const& forecast)
{
    IVectorView<PowerGridData> forecastSignals = forecast.Forecast();
    DateTime forecastStartTime = forecast.StartTime();
    TimeSpan forecastBlockDuration = forecast.BlockDuration();
    DateTime blockStartTime = forecastStartTime;

    // On failure the forecast will be empty.
    if (forecastSignals.Size() == 0)
    {
        std::wcout << L"Error encountered while reading the forecast; try again later." << std::endl;
        return;
    }

    // Iterate through the forecast printing all the data.
    for (auto const& block : forecastSignals)
    {
        auto severity = block.Severity();
        auto isLowImpact = block.IsLowUserExperienceImpact();

        std::wcout << L"Start time - ";
        PrintDateTime(blockStartTime, true);
        std::wcout << L" | End time - ";
        PrintDateTime(blockStartTime + forecastBlockDuration, true);
        std::wcout << L" | Intensity - " << severity << L" | IsLowImpactTime - " << (isLowImpact ? L"TRUE" : L"FALSE") << std::endl;

        blockStartTime = blockStartTime + forecastBlockDuration;
    }
}

void PrintBestTimes(PowerGridForecast const& forecast)
{
    IVectorView<PowerGridData> forecastSignals = forecast.Forecast();
    DateTime forecastStartTime = forecast.StartTime();
    TimeSpan forecastBlockDuration = forecast.BlockDuration();
    DateTime blockStartTime = forecastStartTime;

    // On failure the forecast will be empty
    if (forecastSignals.Size() == 0)
    {
        std::wcout << L"Error encountered while reading the forecast; try again later." << std::endl;
        return;
    }

    DateTime bestSeverityTimeUTC = DateTime::max();
    DateTime bestSeverityTimeInLowUserImpactTimeUTC = DateTime::max();

    // 1.0 is maximum severity the API can return.
    double bestSeverity = 1.0;
    double bestSeverityInLowUserImpactTime = 1.0;

    // Iterate through the forecast looking for the best times.
    for (auto const& block : forecastSignals)
    {
        auto severity = block.Severity();
        auto isLowImpact = block.IsLowUserExperienceImpact();

        // Check if there is lower severity
        if (severity < bestSeverity)
        {
            bestSeverity = severity;
            bestSeverityTimeUTC = blockStartTime;
        }

        // Check whether there's a lower severity that's also at a time with low user impact.
        if (isLowImpact && severity < bestSeverityInLowUserImpactTime)
        {
            bestSeverityInLowUserImpactTime = severity;
            bestSeverityTimeInLowUserImpactTimeUTC = blockStartTime;
        }

        blockStartTime = blockStartTime + forecastBlockDuration;
    }

    // Print out the best times only if they've been set.
    if (bestSeverityTimeUTC != DateTime::max())
    {
        std::wcout << L"Best time to do work is ";
        PrintDateTime(bestSeverityTimeUTC, true);
        std::wcout << L" with a severity of " << bestSeverity;
        std::wcout << L" and ends at ";
        PrintDateTime(bestSeverityTimeUTC + forecastBlockDuration, true);
        std::wcout << std::endl;
    }

    if (bestSeverityTimeInLowUserImpactTimeUTC != DateTime::max())
    {
        std::wcout << L"Best time with low user impact is ";
        PrintDateTime(bestSeverityTimeInLowUserImpactTimeUTC, true);
        std::wcout << L" with a severity of " << bestSeverityInLowUserImpactTime;
        std::wcout << L" and ends at ";
        PrintDateTime(bestSeverityTimeInLowUserImpactTimeUTC + forecastBlockDuration, true);
        std::wcout << std::endl;
    }
    else
    {
        std::wcout << "There's no low-user-impact time in which to do work." << std::endl;
    }
}

int main() 
{
    std::wcout << L"Power Grid Forecast WinRT API sample app." << std::endl;

    // Register for the forecast notification.
    auto revoker = PowerGridForecast::ForecastUpdated(winrt::auto_revoke, [&](auto, winrt::Windows::Foundation::IInspectable const&) {
        std::wcout << L"Forecast updated..." << std::endl;

        // Forecast has been updated; find the next best times.
        PowerGridForecast forecast = PowerGridForecast::GetForecast();
        PrintBestTimes(forecast);
    });

    // Print out the full forecast.
    PowerGridForecast forecast = PowerGridForecast::GetForecast();
    PrintFullForecast(forecast);

    // Wait until the user presses a key to exit.
    std::cout << "Listening to the signal: a new forecast has been created."
                    "Leave this program open to see when a new forecast is created, otherwise press any key to exit this program..." << std::endl;
    std::cin.get();

    return 0;
}
```
