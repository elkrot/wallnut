using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.UI.Implementations;

namespace Wallnut.UI.Interfaces
{
    public interface IListForm
    {
        void AddEntity<TAddForm, T>(params object[] addParams)
            where TAddForm : AddForm, new()
            where T : class,new();
         void UpdateEntity<TAddForm, T>(params object[] KeyValues)
            where TAddForm : AddForm, new()
            where T : class,new();
         void RemoveEntity<T>(params object[] KeyValues)
           where T : class,new();
         void RefreshData<T>()where T : class;
    }
}
