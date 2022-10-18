
using System.Collections.Immutable;

namespace UI.Code;
// Midi CC Parameter  
public class  ControlChangeParameter{
    public int? ID { get; set; } = 0;
    public string ParamName{ get; set; } = "";
    public bool IsCommon { get; set; } = false;              // If isCommon=true, the ID is normally associated with that particular parameter

    public override string ToString() {
        if (ID == null)
            return "[select]";
        else
            return $"CC ID: {ID.ToString()}, {ParamName}";
    }

    public ControlChangeParameter() { }

    public ControlChangeParameter(int? iD, string paramName, bool isCommon = false) {
        ID = iD;
        ParamName = paramName;
        IsCommon = isCommon;
    }

    public static ControlChangeParameter GetById(int ID) {
        var knobs = GetList().Where(i => i.ID == ID).ToList();

        if (knobs.Count == 0)
            return new ControlChangeParameter();
        else
            return knobs[0];
     
    }


    public static List<ControlChangeParameter> GetList() { 
        var list = new List<ControlChangeParameter>();
        list.Add(new ControlChangeParameter(null, ""));
        list.Add(new ControlChangeParameter(0, "Bank Select"));
        list.Add(new ControlChangeParameter(1, "Modulation Wheel", true));
        list.Add(new ControlChangeParameter(2, "Breath Controller", true));
        list.Add(new ControlChangeParameter(3, "undefined"));
        list.Add(new ControlChangeParameter(4, "Foot Pedal"));
        list.Add(new ControlChangeParameter(5, "Portamento Time"));
        list.Add(new ControlChangeParameter(6, "Data Entry"));
        list.Add(new ControlChangeParameter(7, "Volume", true));
        list.Add(new ControlChangeParameter(8, "Balance"));
        list.Add(new ControlChangeParameter(9, "undefined"));
        list.Add(new ControlChangeParameter(10, "Pan", true));
        list.Add(new ControlChangeParameter(11, "Expression", true));
        list.Add(new ControlChangeParameter(12, "Effect Control 1"));
        list.Add(new ControlChangeParameter(13, "Effect Control 2"));
        list.Add(new ControlChangeParameter(14, "undefined"));
        list.Add(new ControlChangeParameter(15, "undefined"));
        list.Add(new ControlChangeParameter(16, "General Purpose"));
        list.Add(new ControlChangeParameter(17, "General Purpose"));
        list.Add(new ControlChangeParameter(18, "General Purpose"));
        list.Add(new ControlChangeParameter(19, "General Purpose"));
        list.Add(new ControlChangeParameter(20, "undefined"));
        list.Add(new ControlChangeParameter(21, "undefined"));
        list.Add(new ControlChangeParameter(22, "undefined"));
        list.Add(new ControlChangeParameter(23, "undefined"));
        list.Add(new ControlChangeParameter(24, "undefined"));
        list.Add(new ControlChangeParameter(25, "undefined"));
        list.Add(new ControlChangeParameter(26, "undefined"));
        list.Add(new ControlChangeParameter(27, "undefined"));
        list.Add(new ControlChangeParameter(28, "undefined"));
        list.Add(new ControlChangeParameter(29, "undefined"));
        list.Add(new ControlChangeParameter(30, "undefined"));
        list.Add(new ControlChangeParameter(31, "undefined"));
        list.Add(new ControlChangeParameter(32, "Controller 0"));
        list.Add(new ControlChangeParameter(33, "Controller 1"));
        list.Add(new ControlChangeParameter(34, "Controller 2"));
        list.Add(new ControlChangeParameter(35, "Controller 3"));
        list.Add(new ControlChangeParameter(36, "Controller 4"));
        list.Add(new ControlChangeParameter(37, "Controller 5"));
        list.Add(new ControlChangeParameter(38, "Controller 6"));
        list.Add(new ControlChangeParameter(39, "Controller 7"));
        list.Add(new ControlChangeParameter(40, "Controller 8"));
        list.Add(new ControlChangeParameter(41, "Controller 9"));
        list.Add(new ControlChangeParameter(42, "Controller 10"));
        list.Add(new ControlChangeParameter(43, "Controller 11"));
        list.Add(new ControlChangeParameter(44, "Controller 12"));
        list.Add(new ControlChangeParameter(45, "Controller 13"));
        list.Add(new ControlChangeParameter(46, "Controller 14"));
        list.Add(new ControlChangeParameter(47, "Controller 15"));
        list.Add(new ControlChangeParameter(48, "Controller 16"));
        list.Add(new ControlChangeParameter(49, "Controller 17"));
        list.Add(new ControlChangeParameter(50, "Controller 18"));
        list.Add(new ControlChangeParameter(51, "Controller 19"));
        list.Add(new ControlChangeParameter(52, "Controller 20"));
        list.Add(new ControlChangeParameter(53, "Controller 21"));
        list.Add(new ControlChangeParameter(54, "Controller 22"));
        list.Add(new ControlChangeParameter(55, "Controller 23"));
        list.Add(new ControlChangeParameter(56, "Controller 24"));
        list.Add(new ControlChangeParameter(57, "Controller 25"));
        list.Add(new ControlChangeParameter(58, "Controller 26"));
        list.Add(new ControlChangeParameter(59, "Controller 27"));
        list.Add(new ControlChangeParameter(60, "Controller 28"));
        list.Add(new ControlChangeParameter(61, "Controller 29"));
        list.Add(new ControlChangeParameter(62, "Controller 30"));
        list.Add(new ControlChangeParameter(63, "Controller 31"));
        list.Add(new ControlChangeParameter(64, "Sustain Pedal (on/off)", true));
        list.Add(new ControlChangeParameter(65, "Portamento (on/off)", true));
        list.Add(new ControlChangeParameter(66, "Sostenuto Pedal (on/off)"));
        list.Add(new ControlChangeParameter(67, "Soft Pedal (on/off)"));
        list.Add(new ControlChangeParameter(68, "Legato Pedal (on/off)"));
        list.Add(new ControlChangeParameter(69, "Hold 2 Pedal (on/off"));
        list.Add(new ControlChangeParameter(70, "Sound Variation"));
        list.Add(new ControlChangeParameter(71, "VCF Resonance", true));
        list.Add(new ControlChangeParameter(72, "Sound Release Time"));
        list.Add(new ControlChangeParameter(73, "Sound Attack Time"));
        list.Add(new ControlChangeParameter(74, "VCF Cutoff Frequency", true));
        list.Add(new ControlChangeParameter(75, "Sound Control 6"));
        list.Add(new ControlChangeParameter(76, "Sound Control 7"));
        list.Add(new ControlChangeParameter(77, "Sound Control 8"));
        list.Add(new ControlChangeParameter(78, "Sound Control 9"));
        list.Add(new ControlChangeParameter(79, "Sound Control 10"));
        list.Add(new ControlChangeParameter(80, "Decay or GP Button 1 (on/off)"));
        list.Add(new ControlChangeParameter(81, "VCF Hi Pass Frequency or GP Button 3 (on/off)"));
        list.Add(new ControlChangeParameter(82, "GP Button 3 (on/off"));
        list.Add(new ControlChangeParameter(83, "GP Button 4 (on/off"));
        list.Add(new ControlChangeParameter(84, "Portamento Amount"));
        list.Add(new ControlChangeParameter(85, "Undefined"));
        list.Add(new ControlChangeParameter(86, "Undefined"));
        list.Add(new ControlChangeParameter(87, "Undefined"));
        list.Add(new ControlChangeParameter(88, "Undefined"));
        list.Add(new ControlChangeParameter(89, "Undefined"));
        list.Add(new ControlChangeParameter(90, "Undefined"));
        list.Add(new ControlChangeParameter(91, "Reverb Level"));
        list.Add(new ControlChangeParameter(92, "Tremolo Level"));
        list.Add(new ControlChangeParameter(93, "Chorus Level"));
        list.Add(new ControlChangeParameter(94, "Detune Level"));
        list.Add(new ControlChangeParameter(95, "Phaser Level"));
        list.Add(new ControlChangeParameter(96, "Data Button 1 increment"));
        list.Add(new ControlChangeParameter(97, "Data Button 2 increment"));
        list.Add(new ControlChangeParameter(98, "Non Registered Parameter (LSB)"));
        list.Add(new ControlChangeParameter(99, "Non Registered Parameter (MSB)"));
        list.Add(new ControlChangeParameter(100, "Registered Parameter (LSB)"));
        list.Add(new ControlChangeParameter(101, "Registered Parameter (MSB)"));
        list.Add(new ControlChangeParameter(102, "Undefined"));
        list.Add(new ControlChangeParameter(103, "Undefined"));
        list.Add(new ControlChangeParameter(104, "Undefined"));
        list.Add(new ControlChangeParameter(105, "Undefined"));
        list.Add(new ControlChangeParameter(106, "Undefined"));
        list.Add(new ControlChangeParameter(107, "Undefined"));
        list.Add(new ControlChangeParameter(108, "Undefined"));
        list.Add(new ControlChangeParameter(109, "Undefined"));
        list.Add(new ControlChangeParameter(110, "Undefined"));
        list.Add(new ControlChangeParameter(111, "Undefined"));
        list.Add(new ControlChangeParameter(112, "Undefined"));
        list.Add(new ControlChangeParameter(113, "Undefined"));
        list.Add(new ControlChangeParameter(114, "Undefined"));
        list.Add(new ControlChangeParameter(115, "Undefined"));
        list.Add(new ControlChangeParameter(116, "Undefined"));
        list.Add(new ControlChangeParameter(117, "Undefined"));
        list.Add(new ControlChangeParameter(118, "Undefined"));
        list.Add(new ControlChangeParameter(119, "Undefined"));
        list.Add(new ControlChangeParameter(120, "All Sound Off"));
        list.Add(new ControlChangeParameter(121, "All Controllers Off"));
        list.Add(new ControlChangeParameter(122, "Local Keyboard (on/off)"));
        list.Add(new ControlChangeParameter(123, "All Notes Off"));
        list.Add(new ControlChangeParameter(124, "Omni Mode Off"));
        list.Add(new ControlChangeParameter(125, "Omni Mode On"));
        list.Add(new ControlChangeParameter(126, "Mono Operation"));
        list.Add(new ControlChangeParameter(127, "Poly Mode"));


        return list;
    }


}




