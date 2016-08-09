using Foundation;
using System;
using UIKit;

namespace test
{
    public partial class easyviewcontroller : UIViewController
    {
        public easyviewcontroller (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var data = new string[] { "Sprints: 20 seconds each 10 rounds", "Box jumps: 30 Reps", "Ropes: 20 seconds 5 rounds", "Kettle Bell Swings: 10 Reps 5 sets", "Push ups: 10 Reps 5 sets", "Pull Ups:10 Reps 5 Sets"}; //exercise names
			UITableView _table;

			_table = new UITableView
			{
				Frame = new CoreGraphics.CGRect(0, 30, View.Bounds.Width, View.Bounds.Height),

				Source = new tbsource(data)				
			};

			View.AddSubview(_table);
		}
    }
}