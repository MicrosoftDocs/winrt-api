using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Media.Media3D;

namespace Matrix3DProjectionSimple
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }
        // <SnippetMatrix3DProjectionSimple_code>
        private void ApplyProjection(Object sender, PointerRoutedEventArgs e)
        {
            Matrix3D m = new Matrix3D();

            // This matrix simply translates the image 100 pixels
            // down and 100 pixels right.
            m.M11 = 1.0; m.M12 = 0.0; m.M13 = 0.0; m.M14 = 0.0;
            m.M21 = 0.0; m.M22 = 1.0; m.M23 = 0.0; m.M24 = 0.0;
            m.M31 = 0.0; m.M32 = 0.0; m.M33 = 1.0; m.M34 = 0.0;
            m.OffsetX = 100; m.OffsetY = 100; m.OffsetZ = 0; m.M44 = 1.0;

            Matrix3DProjection m3dProjection = new Matrix3DProjection();
            m3dProjection.ProjectionMatrix = m;

            BeachImage.Projection = m3dProjection;

        }
        // </SnippetMatrix3DProjectionSimple_code>
    }
}
