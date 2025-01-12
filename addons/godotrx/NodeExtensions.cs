using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;
using Godot;
using GodotRx.Internal;

namespace GodotRx
{
    public static class NodeExtensions
    {
        #region Lifecycle

        public static IObservable<double> OnProcess(this Node node)
        {
            return node.GetNodeTracker().OnProcess;
        }

        public static IObservable<double> OnPhysicsProcess(this Node node)
        {
            return node.GetNodeTracker().OnPhysicsProcess;
        }

        public static IObservable<InputEvent> OnInput(this Node node)
        {
            return node.GetNodeTracker().OnInput;
        }

        public static IObservable<InputEvent> OnUnhandledInput(this Node node)
        {
            return node.GetNodeTracker().OnUnhandledInput;
        }

        public static IObservable<InputEvent> OnUnhandledKeyInput(this Node node)
        {
            return node.GetNodeTracker().OnUnhandledKeyInput;
        }

        private static NodeTracker GetNodeTracker(this Node node)
        {
            var tracker = node.GetNodeOrNull<NodeTracker>(NodeTracker.DefaultName);

            if (tracker == null)
            {
                tracker = new NodeTracker
                {
                    Name = NodeTracker.DefaultName
                };
                node.AddChild(tracker);
            }

            return tracker;
        }

        #endregion

        #region Input

        public static IObservable<InputEventMouseButton> OnMouseDown(this Node node,
            MouseButton button = MouseButton.Left)
        {
            return node.OnMouseButtonEvent(false, button, true);
        }

        public static IObservable<InputEventMouseButton> OnMouseUp(this Node node,
            MouseButton button = MouseButton.Left)
        {
            return node.OnMouseButtonEvent(false, button, false);
        }

        public static IObservable<InputEventMouseButton> OnUnhandledMouseDown(this Node node,
            MouseButton button = MouseButton.Left)
        {
            return node.OnMouseButtonEvent(true, button, true);
        }

        public static IObservable<InputEventMouseButton> OnUnhandledMouseUp(this Node node,
            MouseButton button = MouseButton.Left)
        {
            return node.OnMouseButtonEvent(true, button, false);
        }

        private static IObservable<InputEventMouseButton> OnMouseButtonEvent(this Node node, bool unhandled,
            MouseButton button, bool pressed)
        {
            return (unhandled ? node.OnUnhandledInput() : node.OnInput())
                .OfType<InputEvent, InputEventMouseButton>()
                .Where(ev => ev.ButtonIndex == button && ev.Pressed == pressed);
        }

        public static IObservable<InputEventKey> OnKeyPressed(this Node node, Key key)
        {
            return node.OnKeyEvent(false, key, true, null);
        }

        public static IObservable<InputEventKey> OnKeyReleased(this Node node, Key key)
        {
            return node.OnKeyEvent(false, key, false, null);
        }

        public static IObservable<InputEventKey> OnKeyJustPressed(this Node node, Key key)
        {
            return node.OnKeyEvent(false, key, true, false);
        }

        public static IObservable<InputEventKey> OnUnhandledKeyPressed(this Node node, Key key)
        {
            return node.OnKeyEvent(true, key, true, null);
        }

        public static IObservable<InputEventKey> OnUnhandledKeyReleased(this Node node, Key key)
        {
            return node.OnKeyEvent(true, key, false, null);
        }

        public static IObservable<InputEventKey> OnUnhandledKeyJustPressed(this Node node, Key key)
        {
            return node.OnKeyEvent(true, key, true, false);
        }

        private static IObservable<InputEventKey> OnKeyEvent(this Node node, bool unhandled, Key key, bool pressed,
            bool? echo)
        {
            return (unhandled ? node.OnUnhandledInput() : node.OnInput())
                .OfType<InputEvent, InputEventKey>()
                .Where(ev => ev.Keycode == key && ev.Pressed == pressed && (echo == null || ev.Echo == echo));
        }

        public static IObservable<Unit> OnActionPressed(this Node node, string action)
        {
            return node.OnProcess()
                .Where(_ => Input.IsActionPressed(action))
                .Select(_ => new Unit());
        }

        public static IObservable<Unit> OnActionJustPressed(this Node node, string action)
        {
            return node.OnProcess()
                .Where(_ => Input.IsActionJustPressed(action))
                .Select(_ => new Unit());
        }

        public static IObservable<Unit> OnActionJustReleased(this Node node, string action)
        {
            return node.OnProcess()
                .Where(_ => Input.IsActionJustReleased(action))
                .Select(_ => new Unit());
        }

        #endregion

        #region Frames

        public static IObservable<double> OnIdleFrame(this Node node)
        {
            return node.GetTree().OnIdleFrame()
                .Select(_ => node.GetProcessDeltaTime());
        }

        public static IObservable<double> OnNextIdleFrame(this Node node)
        {
            return node.OnIdleFrame().Take(1);
        }

        public static Task<double> WaitNextIdleFrame(this Node node)
        {
            return node.OnNextIdleFrame().ToTask();
        }

        public static IObservable<double> OnPhysicsFrame(this Node node)
        {
            return node.GetTree().OnPhysicsFrame()
                .Select(_ => node.GetPhysicsProcessDeltaTime());
        }

        public static IObservable<double> OnNextPhysicsFrame(this Node node)
        {
            return node.OnPhysicsFrame().Take(1);
        }

        public static Task<double> WaitNextPhysicsFrame(this Node node)
        {
            return node.OnNextPhysicsFrame().ToTask();
        }

        #endregion

        #region Time

        public static Task WaitFor(this Node node, TimeSpan duration, bool pauseModeProcess = true)
        {
            return node.GetTree()
                .CreateTimer((float)duration.TotalSeconds, pauseModeProcess)
                .OnTimeout()
                .Take(1)
                .ToTask();
        }

        public static Task WaitForSeconds(this Node node, double seconds, bool pauseModeProcess = true)
        {
            return node.WaitFor(TimeSpan.FromSeconds(seconds), pauseModeProcess);
        }

        #endregion
    }
}