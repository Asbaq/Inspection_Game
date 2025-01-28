
# 📜 Game Documentation: Inspection_Game 🎮

## 📌 Game Title: Inspection_Game  
![Game Image](https://user-images.githubusercontent.com/62818241/201541990-b2c9cab5-f06b-46b5-be22-bc8c0f21f6bc.png)

## 🎨 Art Style
The game follows a **minimalist art style** with **simple and clean designs**. The focus is on fluid animations and vibrant backgrounds to make the gameplay visually engaging. The player’s stick-figure model is animated smoothly with minimalistic features, creating a dynamic yet straightforward visual appeal.

---

## 📖 Game Overview
**Inspection_Game** is an **action-packed survival game** where players face waves of enemies in various procedurally generated levels. The player controls a stick-figure warrior who fights against increasingly difficult enemies. The game emphasizes fluid combat mechanics, strategic movement, and power-up usage.

### 🎯 Objectives
- Battle against waves of enemies using basic combat controls.
- Collect power-ups and upgrades to improve your abilities.
- Survive as long as possible and achieve the highest score.

---

## 🎮 Game Mechanics

### ⚔️ Combat System
- The player performs **melee and ranged attacks** using simple tap and swipe controls.
- **Power-ups** can be collected to enhance the player’s abilities (e.g., damage boosts, health regeneration).
- The combat system features smooth animations and fluid transitions between movement and attacks.

### 🚶 Movement System
- The player **moves using swipe gestures** for walking in various directions.
- The camera follows the player with **smooth movement** to create a seamless experience.
- The **player body rotates** based on mouse or touch input.

### 🎮 Game Interaction System
- **UI elements** such as health, score, and wave counters are visible during gameplay.
- The canvas can be toggled using in-game interactions, such as clicking or tapping.

---

## 🛠️ Script Documentation

### 🎮 **CameraLook.cs**
Handles **camera movement and player rotation** based on mouse input.

```csharp
public class CameraLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Horizontal2") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Vertical2") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
```

### 🎮 **Game_Manager.cs**
Manages **UI elements** and player interactions with the game.

```csharp
public class Game_Manager : MonoBehaviour
{
    public GameObject Canvas;

    public void PlayGame()
    {
        Canvas.SetActive(false);
    }

    private void OnMouseDown()
    {
        Canvas.SetActive(true);
    }
}
```

### 🚶 **PlayerMovement.cs**
Handles **player movement** using keyboard input and the character controller.

```csharp
public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }
}
```

---

## 🏗️ Features & Future Improvements

✅ **Simple combat and movement system**  
✅ **Procedurally generated levels**  
✅ **Power-up and upgrade mechanics**  
🔜 **Multiplayer support for co-op gameplay**  
🔜 **AI enemies with enhanced behavior**  
🔜 **Advanced power-up system**  
🔜 **Improved UI and menus**  

---

## 📌 Conclusion
**Inspection_Game** offers a fast-paced and dynamic gaming experience, with **smooth animations**, **minimalistic visuals**, and **simple yet engaging combat mechanics**. Players can enjoy battling waves of enemies while collecting power-ups and surviving longer. The game will receive future updates with **enhanced gameplay**, **multiplayer features**, and **AI improvements**. 🚀🎮
