using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler.UI;

namespace WindowsApplication1
{
    public partial class HourRecurrenceControl : RecurrenceControlBase
    {
        public HourRecurrenceControl():base()
        {
            InitializeComponent();
            this.UpdateControlsCore();
            this.SubscribeControlsEvents();

        }
        protected override void SubscribeControlsEvents()
        {
            base.SubscribeControlsEvents();
            this.spinEdit1.EditValueChanged += new EventHandler(spinEdit1_EditValueChanged);
        }
        protected override void UnsubscribeControlsEvents()
        {
            base.UnsubscribeControlsEvents();
            this.spinEdit1.EditValueChanged -= new EventHandler(spinEdit1_EditValueChanged);
        }

        void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            base.RecurrenceInfo.Periodicity = base.Validator.GetIntegerValue(this.spinEdit1.EditValue);
        }
        protected override void UpdateControlsCore()
        {
            base.UpdateControlsCore();
            this.spinEdit1.EditValue = base.RecurrenceInfo.Periodicity;
        }
    }
}
