﻿using System;
using Foundation;
using UIKit;
namespace test
{
	public class tbsource : UITableViewSource
	{
		string[] tableItems;
		string cellIdentifier = "TableCell";




		public tbsource(string[] Items)
		{
			tableItems = Items;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
			if (cell == null)
				cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
			cell.TextLabel.Text = tableItems[indexPath.Row];
			return cell;
		}
		//once u select a row in the table view it will show an alert box displaying the workout type and exercise name
		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			new UIAlertView("Easy Workout", "Exercise Name: " + tableItems[indexPath.Row], null, "OK", null).Show();
			tableView.DeselectRow(indexPath, true); //to deselect the selected row
		}
		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return tableItems.Length;
		}
	}
}

