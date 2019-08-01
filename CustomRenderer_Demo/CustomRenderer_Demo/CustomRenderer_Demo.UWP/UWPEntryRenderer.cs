using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
[assembly: ExportRenderer(typeof(Entry), typeof(CustomRenderer_Demo.UWP.UWPEntryRenderer))]
namespace CustomRenderer_Demo.UWP
{
    class UWPEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
                Control.Background = new LinearGradientBrush
                {
                    GradientStops = new GradientStopCollection
                    {
                        new GradientStop {Offset=0, Color= Windows.UI.Colors.Ivory},
                        new GradientStop {Offset=0.5, Color= Windows.UI.Colors.Wheat},
                        new GradientStop {Offset=1, Color= Windows.UI.Colors.LightYellow},
                    }
                };
        }
    }
}
