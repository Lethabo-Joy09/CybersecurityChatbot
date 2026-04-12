# Cybersecurity Awareness Chatbot

## 📌 Project Overview
This project is a console-based Cybersecurity Awareness Chatbot developed in C#.  
The chatbot is designed to educate users about online safety by providing useful tips on topics such as password security, phishing, safe browsing, and two-factor authentication.

---

## 🎯 Features
- Interactive chatbot conversation
- Personalised user greeting
- ASCII art welcome screen
- Audio greeting playback
- Keyword-based response system
- Cybersecurity tips and advice
- Input validation and error handling
- Exit commands (exit, quit, bye)
- Clean and styled console UI with typing effect

---

## 🧱 Project Structure
The project is divided into multiple classes for better organisation:

### Program.cs
- Entry point of the application
- Initializes all services
- Controls the program flow

### ChatbotService.cs
- Handles the main chat loop
- Processes user input
- Manages exit conditions

### ResponseHandler.cs
- Contains chatbot logic
- Matches user input with keywords
- Returns appropriate responses

### ChatResponse.cs
- Data model for chatbot responses
- Stores category, keywords, and response text

### UIResponder.cs
- Handles all console UI elements
- Displays messages, colours, ASCII art, and typing effect

### AudioService.cs
- Plays the greeting audio file
- Handles errors if the file is missing

---

## 🔊 Audio Setup
- Place the `greeting.wav` file inside an **Audio** folder in the project directory
- Set the file property:
  - **Copy to Output Directory → Copy if newer**

---

## ▶️ How to Run the Program
1. Open the project in Visual Studio
2. Build the solution
3. Run the program using:
   - **F5** (Start with debugging), or
   - **Ctrl + F5** (Start without debugging)

---

## 💬 Example Questions
Users can ask:
- "How are you?"
- "What can you do?"
- "Password safety tips"
- "How to detect phishing?"
- "Safe browsing tips"
- "What is 2FA?"

---

## ⚠️ Input Validation
- Prevents empty input
- Displays error messages for invalid input
- Provides a default response for unknown queries

---

## 🚪 Exit Commands
To exit the chatbot, type:
- exit
- quit
- bye

---

## 🎥 Demo
A demonstration video is included showing:
- Program execution
- User interaction
- Explanation of code structure

---

## 📌 Conclusion
This chatbot demonstrates the use of:
- Object-Oriented Programming (OOP)
- Classes and methods
- Lists and arrays
- Loops and conditions
- Basic UI design in console applications

It provides a simple but effective way to educate users about cybersecurity awareness.

---

## 👩‍💻 Author
Lethabo Joy Seemola
