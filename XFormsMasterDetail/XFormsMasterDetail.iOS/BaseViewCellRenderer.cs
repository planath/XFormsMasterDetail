﻿using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFormsMasterDetail.iOS;
using XFormsMasterDetail.View.Cell;

[assembly: ExportRenderer(typeof(ViewCell), typeof(BaseViewCellRenderer))]
namespace XFormsMasterDetail.iOS
{
    class BaseViewCellRenderer : ViewCellRenderer
    {
        public override UIKit.UITableViewCell GetCell(Cell item, UIKit.UITableViewCell reusableCell, UIKit.UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            if (item is CheckmarkViewCell)
            {
                if ((item as CheckmarkViewCell).StyleId.Equals("checkmark"))
                {
                    cell.Accessory = UIKit.UITableViewCellAccessory.Checkmark;
                }
            }
            else
            {
                cell.Accessory = UIKit.UITableViewCellAccessory.DisclosureIndicator;
            }

            //switch (item.StyleId)
            //{
            //    case "none":
            //        cell.Accessory = UIKit.UITableViewCellAccessory.None;
            //        break;
            //    case "checkmark":
            //        cell.Accessory = UIKit.UITableViewCellAccessory.Checkmark;
            //        break;
            //    case "detail-button":
            //        cell.Accessory = UIKit.UITableViewCellAccessory.DetailButton;
            //        break;
            //    case "detail-disclosure-button":
            //        cell.Accessory = UIKit.UITableViewCellAccessory.DetailDisclosureButton;
            //        break;
            //    case "disclosure":
            //    default:
            //        cell.Accessory = UIKit.UITableViewCellAccessory.DisclosureIndicator;
            //        break;
            //}
            return cell;
        }
    }
}
