using System;
using System.Timers;

namespace MonProjetWPF;

public class PomodoroTimer {
    private System.Timers.Timer timer;
    private int timeLeft;
    private int restTimeLeft;
    private bool isResting = false; // Track si periode de repos
    private bool isPaused = false; // Track si le timer est en pause


    public event Action<string> OnTimeUpdated;

    public PomodoroTimer() {
        timeLeft = 25 * 60; // 25 minutes mis en secondes car il le faut
        restTimeLeft = 5 * 60; // 5 minutes mis en secondes car il le faut
        timer = new System.Timers.Timer(1000); // Permet de refesh toutes les secondes (1000 ms = 1 sec)
        timer.Elapsed += TimerTick;
    }

    private void TimerTick(object sender, ElapsedEventArgs e) {
        if (isResting) {
            if (restTimeLeft > 0) {
                restTimeLeft--;
                OnTimeUpdated?.Invoke($"Il vous reste {restTimeLeft / 60:D2}:{restTimeLeft % 60:D2} de repos");
            } else {
                timer.Stop();
                OnTimeUpdated?.Invoke("Fin du repos reprise du travail");
                StartWork(); // Lance la période de travail après le repos
            }
        } else {
            if (timeLeft > 0) {
                timeLeft--;
                OnTimeUpdated?.Invoke($"il vous reste {timeLeft / 60:D2}:{timeLeft % 60:D2} de travail");
            } else {
                timer.Stop();
                OnTimeUpdated?.Invoke("Début du repos");
                StartRest(); // Lance la période de repos après le travail
            }
        }
    }

    public void StartWork() {
        isResting = false;
        timeLeft = 25 * 60; // Réinitialisation
        timer.Start();
    }

    public void StartRest() {
        isResting = true;
        restTimeLeft = 5 * 60; // Réinitialisation
        timer.Start();
    }

    public void Reset() {
        timer.Stop();
        timeLeft = 25 * 60;
        restTimeLeft = 5 * 60;
        OnTimeUpdated?.Invoke("Vous avez 25:00 de travail et 05:00 de repos");
    }
    
    public void Pause() {
        if (!isPaused)
        {
            timer.Stop();
            isPaused = true;
        }
    }

    public void Resume() {
        if (isPaused)
        {
            timer.Start();
            isPaused = false;
        }
    }
}
