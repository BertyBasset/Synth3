using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using UI.Code;
using UI.Controls;

namespace UI;
public partial class frmControlMapping : Form {
    const string FILENAME = "ControllerMapping.json";
    const int ROW_SPACING = 25;

    public Form? form;
    int NumRows = 0;
    new bool Activated = false;
    public frmControlMapping() {
        InitializeComponent();


        cmdAdd.Click += CmdAdd_Click;
        cmdCancel.Click += (o, e) => this.Close();
        cmdSave.Click += (o, e) => SaveMapping();
        this.Click += (o, e) => LoadMapping();



    }

    protected override void OnActivated(EventArgs e) {
        base.OnActivated(e);
        if(!Activated)
            InitControls();
        Activated = true;
    }

    #region InitControls
    // Put controls into dictionaries so we can treat them as arrays
    Dictionary<int, ComboBox> cboMidi = new();
    Dictionary<int, ComboBox> cboKnob = new();
    Dictionary<int, Button> cmdDelete = new();

    void InitControls() {
        InitDictionaries();

        // Load Json + control visibility
        var mapping = LoadMapping();
        for (int i = 0; i < mapping.Count; i++) {
            var map = mapping[i];

            for (int j = 0; j < cboMidi[i].Items.Count; j++) {
                if (map.ControllerID == ((ControlChangeParameter)cboMidi[i].Items[j]).ID) {
                    cboMidi[i].SelectedIndex = j;
                    break;
                }
            }
            for (int j = 0; j < cboKnob[i].Items.Count; j++) {
                if (map.KnobDescription == (string)cboKnob[i].Items[j]) {
                    cboKnob[i].SelectedIndex = j;
                    break;
                }
            }
        }

        for (int i = mapping.Count; i < cboKnob.Count; i++) {
            if (i > 0) {
                cboKnob[i].Visible = false;
                cboMidi[i].Visible = false;
                cmdDelete[i].Visible = false;
            }
            
        }


        cmdAdd.Location = new Point(9, mapping.Count * ROW_SPACING + 23);
        if (mapping.Count == 0)
            cmdAdd.Location = new Point(9, cmdAdd.Location.Y + ROW_SPACING);

        NumRows = mapping.Count == 0? 1 : mapping.Count;
    }

    private void InitDictionaries() { 
        cboMidi.Add(0, cboMidiController0);
        cboMidi.Add(1, cboMidiController1);
        cboMidi.Add(2, cboMidiController2);
        cboMidi.Add(3, cboMidiController3);
        cboMidi.Add(4, cboMidiController4);
        cboMidi.Add(5, cboMidiController5);
        cboMidi.Add(6, cboMidiController6);
        cboMidi.Add(7, cboMidiController7);
        cboMidi.Add(8, cboMidiController8);
        cboMidi.Add(9, cboMidiController9);
        cboKnob.Add(0, cboKnob0);
        cboKnob.Add(1, cboKnob1);
        cboKnob.Add(2, cboKnob2);
        cboKnob.Add(3, cboKnob3);
        cboKnob.Add(4, cboKnob4);
        cboKnob.Add(5, cboKnob5);
        cboKnob.Add(6, cboKnob6);
        cboKnob.Add(7, cboKnob7);
        cboKnob.Add(8, cboKnob8);
        cboKnob.Add(9, cboKnob9);
        cmdDelete.Add(0, cmdDelete0);
        cmdDelete.Add(1, cmdDelete1);
        cmdDelete.Add(2, cmdDelete2);
        cmdDelete.Add(3, cmdDelete3);
        cmdDelete.Add(4, cmdDelete4);
        cmdDelete.Add(5, cmdDelete5);
        cmdDelete.Add(6, cmdDelete6);
        cmdDelete.Add(7, cmdDelete7);
        cmdDelete.Add(8, cmdDelete8);
        cmdDelete.Add(9, cmdDelete9);


        // Populate Combos
        if (form == null)
            return;

        var availableKnobs = form.Controls.OfType<Knob>().Select(i => i.Description).ToList();
        availableKnobs.Insert(0, "[select]");
        var allControllers = ControlChangeParameter.GetList();

        for (int i = 0; i < cboMidi.Count; i++) {
            var _knobs = new List<string>();
            foreach (var k in availableKnobs)
                _knobs.Add(k);

            cboMidi[i].DataSource = ControlChangeParameter.GetList();
            cboKnob[i].DataSource = _knobs;
            cmdDelete[i].Click += (o, e) => Delete((Button)(o??(new Button())));
        }
       
    }

    #endregion

    void Delete(Button btn) {
        int index = int.Parse(btn.Name.Substring(btn.Name.Length - 1));
            
        if (NumRows > 1) {
            NumRows--;
            cboMidi[NumRows].Visible = false;
            cboKnob[NumRows].Visible = false;
            cmdDelete[NumRows].Visible = false;
            cmdAdd.Location = new Point(9, cmdAdd.Location.Y - ROW_SPACING);

            for (int i = index; i < NumRows;  i++) {
                cboMidi[i].SelectedIndex = cboMidi[i + 1].SelectedIndex;
                cboKnob[i].SelectedIndex = cboKnob[i + 1].SelectedIndex;
            }
            cboMidi[NumRows].SelectedIndex = 0;
            cboKnob[NumRows].SelectedIndex = 0;
        }
    }


    private void CmdAdd_Click(object? sender, EventArgs e) {
        if (NumRows >= cboKnob.Count)
            return;

        cboMidi[NumRows].Visible = true;
        cboKnob[NumRows].Visible = true;
        cmdDelete[NumRows].Visible = true;
        NumRows++;
        cmdAdd.Location = new Point(9, cmdAdd.Location.Y + ROW_SPACING);
    }


    private List<ControlKnobMap> LoadMapping() {
        return Json<List<ControlKnobMap>>.Load(FILENAME);
    }

    private void SaveMapping() {
        List<ControlKnobMap> mapping = new();

        if (!ValidateForm())
            return;
        for (int i = 0; i < cboMidi.Count; i++) {
            if (cboMidi[i].SelectedIndex > 0 && cboKnob[i].SelectedIndex > 0) {
                var id = ((ControlChangeParameter)cboMidi[i].SelectedItem).ID??0;
                var m = new ControlKnobMap() {
                    ControllerID = (int)id,
                    KnobDescription = ((string)cboKnob[i].SelectedItem)
                };
                mapping.Add(m);
            }
        }

        Json<List<ControlKnobMap>>.SaveFile(FILENAME, mapping);
        this.Close();
    }


    bool ValidateForm() {
        for (int i = 0; i < cboMidi.Count; i++) {
            if (cboMidi[i].SelectedIndex <= 0 && cboKnob[i].SelectedIndex > 0 || cboMidi[i].SelectedIndex > 0 && cboKnob[i].SelectedIndex <= 0) {
                MessageBox.Show("Both side os mapping need to be selected", "Mapping", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (cboMidi[i].SelectedIndex <= 0)
                    cboMidi[i].Focus();
                else
                    cboKnob[i].Focus();
                return false;
            }
        }
        return true;
    }
}



// CHANGE cbos to store this class, so we can store name, but display Desc

public class Knob {
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
}




