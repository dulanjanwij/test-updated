using System;
using Foundation;
using UIKit;
namespace test
{
	public class tbHardSource : UITableViewSource
	{
		string[] tableItems;
		string cellIdentifier = "TableCell";

		public tbHardSource(string[] Items)
		{
			tableItems = Items;
		}

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			new UIAlertView("Hard Workout", "Exercise Name: " + tableItems[indexPath.Row], null, "OK", null).Show();
			tableView.DeselectRow(indexPath, true); //to deselect the selected row
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
			if (cell == null)
				cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
			cell.TextLabel.Text = tableItems[indexPath.Row];
			return cell;



		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return tableItems.Length;
		}
	}
}

