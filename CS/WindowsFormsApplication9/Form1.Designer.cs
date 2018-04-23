namespace WindowsFormsApplication9 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.customEdit11 = new WindowsFormsApplication9.CustomEdit1();
            ((System.ComponentModel.ISupportInitialize)(this.customEdit11.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customEdit11.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // customEdit11
            // 
            this.customEdit11.EditValue = null;
            this.customEdit11.Location = new System.Drawing.Point(28, 42);
            this.customEdit11.Name = "customEdit11";
            this.customEdit11.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customEdit11.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customEdit11.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.customEdit11.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.customEdit11.Size = new System.Drawing.Size(205, 20);
            this.customEdit11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 263);
            this.Controls.Add(this.customEdit11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.customEdit11.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customEdit11.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomEdit1 customEdit11;

    }
}

