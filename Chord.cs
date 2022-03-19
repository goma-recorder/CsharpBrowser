class Chord : ScriptableObject
{
	public string Name { get; private set; }
	public Note[] notes;
	public Chord[] nextChords;
}
