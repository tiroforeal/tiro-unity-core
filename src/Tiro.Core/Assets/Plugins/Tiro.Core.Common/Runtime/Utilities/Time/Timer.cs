using System;

namespace Tiro.Core.Common.Utilities.Time {
    public abstract class Timer {
        protected float InitialTime;
        protected float Time { get; set; }
        public bool IsRunning { get; protected set; }

        public float Progress => InitialTime <= 0f 
            ? 0f
            : Math.Max(0f, Math.Min(1f, Time / InitialTime));

        public Action OnTimerStart = delegate { };
        public Action OnTimerStop = delegate { };

        protected Timer(float value) {
            InitialTime = value;
            IsRunning = false;
        }

        public void Start() {
            Time = InitialTime;
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
}