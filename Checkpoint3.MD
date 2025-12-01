# BeatTapper – Playtesting Report

## Playtesting Questions

1. How clear were the controls and basic mechanics when you first started playing?  
2. Did the timing of the notes and music feel accurate, or did anything feel “off”?  
3. How did you feel about the difficulty level of the current track (too easy, too hard, or about right)?  
4. Did the visual and audio feedback (hit effects, sound effects, UI) help you understand how well you were doing?  
5. Was the UI (menus, results screen, layout) easy to navigate and understand?  
6. What was the most fun part of the game for you?  
7. If you could change one thing about the prototype right now, what would it be?

---

## Feedback from Three Testers

### Tester 1
- Controls were easy to understand after a short explanation, but wanted an in-game tutorial.  
- Timing felt mostly good but a few notes seemed early/late.  
- Difficulty was “slightly hard for a first track.”  
- Hit/miss feedback worked but wanted bigger effects during long streaks.  
- UI was clear, but results screen could give more detail.

### Tester 2
- Understood the goal quickly, but the judgement system (Perfect/Great/Good) wasn’t obvious at first.  
- Timing felt off when the frame rate dipped.  
- Difficulty felt uneven, with sudden spikes.  
- Wanted clearer visual separation between notes and background.  
- Suggested making Retry/Continue options more noticeable.

### Tester 3
- Concept was clear, but lane-to-key mapping took a couple of tries.  
- Timing felt “good overall,” but requested an audio latency calibration option.  
- Prototype felt short; wanted more tracks or difficulty levels.  
- Combo system was fun, but misses felt too subtle—wanted stronger feedback.  
- UI was clean but could use more personality or theme.

---

## Summary of Findings and Common Patterns

- **Timing accuracy is a major concern.** Even small sync issues were immediately noticeable, and testers wanted calibration options or more consistent hit windows.
- **Onboarding needs improvement.** Everyone understood the basic idea, but still desired clearer instructions, an initial tutorial, or a reminder of the keyboard mapping.
- **Difficulty pacing and feedback need refinement.** Testers agreed the track had uneven difficulty spikes and that positive/negative feedback could be more expressive.
- **UI is functional but could be more detailed or visually engaging.** Menus worked, but players wanted richer results information and clearer visual identity.
The core idea works and is fun, but the experience depends heavily on timing polish, clearer onboarding, and stronger feedback.

---

## Comparison With AI Feedback (ChatGPT – GPT-5.1)

I also asked ChatGPT (GPT-5.1) for feedback on the design. Its suggestions aligned with the human testers in several ways:

- Both emphasized that **timing feel** is the most important aspect and must be prioritized.  
- The AI specifically recommended using fixed timestep logic, precomputed beat timings, and avoiding frame-dependent calculations — the technical version of what testers described as “timing felt off.”  
- Both the AI and testers highlighted the need for **clear, immediate feedback** on hits, misses, and combos.  
- The AI stressed **scope control** (focus on one polished track first), while human testers naturally focused more on how the game felt and how easy it was to learn.

Combining the AI’s technical perspective with the testers’ experiential feedback gives a clear direction:  
1. Improve timing stability and add calibration.
2. Improve onboarding and clarity of the judgement system.  
3. Strengthen hit/miss feedback and refine difficulty pacing.  
4. Polish UI as time allows, without expanding the feature scope too much.
Both sources agree on the core issue, **BeatTapper succeeds or fails based on timing and clarity**, so those will be my top priorities moving forward.
