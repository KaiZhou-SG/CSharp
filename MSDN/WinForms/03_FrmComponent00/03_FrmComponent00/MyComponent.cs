using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _03_FrmComponent00
{
    public partial class MyComponent : Component
    {
        public MyComponent()
        {
            InitializeComponent();
        }

        public MyComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
