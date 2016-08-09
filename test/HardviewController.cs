using Foundation;
using System;
using UIKit;

namespace test
{
    public partial class HardviewController : UIViewController
    {


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var Harddata = new string[] { "Sprints: 20 seconds each 10 rounds", "Clean and Jerk: 10 Reps 10 sets", "Deadlift: 10 Reps 5 sets", "Bench Press: 10 Reps 5 Sets", "Push ups: 10 Reps 5 sets", "Pull Ups:10 Reps 5 Sets", "Wall sits:20 seconds 3 sets", "DeadBall Slams: 10 reps 3 sets","Ropes: 20 seconds 3 sets","Tire flips: 100m", "Plate Push: 100m" }; //exercise name
			UITableView _tablehard;

			_tablehard = new UITableView
			{
				Frame = new CoreGraphics.CGRect(0, 30, View.Bounds.Width, View.Bounds.Height),

				Source = new tbMediumsource(Harddata)
			};

			View.AddSubview(_tablehard);
		}
		public HardviewController (IntPtr handle) : base (handle)
        {
        }
    }
}