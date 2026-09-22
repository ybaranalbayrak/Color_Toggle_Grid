 Dynamic Button Grid (My First C# Project)

Hi! This is my very first portfolio project. I built this simple application to understand how to create and manage UI elements dynamically using code, rather than just dragging and dropping them in the designer.

What does it do?
    When you run the app, it automatically generates an 11x11 grid (121 buttons in total). If you click on any button, its background color toggles between red and green. 

Screenshot
<img width="556" height="577" alt="image" src="https://github.com/user-attachments/assets/b2e64017-e2a4-492d-a335-f7f0bc762e9b" />

  What I learned from this project
    Since this is my first step, I focused on understanding the core logic. Building this helped me learn:
      - How to generate Windows Forms controls inside a for loop.
      - Using basic math (modulo % and division /) to align items into perfect rows and columns.
      - Connecting 121 different buttons to a single Click event, and figuring out exactly which one was clicked using (Button)sender.
      
Tech Stack
- C#
- Windows Forms
