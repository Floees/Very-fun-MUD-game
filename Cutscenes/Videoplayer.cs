using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using SharpConsoleUI;
using SharpConsoleUI.Builders;
using SharpConsoleUI.Configuration;
using SharpConsoleUI.Controls;
using SharpConsoleUI.Dialogs;
using SharpConsoleUI.Drivers;
using SharpConsoleUI.Helpers;
using SharpConsoleUI.Video;

namespace MUD.Cutscenes
{
    internal class Videoplayer
    {
        public async static Task PlayVideo()
        {

            // 1. Create the window system
            var windowSystem = new ConsoleWindowSystem(
                RenderMode.Buffer,
                options: new ConsoleWindowSystemOptions(
                    TopPanelConfig: panel => panel
                        .Left(),
                    ShowBottomPanel: false));

            // 2. Set up panel text — this appears at the top of the terminal
            windowSystem.PanelStateService.TopStatus =
                "Video Player — Space: Play/Pause | M: Mode | L: Loop | R: Refresh | Esc: Stop";

            // 3. Handle Ctrl+C — shut down cleanly instead of hard-killing the process
            Console.CancelKeyPress += (_, e) =>
            {
                e.Cancel = true;
                windowSystem.Shutdown(0);
            };

            // 4. Build the VideoControl
            //    Fill()        — stretch to use the entire window area
            //    WithOverlay() — bottom status bar appears on key/click, hides after 3s
            //    WithLooping() — restart from the beginning when the video ends
            var videoControl = Controls.Video(@"..\..\..\Cutscenes\videos\truck.mp4")
                .Fill()
                .WithOverlay()
                //.WithLooping()
                .WithRenderMode(VideoRenderMode.HalfBlock)
                .Build();

            // 6. Create the window and open a file picker asynchronously
            //    WithAsyncWindowThread runs a background task tied to the window's lifetime.
            //    The file picker is modal — it blocks this thread but not the UI.
            //    BuildAndShow() creates the Window, registers it with the system, and displays it.
            var window = new WindowBuilder(windowSystem)
                .WithTitle("Video Player")
                .Maximized()
                .WithColors(SharpConsoleUI.Color.White, SharpConsoleUI.Color.Black)
                .Borderless()
                .AddControl(videoControl)
                .BuildAndShow();

            videoControl.Play();
            videoControl.PlaybackEnded += (_, _) =>
            {
                videoControl.Stop();
                videoControl.Dispose();
                windowSystem.Shutdown(0);

                Console.Clear();
            };
            // 7. Clean up when the window closes
            //    Stop() cancels the playback loop; Dispose() kills the FFmpeg process.
            //window.OnClosed += (_, _) =>
            //{
            //    videoControl.Stop();
            //    videoControl.Dispose();
            //};

            // 8. Run the window system — blocks until Shutdown() is called
            await Task.Run(() => windowSystem.Run());
            //return 67;

        }
    }
}
