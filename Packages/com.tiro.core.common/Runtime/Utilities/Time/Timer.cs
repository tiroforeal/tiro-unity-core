using System;

namespace Tiro.Core.Common.Utilities.Time;

public abstract class Timer {
    protected float initialTime;
    protected float Time { get; set; }
    public bool IsRunning { get; protected set; }

    public float Progress
    {
        get {
            if (initialTime <= 0f) return 0f;
            return Math.Max(0f, Math.Min(1f, Time / initialTime));
        }
    }
    
    public UnityAction OnTimerStart = delegate { };
    public UnityAction OnTimerStop = delegate { };

    protected Timer(float value) {
        initialTime = value;
        IsRunning = false;
    }

    public void Start() {
        Time = initialTime;
        if (!IsRunning) {
            IsRunning = true;
            OnTimerStart.Invoke();
        }
    }

    public void Stop() {
        if (IsRunning) {
            IsRunning = false;
            OnTimerStop.Invoke();
        }
    }
    
    public void Resume() => IsRunning = true;
    public void Pause() => IsRunning = false;
    
    public abstract void Tick(float deltaTime);
}