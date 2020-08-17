class Note: Equatable {

	var frequency: Double {
		let index = Note.all.index(of: self)! - Note.all.index(of: Note(.a, .natural))!
		return 440.0 * pow(2.0, Double(index) / 12.0)
	}
}

//multiply a note by 2 and you get the next octave, divide it by 2 and you get the previous octave

class Pitch {
    let frequency: Double
    let note: Note
    let octave: Int

    private init(note: Note, octave: Int) {
        self.note = note
        self.octave = octave
        self.frequency = note.frequency * pow(2.0, Double(octave) - 4.0)
    }

    // All the notes from 0th octave to 8th octave.
    static let all = Array((0...8).map { octave -> [Pitch] in
        Note.all.map { note -> Pitch in
            Pitch(note: note, octave: octave)
        }
    }).joined()
}

//interval table:

| Semitone Diff. | Name  |
|----------------|-------|
| 0              | P1    |
| 1              | m2    |
| 2              | M2    |
| 3              | m3    |
| 4              | M3    |
| 5              | P4    |
| 6              | A4/d5 |
| 7              | P5    |
| 8              | m6    |
| 9              | M6    |
| 10             | m7    |
| 11             | M7    |
| 12             | P8    |

//P1 will not appear in the interval training.
