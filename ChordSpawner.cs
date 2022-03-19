class ChordSpawner
{
    public Chord Spawn(Chord chord)
    {
        return Random[0, chord.nextChords.Length];
    }
}