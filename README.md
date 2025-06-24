[![Downloads](https://img.shields.io/github/downloads/LaFesta1749/StaffBroadcast/total?label=Downloads&color=333333&style=for-the-badge)](https://github.com/LaFesta1749/StaffBroadcast/releases/latest)
[![Discord](https://img.shields.io/badge/Discord-Join-5865F2?style=for-the-badge&logo=discord&logoColor=white)](https://discord.gg/PTmUuxuDXQ)

# StaffBroadcast (Exiled Plugin)

## 📢 Overview

**StaffBroadcast** allows designated staff members to send predefined broadcast messages in-game using a simple command. It’s lightweight, fast, and ideal for announcements, quick reminders, or important info during gameplay.

---

## 🛠️ Features

* Simple command: `.sb` or `.staffbc`
* Broadcasts a preset message to all players
* Supports role-based permission checks
* Fully customizable message content and duration
* Supports colored, bold, and rich text formatting

---

## ⚙️ Configuration Example

```yaml
is_enabled: true
broadcast_message: "<b><color=red>[STAFF NOTICE]</color></b> Please follow the server rules."
broadcast_duration: 8
allowed_roles:
  - 123456789012345678  # Replace with real Role IDs
  - 987654321098765432
command_aliases:
  - sb
  - staffbc
```

---

## 💬 Usage

Any player with an allowed role can use:

```
.sb
```

or

```
.staffbc
```

This will trigger the predefined message broadcasted to everyone.

---

## 👮 Permission System

Uses `allowed_roles` list from config. Only players with matching Role IDs can use the command. No other permission system required.

---

## 📁 Installation

1. Download the latest `.dll` from [Releases](https://github.com/LaFesta1749/StaffBroadcast/releases).
2. Drop it into your `Exiled/Plugins/` folder.
3. Start the server to auto-generate the config.
4. Edit `Exiled/Configs/StaffBroadcast.yml` to fit your needs.

---

## 👤 Author

Developed by **LaFesta1749**

* GitHub: [LaFesta1749](https://github.com/LaFesta1749)
* Discord: [SCP Bulgaria](https://discord.gg/PTmUuxuDXQ)

---

## 📜 License

This project is open-source and licensed under the [MIT License](LICENSE).
