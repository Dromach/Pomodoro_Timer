using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Timers;

namespace MonProjetWPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {

    private PomodoroTimer pomodoro;

    public MainWindow() {
        InitializeComponent();
        pomodoro = new PomodoroTimer();
        pomodoro.OnTimeUpdated += UpdateTimerUI;
    }

    private void UpdateTimerUI(string time) {
        Dispatcher.Invoke(() => lblTimer.Text = time);
    }

    private void Start_Click(object sender, RoutedEventArgs e) {
        pomodoro.StartWork();
    }

    private void Reset_Click(object sender, RoutedEventArgs e) {
        pomodoro.Reset();
    }

    private void Pause_Click(object sender, RoutedEventArgs e) {
        pomodoro.Pause();
    }

    private void Resume_Click(object sender, RoutedEventArgs e) {
        pomodoro.Resume();
    }
}