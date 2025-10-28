This is an app to use the pomodoro timer technique. 

To use it, please follow these simple steps:

- Clone the repository to your local machine using the command: ```git clone https://github.com/meryem0jerrai/Pomodoro```

- Navigate to the project directory: ```cd Pomodoro\```

- Publish the project using the command: ```dotnet publish -c Release -r win-x64 --self-contained true```

- Navigate to the publish directory: ```cd bin\Release\net9.0-windows\win-x64\publish```

- Run the application using the command: ```.\pomodoro.exe```

Well done, now you can use the pomodoro timer app on your desktop! If you're curious about how I built it, read on.

History of my learning: 

In September 2025, this is my first time creating a desktop app. Here's what I learned so far:

1- Creating a windows interface using Windows Forms App (.NET Framework) in Visual Studio.

2- Connecting the window controls (button, toggle) to the code behind (C#)

3- Using event handlers to trigger actions when buttons are clicked or toggles are changed: In this case, the text box content is cleared if the toggle is checked.

Implemented steps: 

- The coutdown functionality is implemented using a Timer control that ticks every second, updating the display. 

- The stop/start toggle starts and stops the timer.

- The reset button sets the timer back to the initial 25 minutes.

- When the timer reaches zero, a message box notifies the user that the work session is over and it's time for a break.

Observations:

- The timer works as expected, counting down from 25 minutes to zero.

- The start/stop toggle successfully pauses and resumes the countdown.

- The reset button correctly resets the timer to 25 minutes.

- When the timer reaches zero, the message box appears en arrière-en-plan, which goes unnoticed if the user is focused on another window.

- The app takes a lot of CPU/RAM resources, which should be optimized.

Next steps:

- Modify the message box notification to be more prominent, possibly using a system tray notification or sound alert.

- Optimize the app to reduce CPU/RAM usage.

- - Make the interface more user friendly and visually appealing.