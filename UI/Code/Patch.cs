using System.Collections;
using UI.Controls;

namespace UI.Code;
public class Patch {
    public class Control {
        public string ControlName { get; set; } = "";
        public double Value { get; set; } = 0;
    }


    
    internal static void Save(Form Form) {
        var ctls = new ArrayList();
        ctls.AddRange(Form.Controls);

        var knobs = new List<Control>();
        foreach (Knob? knob in ctls.OfType<Knob>()) {
            knobs.Add(new Control() { ControlName = knob?.Name??"", Value=knob?.Value??0 });
        }

        Json<List<Control>>.SaveFile("patch.json", knobs);
    }

    internal static void Load(Form Form) {
        if (!System.IO.File.Exists("patch.json"))
            return;

        List<Control>? json = null;
        try {
            json = UI.Code.Json<List<Control>>.Load("patch.json");
        } catch (Exception) { }
        

        foreach (var c in json?? new List<Control>()) {
            try {
                var ctls = Form.Controls.Find(c.ControlName, true);
                foreach (var ctl in ctls)
                    ((Knob)ctl).Value = c.Value;
            } catch (Exception) { }
        }
    }

    internal static void Reset(Form Form) {

    }
}




