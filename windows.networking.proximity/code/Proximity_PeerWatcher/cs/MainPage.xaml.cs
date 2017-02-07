using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.Proximity;
using Windows.Networking.Sockets;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Proximity_PeerWatcher
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        // <Snippet_StartPeerWatcher>
        private PeerWatcher _peerWatcher;
        private bool _peerWatcherIsRunning = false;
        private bool _peerFinderStarted = false;

        // The list of peers discovered by the PeerWatcher.
        ObservableCollection<PeerInformation> _discoveredPeers = new ObservableCollection<PeerInformation>();
        void PeerFinder_StartPeerWatcher(object sender, RoutedEventArgs e)
        {
            if (!_peerFinderStarted)
            {
                // PeerFinder must be started first.
                return;
            }

            if (_peerWatcherIsRunning)
            {
                // PeerWatcher is already running.
                return;
            }

            try
            {
                if (_peerWatcher == null)
                {
                    _peerWatcher = PeerFinder.CreateWatcher();

                    // Add PeerWatcher event handlers. Only add handlers once.
                    _peerWatcher.Added += PeerWatcher_Added;
                    _peerWatcher.Removed += PeerWatcher_Removed;
                    _peerWatcher.Updated += PeerWatcher_Updated;
                    _peerWatcher.EnumerationCompleted += PeerWatcher_EnumerationCompleted;
                    _peerWatcher.Stopped += PeerWatcher_Stopped;
                }

                // Empty the list of discovered peers.
                _discoveredPeers.Clear();

                // Start the PeerWatcher.
                _peerWatcher.Start();

                _peerWatcherIsRunning = true;
            }
            catch (Exception ex)
            {
                // Exceptions can occur if PeerWatcher.Start is called multiple times or
                // PeerWatcher.Start is called the PeerWatcher is stopping.
            }
        }
        
        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            if (_peerWatcher != null)
            {
                // Remove event handlers.
                _peerWatcher.Added -= PeerWatcher_Added;
                _peerWatcher.Removed -= PeerWatcher_Removed;
                _peerWatcher.Updated -= PeerWatcher_Updated;
                _peerWatcher.EnumerationCompleted -= PeerWatcher_EnumerationCompleted;
                _peerWatcher.Stopped -= PeerWatcher_Stopped;

                _peerWatcher = null;
            }
        }
        // </Snippet_StartPeerWatcher>

        // <Snippet_StopPeerWatcher>
        void PeerFinder_StopPeerWatcher(object sender, RoutedEventArgs e)
        {
            try
            {
                _peerWatcher.Stop();
            }
            catch (Exception ex)
            {
                // Handle the exception.
            }
        }
        // </Snippet_StopPeerWatcher>

        // <Snippet_PeerWatcherAdded>
        private void PeerWatcher_Added(PeerWatcher sender, PeerInformation peerInfo)
        {
            var result = Dispatcher.RunAsync(CoreDispatcherPriority.Low, () =>
            {
                lock (this)
                {
                    _discoveredPeers.Add(peerInfo);
                }
            });
        }
        // </Snippet_PeerWatcherAdded>

        // <Snippet_PeerWatcherRemoved>
        private void PeerWatcher_Removed(PeerWatcher sender, PeerInformation peerInfo)
        {
            var result = Dispatcher.RunAsync(CoreDispatcherPriority.Low, () =>
            {
                lock (this)
                {
                    // Find and remove the peer form the list of discovered peers.
                    for (int i = 0; i < _discoveredPeers.Count; i++)
                    {
                        if (_discoveredPeers[i].Id == peerInfo.Id)
                        {
                            _discoveredPeers.RemoveAt(i);
                        }
                    }
                }
            });
        }
        // </Snippet_PeerWatcherRemoved>

        // <Snippet_PeerWatcherUpdated>
        private void PeerWatcher_Updated(PeerWatcher sender, PeerInformation peerInfo)
        {
            var ignored = Dispatcher.RunAsync(CoreDispatcherPriority.Low, () =>
            {
                lock (this)
                {
                    // Find and update the peer in the list of discovered peers.
                    for (int i = 0; i < _discoveredPeers.Count; i++)
                    {
                        if (_discoveredPeers[i].Id == peerInfo.Id)
                        {
                            _discoveredPeers[i] = peerInfo;
                        }
                    }
                }
            });
        }
        // </Snippet_PeerWatcherUpdated>

        // <Snippet_PeerWatcherEnumerationCompleted>
        private void PeerWatcher_EnumerationCompleted(PeerWatcher sender, object o)
        {
            var result = Dispatcher.RunAsync(CoreDispatcherPriority.Low, () =>
            {
                lock (this)
                {
                    if (_discoveredPeers.Count == 0)
                    {
                        // No peers discovered for this enumeration.
                    }
                }
            });
        }
        // </Snippet_PeerWatcherEnumerationCompleted>

        // <Snippet_PeerWatcherStopped>
        private void PeerWatcher_Stopped(PeerWatcher sender, object o)
        {
            _peerWatcherIsRunning = false;
            var result = Dispatcher.RunAsync(CoreDispatcherPriority.Low, () =>
            {
                // Update UI now that the PeerWatcher is stopped.
            });
        }
        // </Snippet_PeerWatcherStopped>


    }
}
