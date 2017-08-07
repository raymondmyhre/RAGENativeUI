﻿namespace RAGENativeUI.Elements
{
    using System;
    using System.Linq;

    using Rage;

    public class TimerBarsManager : IDisposable
    {
        private TimerBarsCollection timerBars;
        /// <exception cref="ArgumentNullException">When setting the property to a null value.</exception>
        public TimerBarsCollection TimerBars { get { return IsDisposed ? throw Common.NewDisposedException() : timerBars; } set { timerBars = IsDisposed ? throw Common.NewDisposedException() : value ?? throw new ArgumentNullException($"The manager {nameof(TimerBars)} collection can't be null."); } }
        public bool IsAnyTimerBarVisible { get { return IsDisposed ? throw Common.NewDisposedException() : timerBars.Any(m => m.IsVisible); } }
        /// <summary>
        /// Gets or sets the Y-coordinate where the first timer bar is drawn.
        /// </summary>
        public float InitialY { get; } = 0.965f; // TODO: implement safezone in TimerBars
        protected internal GameFiber Fiber { get; private set; }
        public bool IsDisposed { get; private set; }

        public TimerBarsManager()
        {
            TimerBars = new TimerBarsCollection();
            Fiber = GameFiber.StartNew(ProcessLoop);
        }

        public void HideAllTimerBars()
        {
            if (IsDisposed)
                throw Common.NewDisposedException();

            foreach (TimerBarBase t in timerBars)
            {
                t.IsVisible = false;
            }
        }

        public void ShowAllTimerBars()
        {
            if (IsDisposed)
                throw Common.NewDisposedException();

            foreach (TimerBarBase t in timerBars)
            {
                t.IsVisible = true;
            }
        }

        private void ProcessLoop()
        {
            while (true)
            {
                GameFiber.Yield();

                OnProcessTimerBars();
            }
        }

        protected virtual void OnProcessTimerBars()
        {
            if (IsDisposed)
                throw Common.NewDisposedException();

            float y = InitialY;
            for (int i = 0; i < timerBars.Count; i++)
            {
                timerBars[i]?.Draw(ref y);
            }
        }

        public void Dispose()
        {
            if (!IsDisposed)
            {
                Fiber?.Abort();
                Fiber = null;
                timerBars = null;
                IsDisposed = true;
            }
        }
    }

    public class TimerBarsCollection : BaseCollection<TimerBarBase>
    {
    }
}
