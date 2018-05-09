using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook_app
{
    public delegate void Notifier<T>(T i_Param);

    public interface IPhotoComponent
    {
        string ItemName { get; }

        event Notifier<IPhotoComponent> PhotoComponentAdded;

        event Notifier<IPhotoComponent> PhotoComponentRemoved;
    }
}
