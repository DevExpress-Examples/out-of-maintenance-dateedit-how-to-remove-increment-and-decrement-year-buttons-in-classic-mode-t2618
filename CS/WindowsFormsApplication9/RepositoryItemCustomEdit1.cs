using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsFormsApplication9 {
    [UserRepositoryItem("RegisterCustomEdit1")]
    public class RepositoryItemCustomEdit1 : RepositoryItemDateEdit {
        static RepositoryItemCustomEdit1() {
            RegisterCustomEdit1();
        }

        public const string CustomEditName = "CustomEdit1";

        public RepositoryItemCustomEdit1() {
        }

        public override string EditorTypeName {
            get {
                return CustomEditName;
            }
        }

        public static void RegisterCustomEdit1() {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(CustomEdit1), typeof(RepositoryItemCustomEdit1), typeof(DateEditViewInfo), new ButtonEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item) {
            BeginUpdate();
            try {
                base.Assign(item);
                RepositoryItemCustomEdit1 source = item as RepositoryItemCustomEdit1;
                if(source == null)
                    return;
            } finally {
                EndUpdate();
            }
        }
    }

}
