# TAMIZH XR Home Interface – Passthrough Simulation

## Overview

This project is a Unity-based implementation of an **XR-style Home Screen Interface** with **passthrough simulation**.

The focus of the project is on **UI interaction**, **runtime system updates**, and **clear separation of logic**, rather than hardware-dependent XR features.

---

## Problem Statement

The objective was to design a single home screen similar to an XR system menu that includes:

* Multiple app buttons (dummy apps allowed)
* Volume and brightness controls
* A passthrough toggle
* Live system date and time that updates automatically at runtime

Since real XR passthrough cannot be visualized in the Unity Editor, the project also required a **visual simulation** for non-XR systems.

---

## Key Features

### 1. XR-Style Home Screen UI

* Single unified home screen layout
* Dummy app buttons to simulate an XR menu
* Brightness controls implemented at the UI level
* Clean and minimal interface design

---

### 2. Live Date & Time

* Displays the **current system date and time**
* Updates automatically at runtime
* No manual refresh or button-based update is used

---

### 3. Passthrough Toggle (OpenXR Logic – Simulated)

* A single passthrough toggle button
* Logs clear **ON / OFF states** in the console to simulate OpenXR passthrough behavior
* Designed to be hardware-independent

---

### 4. Webcam-Based Passthrough Simulation

* Uses Unity’s `WebCamTexture`
* Webcam feed appears as a background when passthrough is enabled
* Webcam feed stops and hides when passthrough is disabled
* Controlled by the same passthrough toggle button

---

## Technical Approach

* **Unity Engine** with C#
* UI implemented using Unity’s Canvas system
* Runtime logic handled through modular C# scripts
* Passthrough logic and webcam simulation are kept separate for clarity
* Designed to be easily extendable for real XR hardware in the future

---
