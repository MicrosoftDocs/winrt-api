using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.ApplicationModel.Background;
using Windows.ApplicationModel.Calls;
using Windows.ApplicationModel.Calls.Provision;
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CallsRT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Scenario1 : Page
    {
        public Scenario1()
        {
            this.InitializeComponent();
        }


        private void showRegistryFailMessage()
        {

        }


        //If BG is not registered, application should register PhoneCallOriginDataRequestTrigger BG
        //when it's selected as active call origin app
        async Task RegisterTask()
        {
            BackgroundExecutionManager.RemoveAccess();
            var access = await BackgroundExecutionManager.RequestAccessAsync();
            if (access == BackgroundAccessStatus.AllowedMayUseActiveRealTimeConnectivity)
            {
                BackgroundTaskBuilder taskBuilder = new BackgroundTaskBuilder();
                taskBuilder.Name = "CallOriginLookupBackgroundTask";
                PhoneTrigger trigger =
                        new PhoneTrigger(PhoneTriggerType.CallOriginDataRequest);
                taskBuilder.SetTrigger(trigger);
                taskBuilder.TaskEntryPoint = typeof(CallExtraInfoLookupBackgroundTask).FullName;
                taskBuilder.Register();
            }
            else
            {
                showRegistryFailMessage();
            }
        }

        // <SnippetShowCallLocation>
        public sealed class CallOriginLookupBackgroundTask : IBackgroundTask
        {
            public async void Run(IBackgroundTaskInstance taskInstance)
            {

                PhoneCallOriginDataRequestTriggerDetails callDetails =
                       (PhoneCallOriginDataRequestTriggerDetails)taskInstance.TriggerDetails;

                var deferral = taskInstance.GetDeferral();
                //look up local data source for call's location and category
                PhoneCallOrigin data = LocalLookupForCallerData(callDetails.PhoneNumber);
                //set phone call origin
                PhoneCallOriginManager.SetCallOrigin(callDetails.targetId, data);

                deferral.Complete();
            }
        }
        // </SnippetShowCallLocation>

        // <SnippetSelectOriginApp>
        private void PageInit()
        {
            bool isActive = await PhoneCallOriginManager.IsCurrentAppActiveCallOriginApp();
            if (!isActive)
                PhoneCallOriginManager.ShowPhoneCallOriginSettingsUI();
        }
        // </SnippetSelectOriginApp>
    }
}


