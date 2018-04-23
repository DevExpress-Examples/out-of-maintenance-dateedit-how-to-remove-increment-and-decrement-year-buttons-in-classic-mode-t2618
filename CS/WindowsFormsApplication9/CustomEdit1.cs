using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;

namespace WindowsFormsApplication9 {
    [ToolboxItem(true)]
    public class CustomEdit1 : DateEdit {
        static CustomEdit1() {
            RepositoryItemCustomEdit1.RegisterCustomEdit1();
        }

        public CustomEdit1() {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomEdit1 Properties {
            get {
                return base.Properties as RepositoryItemCustomEdit1;
            }
        }

        public override string EditorTypeName {
            get {
                return RepositoryItemCustomEdit1.CustomEditName;
            }
        }

        protected override PopupBaseForm CreatePopupForm() {
            return new CustomEdit1PopupForm(this);
        }
    }
}
