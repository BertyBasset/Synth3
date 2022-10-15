using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Controls;

namespace UI {
    public partial class frmControlMapping : Form {
        Dictionary<int, ControlMap> rows = new Dictionary<int, ControlMap>();
        int _count = 1;

        public Form form;
        public frmControlMapping() {
            InitializeComponent();

            rows.Add(0, controlMap1);
            rows.Add(1, controlMap2);
            rows.Add(2, controlMap3);
            rows.Add(3, controlMap4);
            rows.Add(4, controlMap5);
            rows.Add(5, controlMap6);
            rows.Add(6, controlMap7);
            rows.Add(7, controlMap8);
            rows.Add(8, controlMap9);
            rows.Add(9, controlMap10);

            for (int i = 0; i < 10; i++) {
                if(i >= 1)
                    rows[i].Visible = false;
                rows[i].DeleteClicked += ControlMap1_DeleteClicked;

            }

            cmdAdd.Click += CmdAdd_Click;

        }

        private void CmdAdd_Click(object? sender, EventArgs e) {
            if (_count < 10) {
                _count++;
                rows[_count-1].Visible = true;

                cmdAdd.Location = new Point(27, _count * 26 + 21);
            
            }
        }

        private void ControlMap1_DeleteClicked(object? sender, int index) {
            if (_count > 1) {
                rows[_count - 1].Visible = false;
                for (int i = 9; i < _count; i++) { 
        


                    // ***** Add selected index propertties to both dropdowns in the controls
                    // We also need to load and persist these

                }



                    _count--;
                cmdAdd.Location = new Point(27, _count * 26 + 21);




            }


        }
    }
}
