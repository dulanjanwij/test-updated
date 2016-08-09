using Foundation;
using System;
using UIKit;

namespace test
{
    public partial class MediumViewController : UIViewController
    {

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var mediumdata = new string[] { "Sprints: 20 seconds each 10 rounds", "Power Cleans: 10 Reps 10 sets", "Deadlift: 10 Reps 5 sets", "Bench Press: 10 Reps 5 Sets", "Push ups: 10 Reps 5 sets", "Pull Ups:10 Reps 5 Sets","Wall sits:20 seconds 3 sets", "DeadBall Slams: 10 reps 3 sets"}; //exercise names
			UITableView _table;

			_table = new UITableView
			{
				Frame = new CoreGraphics.CGRect(0, 30, View.Bounds.Width, View.Bounds.Height),

				Source = new tbMediumsource(mediumdata)};

			View.AddSubview(_table);
		}
        public MediumViewController (IntPtr handle) : base (handle)
        {
        }
    }
}