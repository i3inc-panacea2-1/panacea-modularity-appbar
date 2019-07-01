using Panacea.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.AppBar
{
    public interface IAppBar
    {
        void Show();

        void Hide();

        void AddButton(ViewModelBase vm);

        void RemoveButton(ViewModelBase vm);
    }
}
