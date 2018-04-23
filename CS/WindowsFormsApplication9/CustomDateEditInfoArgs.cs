using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsFormsApplication9 {
    public class CustomDateEditInfoArgs : DateEditInfoArgs {
        public CustomDateEditInfoArgs(DateEditCalendarBase calendar)
            : base(calendar) {

        }

        protected override void CalcHeaderInfo() {
            base.CalcHeaderInfo();

            Size buttonSize = CalcArrowButtonSize();
            int margin = 2;
            int x = Header.X + margin;
            int y = Header.Y + (Header.Height - buttonSize.Height) / 2;
            DecMonthInfo.Bounds = new Rectangle(new Point(x, y), buttonSize);
            x = DecMonthInfo.Bounds.Right;
            if(!ShowDecMonth)
                DecMonthInfo.Bounds = Rectangle.Empty;
            EditMonth = new Rectangle(MonthTitleWidth, Header.Y, MonthTitleWidth, Header.Height);
            //Prev code: new Rectangle(new Point(EditMonth.Right, y), buttonSize);
            IncMonthInfo.Bounds = new Rectangle(new Point(Header.Right - buttonSize.Width - margin, y), buttonSize);
            x = IncMonthInfo.Bounds.Right;
            if(!ShowIncMonth)
                IncMonthInfo.Bounds = Rectangle.Empty;
            x += margin;
            if(ShowIncYear) {
                //Prev code: new Rectangle(new Point(Header.Right - buttonSize.Width - margin, y), buttonSize);
                IncYearInfo.Bounds = Rectangle.Empty;
            }
            x = Header.Right - buttonSize.Width - margin;
            //Prev code: new Rectangle(x - YearTitleWidth, Header.Y, YearTitleWidth, Header.Height);
            EditYear = Rectangle.Empty;
            if(ShowDecYear) {
                //Prev code: new Rectangle(new Point(EditYear.Left - buttonSize.Width, y), buttonSize);
                DecYearInfo.Bounds = Rectangle.Empty;
            }
            if(Calendar.IsHandleCreated)
                UpdateArrowButtonsState(Control.MouseButtons, Calendar.PointToClient(Cursor.Position), false);
        }
    }
}
