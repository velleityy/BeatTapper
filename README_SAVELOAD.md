# BeatTapper – Storage Mechanism Write-Up

For BeatTapper, I explored three main storage mechanisms: **key-value storage (PlayerPrefs)**, **JSON file serialization**, and **database/cloud storage**. Each approach offers different benefits depending on the type and scale of data being saved.

### 1. Key-Value Storage (PlayerPrefs)
**Pros:**  
- Very easy to implement and built into Unity.  
- Great for saving small pieces of data like settings or preferences.  
- Fast read/write and automatically persistent between sessions.  

**Cons:**  
- Not ideal for complex or nested data.  
- Limited transparency since it is stored in system-specific locations.  
- Difficult to manage multiple save profiles.  

**Usage in BeatTapper:**  
Used for storing lightweight player preferences such as `volume`, `hitOffset`, and `theme`.

---

### 2. JSON File Serialization
**Pros:**  
- Human-readable, cross-platform, and easy to debug.  
- Can handle structured data like progress, scores, and unlocks.  
- Flexible and easy to expand or version in the future.  

**Cons:**  
- File I/O must be handled carefully to avoid corruption.  
- Slightly slower than key-value methods.  
- Requires path management for different operating systems.  

**Usage in BeatTapper:**  
Stores core player progress such as best scores, accuracy, and unlocked tracks in a single `beattapper_save_v1.json` file.

---

### 3. Database or Cloud Storage (e.g., SQLite, Firebase)
**Pros:**  
- Supports complex queries, leaderboards, and cross-device syncing.  
- Scalable for multiplayer or global competition.  

**Cons:**  
- Requires setup, authentication, and networking.  
- Overkill for local prototypes or small single-player games.  

**Usage in BeatTapper:**  
Not yet implemented, but suitable for future expansion such as online leaderboards or account-based saves.

---

### Final Decision
I chose a **hybrid approach** using **PlayerPrefs** for quick settings and **JSON serialization** for structured progress data.  
This method keeps saves human-readable, reliable, and easy to expand later without adding unnecessary complexity.  
It fits the scope of a small rhythm game prototype while leaving room for future cloud integration.
