# 🥽 XR Home Interface — Passthrough Simulation

A Unity-based XR-style home interface featuring interactive system controls, live date and time, simulated passthrough behaviour, and webcam-based environment simulation.

> 🎮 Built with Unity and C# with a focus on interactive UI, runtime systems, modular scripting, and XR-inspired experiences.

---

## ✨ Overview

This project explores the design of an **XR-style home interface** inspired by system menus used in immersive environments.

The interface brings together application shortcuts, system controls, live information, and a passthrough mode within a single interactive screen.

Because real XR passthrough hardware cannot be directly visualized in the Unity Editor, the project includes a **webcam-based passthrough simulation** that allows the concept to be demonstrated on a standard computer.

---

## 🎮 Features

### 🏠 XR-Style Home Screen
- Unified home screen inspired by XR system interfaces
- Interactive application buttons
- Brightness controls
- Volume controls
- Clean and minimal UI layout

### 🕒 Live Date & Time
- Displays the current system date and time
- Automatically updates at runtime
- Requires no manual refresh

### 👁️ Passthrough Toggle
- Interactive passthrough ON/OFF toggle
- Simulates OpenXR passthrough behaviour
- Logs the current passthrough state at runtime

### 📷 Webcam Passthrough Simulation
- Uses Unity's `WebCamTexture`
- Displays the webcam feed as the background when passthrough is enabled
- Stops and hides the webcam feed when passthrough is disabled
- Provides a hardware-independent way to demonstrate the passthrough concept

---

## 🛠️ Tech Stack

| Technology | Usage |
|------------|-------|
| **Unity** | Application and interface development |
| **C#** | Runtime and interaction logic |
| **WebCamTexture** | Webcam-based passthrough simulation |
| **Unity Canvas UI** | Interface and user interaction |
| **OpenXR Concepts** | Simulated passthrough behaviour |
| **Git / GitHub** | Version control |

---

## 🧩 High-Level Structure

```text
XR Home Interface
│
├── Home Screen UI
│   ├── Application Buttons
│   ├── Brightness Controls
│   └── Volume Controls
│
├── System Information
│   └── Live Date & Time
│
├── Passthrough System
│   ├── Toggle State
│   └── Simulated OpenXR Behaviour
│
└── Webcam Simulation
    ├── WebCamTexture
    ├── Background Display
    └── Enable / Disable Logic
