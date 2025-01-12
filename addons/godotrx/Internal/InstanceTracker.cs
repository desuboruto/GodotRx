using System;
using System.Collections.Generic;
using Godot;

namespace GodotRx.Internal
{
    internal sealed partial class InstanceTracker : GodotObject
    {
        public const string OnFreedMethod = nameof(OnTrackerFreed);

        private static readonly Dictionary<ulong, InstanceTracker> store = new Dictionary<ulong, InstanceTracker>();

        private readonly int _id;

        private InstanceTracker()
        {
        }

        private InstanceTracker(GodotObject target)
        {
            _id = Singleton.RegisterInstanceTracker(this, target);
        }

        public event Action? Freed;

        public static InstanceTracker Of(GodotObject target)
        {
            var instId = target.GetInstanceId();

            if (!store.TryGetValue(instId, out var tracker))
            {
                tracker = new InstanceTracker(target);
                store[instId] = tracker;
                tracker.Freed += () => store.Remove(instId);
            }

            return tracker;
        }

        public void OnTrackerFreed(int id)
        {
            if (_id == id)
            {
                Freed?.Invoke();
                this.DeferredFree();
            }
        }

        protected override void Dispose(bool disposing)
        {
            // GD.Print("InstanceTracker disposed");
            base.Dispose(disposing);
        }
    }
}