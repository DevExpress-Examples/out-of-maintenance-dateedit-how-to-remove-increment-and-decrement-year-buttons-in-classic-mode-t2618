using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsFormsApplication9 {
    public class CustomDateEditCalendar : DateEditCalendar {
        public CustomDateEditCalendar(RepositoryItemDateEdit item, object editDate)
            : base(item, editDate) {

        }
        protected override DateEditInfoArgs CreateInfoArgs() {
            return new CustomDateEditInfoArgs(this);
        }
    }
    
}
