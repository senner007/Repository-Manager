using Manager.Models;
using System;

namespace Manager.Views
{
    public delegate void EventWithArgs(IPerson person, string prop, string propValue); // TODO : nødvendig ?
    public delegate bool EventNoArgs(); // TODO : nødvendig ?
    public interface IUpdateDelete
    {
        string UpdateText { get; set; }
        string PersonInfoLabel { get; set; }
        string PropertyLabel { get; set; }
        string UpdateResponseLabel { get; set; }

        string PersonDeleteText { get; set; }

        event Action OnUpdate;
        event Action OnTextUpdate;
        event EventWithArgs OnListClick;
        event Action OnDelete;

    }
}
