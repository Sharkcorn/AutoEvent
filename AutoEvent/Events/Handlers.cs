using System;
using AutoEvent.Events.EventArgs;

namespace AutoEvent.Events;
public class Handlers
{
    public static event Action<Scp018CollisionArgs> Scp018Collision;
    public static event Action<Scp018UpdateArgs> Scp018Update;
    public static event Action<SwingingJailbirdEventArgs> SwingingJailbird;
    public static event Action<ChargingJailbirdEventArgs> ChargingJailbird;
    public static void OnScp018Collision(Scp018CollisionArgs ev) => Scp018Collision?.Invoke(ev);
    public static void OnScp018Update(Scp018UpdateArgs ev) => Scp018Update?.Invoke(ev);
    public static void OnSwingingJailbird(SwingingJailbirdEventArgs ev) => SwingingJailbird?.Invoke(ev);
    public static void OnChargingJailbird(ChargingJailbirdEventArgs ev) => ChargingJailbird?.Invoke(ev);
}