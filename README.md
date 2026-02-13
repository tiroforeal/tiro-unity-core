# Tiro Unity Core

Core utilities and foundational systems for Unity projects.

This package is designed to provide reusable, scalable, and clean architecture components such as:

- Timers
- Utilities
- Common abstractions
- Core runtime helpers

The package follows a clean architecture approach:
- Core logic is separated from gameplay code
- Minimal Unity dependencies
- Designed for reuse across multiple projects

---

## Installation (UPM via Git)

Add the package to your Unity project via:

### Option 1 — Package Manager (Git URL)

1. Open **Unity Package Manager**
2. Click the **+** button
3. Select **Add package from git URL**
4. Paste:

`https://github.com/tiroforeal/tiro-unity-core.git?path=src/Tiro.Core/Assets/Plugins/Tiro.Core`

### Option 2 — manifest.json

Add this under `dependencies`:

`"com.tiro.core: "https://github.com/tiroforeal/tiro-unity-core.git?path=src/Tiro.Core/Assets/Plugins/Tiro.Core"`

---

## Requirements

- Unity 2022.3 or newer (recommended)
- UniTask 2.2.5 or newer (recommended)
