using GodotRx.Internal;
using System;
using System.Collections.Generic;
using Godot;

namespace GodotRx
{
  public static class IDisposableExtensions
  {
    private static readonly Dictionary<ulong, HashSet<IDisposable>> objectDisposables = new Dictionary<ulong, HashSet<IDisposable>>();

    public static void DisposeWith(this IDisposable disposable, GodotObject obj)
    {
      var instId = obj.GetInstanceId();

      if (!objectDisposables.ContainsKey(instId))
      {
        objectDisposables[instId] = new HashSet<IDisposable>();

        InstanceTracker.Of(obj).Freed += () =>
        {
          foreach (var disposable in objectDisposables[instId])
          {
            // GD.Print($"disposed with {instId}");
            disposable.Dispose();
          }

          objectDisposables.Remove(instId);
        };
      }

      objectDisposables[instId].Add(disposable);
    }
  }
}