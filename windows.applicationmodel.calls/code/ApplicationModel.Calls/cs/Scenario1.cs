//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the Microsoft Public License.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using SDKTemplate;
using System;
using Windows.Devices.Sensors;
using Windows.Foundation;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.ApplicationModel.Calls;
using Windows.ApplicationModel.Calls.Background;
using Windows.ApplicationModel.Calls.Provider;

namespace Microsoft.Samples.CallsRT.Scenario1
{
    /// <summary>
    /// Enumerate through all phone lines and returns a list of all phone lines
    /// </summary>
    /// <returns>A dictionary of cellular phone lines and their guids.</returns>	
    
    // <SnippetGetLinesCS>
    private async Task<Dictionary<Guid, PhoneLine>> GetPhoneLinesAsync()
    {
        PhoneCallStore store = await PhoneCallManager.RequestStoreAsync();

        // Start the PhoneLineWatcher
        var watcher = store.RequestLineWatcher();
        var phoneLines = new List<PhoneLine>();
        var lineEnumerationCompletion = new TaskCompletionSource<bool>();
        watcher.LineAdded += async (o, args) => { var line = await PhoneLine.FromIdAsync(args.LineId); phoneLines.Add(line); };
        watcher.Stopped += (o, args) => lineEnumerationCompletion.TrySetResult(false);
        watcher.EnumerationCompleted += (o, args) => lineEnumerationCompletion.TrySetResult(true);
        watcher.Start();

        // Wait for enumeration completion
        if (!await lineEnumerationCompletion.Task)
        {
            throw new Exception("Phone Line Enumeration failed");
        }

        watcher.Stop();

        Dictionary<Guid, PhoneLine> returnedLines = new Dictionary<Guid, PhoneLine>();

        foreach (PhoneLine phoneLine in phoneLines)
        {
            if (phoneLine != null && phoneLine.Transport == PhoneLineTransport.Cellular)
            {
                returnedLines.Add(phoneLine.Id, phoneLine);
            }
        }

        return returnedLines;
    }
    // </SnippetGetLinesCS>

    // <SnippetMonitorLineChanges>
    private async void MonitorLineChanges(Guid lineId)
    {
        // Get the PhoneLine instance
        PhoneLine line = await PhoneLine.FromIdAsync(lineId);

        PhoneNetworkState updatedNetworkState;
        string updatedNetworkName;

        line.LineChanged += (o, args) =>
        {
            updatedNetworkState = line.NetworkState;
            updatedNetworkName = line.NetworkName;
        };
    }
    // </SnippetMonitorLineChanges>


    /// <summary>
    /// Gets the default phone line
    /// </summary>
    /// <returns>A one phone line. The default one on the device.</returns>	
    // <SnippetGetDefaultLine>
    private async Task<PhoneLine> GetDefaultPhoneLineAsync()
    {
        PhoneCallStore phoneCallStore = await PhoneCallManager.RequestStoreAsync();
        Guid lineId = await phoneCallStore.GetDefaultLineAsync();
        PhoneLine line = null;
        try
        {
            line = await PhoneLine.FromIdAsync(lineId);
        }
        catch (Exception ex)
        {
            Logger.Instance.LogErrorMessage($"PhoneLine.FromIdAsync failed:{ex.Message}");
        }
    return line;
    }

    // </SnippetGetDefaultLine>
}
