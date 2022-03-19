class NoteSoundPlayer : MonoBehavior
{
	public Dictionary<(Note, Octave), AudioClip> AudioClips = new();
	public List<AudioSource> UnusedAudioSources = new();
	public Dictionary<(Ulid, AudioSource)> UsedAudioSources = new();
	public Ulid Play(Note note, Octave octave)
	{
		var audioClip = AudioClips[(note, octave)];
		if(UnusedAudioSources.Count == 0)
		{
			UnusedAudioClip.Add(AddComponent<AudioSource>();
		}
		var audioSource = UnusedAudioSources[0];
		audioSource.clip = audioClip;
		audioSource.Play();
		UnusedAudioSources.Removet(0);
        var ulid = Ulid.NewUlid();
		UsedAudiiSources.Add(ulid, audioSource);
	    return ulid;
    }

    public Ulid[] Play(Chord chord)
    {
        var ulids = new Ulid[chord.notes.Count];
        var count = 0;
        foreach(var note in chord.notes)
        {
            var octave = 3;
            ulids[count] = Play(note, octave);
        }
        return ulids;
    }

    public void Stop(Ulid ulid)
    {
        var audioSource = UsedAudiiSources[ulid];
        audioSource.Stop();
        UsedAudiiSources.Remove(ulid);
        UnusedAudioSources.Add(audioSource);
    }

    public void Stop(Ulid[] ulids)
    {
        foreach(var ulid in ulids)
        {
            Stop(ulid);
        }
    }
}