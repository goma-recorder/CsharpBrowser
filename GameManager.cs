class GameManager
{
    ChordSpawner chordSpawner;
    Queue<Chord> chords = new();
    int firstStageCount = 5;
    Chord firstChord;
    float delayTime = 2;
    void Start()
    {
        var lastChord = firstChord;
        for(var i =0; i < 0; i++)
        {
            lastChord = chordSpawner.Spawn(lastChord);
            
        }
    }
}