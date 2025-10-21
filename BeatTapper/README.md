# BeatTapper — Project Proposal

## Elevator Pitch (≤100 words)

**BeatTapper** is a rhythm game where your actions *become* the music. Tap, hold, and swipe to visual cues that sync with each track’s beat. Landing notes on time builds your combo and flow; misses distort the visuals and audio, pushing you to recover. The fun comes from that perfect moment when you’re completely in rhythm — it feels like performing the song rather than just playing it. Chase high scores, unlock new tracks and themes, and master tougher patterns built around timing, precision, and self-expression.  

_Word count: 97_

---

## Game Synopsis, Objective, and Mechanics

### **Synopsis**
BeatTapper is a fast-paced, music-driven rhythm game built around timing, feedback, and flow. Players tap in sync with beats across various tracks to maintain rhythm, score combos, and unlock visual effects that react dynamically to performance.

### **Objectives**
- **Progression:** Clear songs to unlock new tracks, backgrounds, and difficulty modes.  
- **Challenge:** Earn S/A/B ranks and maintain long combo streaks through precision.  
- **Practice:** Use slower playback or lane-isolation to train timing consistency.

### **Core Mechanics**
- **Inputs:** Tap, hold, or swipe across a 4-lane beat highway aligned to music tempo.  
- **Scoring:** Perfect / Great / Good / Miss ratings, with combo multipliers and accuracy ranks.  
- **Feedback:** On-beat hits trigger lights and music syncs; misses cause distortion or dim effects.  
- **Flow:** The hit window slightly expands after multiple misses and tightens again as players recover.  

### **Gameplay Loop**
1. Select a song and difficulty.  
2. Match beat cues with perfect timing.  
3. Build combos and score multipliers.  
4. Earn rewards, unlock new visuals, and chase mastery.

---

## 🧩 Conceptual Mock-ups

### **Splash Screen**
![Splash Screen](mockups/mockup_01_title.png)

### **Gameplay**
![Gameplay](mockups/mockup_02_gameplay.png)

### **Results Screen**
![Results](mockups/mockup_03_results.png)

---

## ⚙️ Implementation Notes

- **Engine:** Unity or Godot (60 FPS fixed timestep).  
- **Beatmaps:** JSON-based files with millisecond offsets for each note.  
- **System Flow:** Input → Judgement → Scoring → Feedback → Visual Effects.  
- **Prototype Scope:** One track, placeholder graphics, calibration settings, basic results screen.  

---

© 2025 BeatTapper — Elaine Hsu
