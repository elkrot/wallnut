using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.UI.Implementations;

namespace Wallnut.UI.Interfaces
{
    public interface INewListForm<T, TAddForm>
        where T : class,new()
        where TAddForm : AddForm, new()
    {
        void AddEntity(params object[] addParams)
            ;
         void UpdateEntity(params object[] KeyValues)
            ;

         void RemoveEntity(params object[] KeyValues);

         void RefreshData();
    }
}
