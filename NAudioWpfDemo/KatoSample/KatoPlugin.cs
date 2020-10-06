using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace NAudioWpfDemo.KatoSample
{
    class KatoPlugin : IModule
    {
        private KatoViewModel viewModel;
        private KatoView view;

        public string Name => "Kato";

        public UserControl UserInterface
        {
            get { if (view == null) CreateView(); return view; }
        }

        private void CreateView()
        {
            view = new KatoView();
            viewModel = new KatoViewModel();
            view.DataContext = viewModel;
        }

        public void Deactivate()
        {
            viewModel.Dispose();
            view = null;
        }
    }
}
