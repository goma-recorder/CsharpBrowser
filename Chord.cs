class Chord : ScriptableObject
{
	public string Name { get; private set; }
	public Note[] notes = new ();
	public Chord[] nextChords = new();
}
