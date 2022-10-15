using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Code;

namespace UI.Controls {
    public partial class ControlMap : UserControl {
        public int index { get; set; }

        
        
        public event EventHandler<int> DeleteClicked;
        public ControlMap() {
            InitializeComponent();

           // InitLists();

            this.Load += (o, e) => InitLists();
            cmdDelete.Click += (o,e) =>
            DeleteClicked?.Invoke(this, index);

        }

        private void InitLists() {
            if (DesignMode)
                return;
            
            // We've passed reference to Knobs on main page to the form containing this control
            var frm = this.FindForm();



            var knobs = ((frmControlMapping)frm).form.Controls.OfType<Knob>().Select(x => x.Description).ToList();
            knobs.Insert(0, "[select]");
            cboKnob.DataSource = knobs;

            var ccs = ControlChangeParameter.GetList();
            cboController.DataSource = ccs;

                
           
        }
    }
}
