using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace STANMOREAPP
{
    public class SimpleLinkLabel : Label
    {
        public SimpleLinkLabel(Uri uri, string labelText = null)
        {
            Text = labelText ?? uri.ToString();
            TextColor = Color.Blue;
            GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(() => Device.OpenUri(uri)) });
        }
    }
}
