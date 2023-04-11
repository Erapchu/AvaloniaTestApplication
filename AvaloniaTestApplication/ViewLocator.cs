using Avalonia.Controls;
using Avalonia.Controls.Templates;
using AvaloniaTestApplication.ViewModels;
using System;

namespace AvaloniaTestApplication
{
    public class ViewLocator : IDataTemplate
    {
        //public IControl Build(object data)
        //{
        //    var name = data.GetType().FullName!.Replace("ViewModel", "View");
        //    var type = Type.GetType(name);

        //    if (type != null)
        //    {
        //        return (Control)Activator.CreateInstance(type)!;
        //    }
        //    else
        //    {
        //        return new TextBlock { Text = "Not Found: " + name };
        //    }
        //}

        public bool Match(object data)
        {
            //Avalonia.Themes.Fluent.FluentTheme
            return data is ViewModelBase;
        }

        Control? ITemplate<object?, Control?>.Build(object? param)
        {
            throw new NotImplementedException();
        }
    }
}
