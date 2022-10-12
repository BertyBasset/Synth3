// Class to abstract Notes on a keyboard, and provide corresponding frequecny

namespace Synth.Properties;

public class Note {
    #region Public Properties
    public int ID { get; set; } 
    public string Desc { get; set; } = "";
    public float Frequency { get; set; } = 0;
    #endregion

    #region Overrides
    public override string ToString() {
        return Desc;
    }
    #endregion

    #region Public Methods
    public static Note GetByDesc(string Desc) {
        return GetNoteList().Where(n => n.Desc.ToUpper() == Desc.ToUpper()).First();
    }

    public static Note GetByID(int ID) {
        return GetNoteList().Where(n => n.ID == ID).First();
    }

    public static List<Note> GetNoteList() {
        var notes = new List<Note>();
        notes.Add(new Note() { ID = -8, Desc = "C♯-1/D♭-1" });
        notes.Add(new Note() { ID = -7, Desc = "C♯0/D♭0" });
        notes.Add(new Note() { ID = -6, Desc = "D0" });
        notes.Add(new Note() { ID = -5, Desc = "D♯0E♭0" });
        notes.Add(new Note() { ID = -4, Desc = "E0" });
        notes.Add(new Note() { ID = -3, Desc = "F0" });
        notes.Add(new Note() { ID = -2, Desc = "F♯0G♭0" });
        notes.Add(new Note() { ID = -1, Desc = "G0" });
        notes.Add(new Note() { ID = 0, Desc = "G♯0A♭0" });
        notes.Add(new Note() { ID = 1, Desc = "A0" }); ;
        notes.Add(new Note() { ID = 2, Desc = "A♯0/B♭0" });
        notes.Add(new Note() { ID = 3, Desc = "B0" }); ;

        notes.Add(new Note() { ID = 4, Desc = "C1" }); ;
        notes.Add(new Note() { ID = 5, Desc = "C♯1/D♭1" });
        notes.Add(new Note() { ID = 6, Desc = "D1" });
        notes.Add(new Note() { ID = 7, Desc = "D♯1E♭1" });
        notes.Add(new Note() { ID = 8, Desc = "E1" });
        notes.Add(new Note() { ID = 9, Desc = "F1" });
        notes.Add(new Note() { ID = 10, Desc = "F♯1G♭1" });
        notes.Add(new Note() { ID = 11, Desc = "G1" });
        notes.Add(new Note() { ID = 12, Desc = "G♯1A♭1" });
        notes.Add(new Note() { ID = 13, Desc = "A2" });
        notes.Add(new Note() { ID = 14, Desc = "A♯2B♭2" });
        notes.Add(new Note() { ID = 15, Desc = "B2" });

        notes.Add(new Note() { ID = 16, Desc = "C2" }); ;
        notes.Add(new Note() { ID = 17, Desc = "C♯2/D♭2" });
        notes.Add(new Note() { ID = 18, Desc = "D2" });
        notes.Add(new Note() { ID = 19, Desc = "D♯2E♭2" });
        notes.Add(new Note() { ID = 20, Desc = "E2" });
        notes.Add(new Note() { ID = 21, Desc = "F2" });
        notes.Add(new Note() { ID = 22, Desc = "F♯2G♭2" });
        notes.Add(new Note() { ID = 23, Desc = "G2" });
        notes.Add(new Note() { ID = 24, Desc = "G♯2A♭2" });
        notes.Add(new Note() { ID = 25, Desc = "A3" });
        notes.Add(new Note() { ID = 26, Desc = "A♯3B♭3" });
        notes.Add(new Note() { ID = 27, Desc = "B3" });

        notes.Add(new Note() { ID = 28, Desc = "C3" }); ;
        notes.Add(new Note() { ID = 29, Desc = "C♯3/D♭3" });
        notes.Add(new Note() { ID = 30, Desc = "D3" });
        notes.Add(new Note() { ID = 31, Desc = "D♯3E♭3" });
        notes.Add(new Note() { ID = 32, Desc = "E3" });
        notes.Add(new Note() { ID = 33, Desc = "F3" });
        notes.Add(new Note() { ID = 34, Desc = "F♯3G♭3" });
        notes.Add(new Note() { ID = 35, Desc = "G3" });
        notes.Add(new Note() { ID = 36, Desc = "G♯3A♭2" });
        notes.Add(new Note() { ID = 37, Desc = "A4" });
        notes.Add(new Note() { ID = 38, Desc = "A♯4B♭4" });
        notes.Add(new Note() { ID = 39, Desc = "B4" });

        notes.Add(new Note() { ID = 40, Desc = "C4" }); ;
        notes.Add(new Note() { ID = 41, Desc = "C♯4/D♭4" });
        notes.Add(new Note() { ID = 42, Desc = "D4" });
        notes.Add(new Note() { ID = 43, Desc = "D♯4E♭4" });
        notes.Add(new Note() { ID = 44, Desc = "E4" });
        notes.Add(new Note() { ID = 45, Desc = "F4" });
        notes.Add(new Note() { ID = 46, Desc = "F♯4G♭4" });
        notes.Add(new Note() { ID = 47, Desc = "G4" });
        notes.Add(new Note() { ID = 48, Desc = "G♯4A♭4" });
        notes.Add(new Note() { ID = 49, Desc = "A5" });
        notes.Add(new Note() { ID = 50, Desc = "A♯5B♭5" });
        notes.Add(new Note() { ID = 51, Desc = "B5" });
        notes.Add(new Note() { ID = 52, Desc = "C5" });

        notes.Add(new Note() { ID = 53, Desc = "C♯5/D♭5" });
        notes.Add(new Note() { ID = 54, Desc = "D5" });
        notes.Add(new Note() { ID = 55, Desc = "D♯5E♭5" });
        notes.Add(new Note() { ID = 56, Desc = "E5" });
        notes.Add(new Note() { ID = 57, Desc = "F5" });
        notes.Add(new Note() { ID = 58, Desc = "F♯5G♭5" });
        notes.Add(new Note() { ID = 59, Desc = "G5" });
        notes.Add(new Note() { ID = 60, Desc = "G♯5A♭5" });
        notes.Add(new Note() { ID = 61, Desc = "A6" });
        notes.Add(new Note() { ID = 62, Desc = "A♯6B♭6" });
        notes.Add(new Note() { ID = 63, Desc = "B6" });
        notes.Add(new Note() { ID = 64, Desc = "C6" });

        notes.Add(new Note() { ID = 65, Desc = "C♯6/D♭6" });
        notes.Add(new Note() { ID = 66, Desc = "D6" });
        notes.Add(new Note() { ID = 67, Desc = "D♯6E♭6" });
        notes.Add(new Note() { ID = 68, Desc = "E6" });
        notes.Add(new Note() { ID = 69, Desc = "F6" });
        notes.Add(new Note() { ID = 70, Desc = "F♯6G♭6" });
        notes.Add(new Note() { ID = 71, Desc = "G6" });
        notes.Add(new Note() { ID = 72, Desc = "G♯6A♭6" });
        notes.Add(new Note() { ID = 73, Desc = "A7" });
        notes.Add(new Note() { ID = 74, Desc = "A♯7B♭7" });
        notes.Add(new Note() { ID = 75, Desc = "B7" });
        notes.Add(new Note() { ID = 76, Desc = "C7" });


        notes.Add(new Note() { ID = 77, Desc = "C♯7/D♭7" });
        notes.Add(new Note() { ID = 78, Desc = "D7" });
        notes.Add(new Note() { ID = 79, Desc = "D♯7E♭7" });
        notes.Add(new Note() { ID = 80, Desc = "E7" });
        notes.Add(new Note() { ID = 81, Desc = "F7" });
        notes.Add(new Note() { ID = 82, Desc = "F♯7G♭7" });
        notes.Add(new Note() { ID = 83, Desc = "G7" });
        notes.Add(new Note() { ID = 84, Desc = "G♯7A♭7" });
        notes.Add(new Note() { ID = 85, Desc = "A8" });
        notes.Add(new Note() { ID = 86, Desc = "A♯8B♭8" });
        notes.Add(new Note() { ID = 87, Desc = "B8" });
        notes.Add(new Note() { ID = 88, Desc = "C8" });

        notes.Add(new Note() { ID = 89, Desc = "C♯8/D♭8" });
        notes.Add(new Note() { ID = 90, Desc = "D8" });
        notes.Add(new Note() { ID = 91, Desc = "D♯8E♭8" });
        notes.Add(new Note() { ID = 92, Desc = "E8" });
        notes.Add(new Note() { ID = 93, Desc = "F7" });
        notes.Add(new Note() { ID = 94, Desc = "F♯8G♭8" });
        notes.Add(new Note() { ID = 95, Desc = "G8" });
        notes.Add(new Note() { ID = 96, Desc = "G♯8A♭8" });
        notes.Add(new Note() { ID = 97, Desc = "A9" });
        notes.Add(new Note() { ID = 98, Desc = "A♯9B♭9" });
        notes.Add(new Note() { ID = 99, Desc = "B9" });
        notes.Add(new Note() { ID =100, Desc = "C9" });

        // Set frequencies taking fixed frequency of 440Hz for A4
        var A4f = 440;       // Fix this frequency
        var A4ID = 49;       // ID from list above
        foreach (var note in notes) {
            int steps = note.ID - A4ID;
            note.Frequency = (float)(A4f * Math.Pow(Math.Pow(2, 1f / 12f), steps));
        }

        return notes;
    }
    #endregion
}
