This is an app to use the pomodoro timer technique. 

To use it, please follow these simple steps:

- Clone the repository to your local machine using the command: git clone https://github.com/meryem0jerrai/Pomodoro

- Navigate to the project directory: cd repos/pomodoro

- Publish the project using the command: dotnet publish -c Release -r win-x64 --self-contained true

- Navigate to the publish directory: cd bin/Release/net9.0/win-x64/publish

- Run the application using the command: ./pomodoro.exe

Well done, now you can use the pomodoro timer app on your desktop! If you're curious about how I built it, read on.

History of my learning: 

September 2025: This is my first time creating a desktop app, here's what I learned so far:

1- Creating a windows interface using Windows Forms App (.NET Framework) in Visual Studio.

2- Connecting the window controls (button, toggle) to the code behind (C#)

3- Using event handlers to trigger actions when buttons are clicked or toggles are changed: In this case, the text box content is cleared if the toggle is checked.

Implemented steps: 

- The coutdown functionality is implemented using a Timer control that ticks every second, updating the display. 

- The stop/start toggle starts and stops the timer.

- The reset button sets the timer back to the initial 25 minutes.

Next steps:

- Make the interface more user friendly and visually appealing.

- Add sound notifications when a work session ends and a break begins.