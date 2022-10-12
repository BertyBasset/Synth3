using System.Collections;
using System.Text.Json;
using System.Text.Json.Nodes;
using UI.Controls;

namespace UI.Code;
public class Patch {
    public class Control {
        public string ControlName { get; set; } = "";
        public double Value { get; set; } = 0;
    }


    static string FileName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\patch.json";
    internal static void Save(Form Form) {
        var ctls = new ArrayList();
        ctls.AddRange(Form.Controls);

        var knobs = new List<Control>();
        foreach (Knob? knob in ctls.OfType<Knob>()) {
            knobs.Add(new Control() { ControlName = knob?.Name??"", Value=knob?.Value??0 });
        }
        
        var s = JsonSerializer.Serialize(knobs);
        System.IO.File.WriteAllText(FileName, s);
    }

    internal static void Load(Form Form) {
        if (!System.IO.File.Exists(FileName))
            return;

        List<Control>? json = null;
        try {
            json = JsonSerializer.Deserialize<List<Control>>(System.IO.File.ReadAllText(FileName));
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

internal class Pacthes : List<Patch> { }




