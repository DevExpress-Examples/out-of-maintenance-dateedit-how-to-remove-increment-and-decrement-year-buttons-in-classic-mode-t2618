using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Popup;

namespace WindowsFormsApplication9 {
    public class CustomEdit1PopupForm : PopupDateEditForm {
        public CustomEdit1PopupForm(CustomEdit1 ownerEdit)
            : base(ownerEdit) {
        }

        protected override PopupBaseFormViewInfo CreateViewInfo() {
            return base.CreateViewInfo();
        }
        protected override DevExpress.XtraEditors.Controls.DateEditCalendar CreateCalendar() {
            return new CustomDateEditCalendar(OwnerEdit.Properties, this.OwnerEdit.EditValue);
        }
    }
}
