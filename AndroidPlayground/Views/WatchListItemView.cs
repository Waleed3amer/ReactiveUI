using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Content;
using Android.Widget;
using AndroidPlayground.ViewModels;
using ReactiveUI.Android;

namespace AndroidPlayground.Views
{
    public class WatchListItemView : ReactiveLinearLayout<WatchListItemViewModel>
    {
        public WatchListItemView(Context context) : base(context, Resource.Layout.WatchListItem)
        {
            this.WireUpControls();
        }

        public TextView Symbol { get; private set; }
        public TextView Price { get; private set; }
        public TextView LastChange { get; private set; }
        public TextView PercentChange { get; private set; }
        public TextView Open { get; private set; }
        public TextView High { get; private set; }
        public TextView Low { get; private set; }
    }
}