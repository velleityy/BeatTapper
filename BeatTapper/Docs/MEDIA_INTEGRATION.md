# BeatTapper – Media Integration

This prototype integrates persistent background music, short sound effects, triggered music, and triggered video.

- Persistent background music is handled by a global `AudioManager` (singleton with `DontDestroyOnLoad`) that plays a looped BGM track across scenes.
- Short sound effects (hit, miss, button click) are played using `AudioManager.PlaySFX()` with clips under 10 seconds.
- Triggered music for a full track is started by `MusicTrigger.StartSong()`, which stops menu BGM and plays the main song when the player begins a run.
- Triggered video is implemented with Unity’s `VideoPlayer` and a `VideoTrigger` script that plays an intro clip when entering the scene or pressing a button.

All related scripts, audio clips, and video files are included in this repository and referenced by the Unity scenes used in the prototype.
