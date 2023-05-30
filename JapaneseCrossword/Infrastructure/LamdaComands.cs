using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JapaneseCrossword.Infrastructure.Commands.Base;

namespace JapaneseCrossword.Infrastructure.Commands
{
    internal class LamdaComands : Command
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;

        public LamdaComands(Action<object> Execute,Func<object,bool>CanExecute = null) {
            execute = Execute ?? throw new ArgumentNullException (nameof(Execute));
            canExecute = CanExecute;
        }
        public override bool CanExecute (object parameter)=>canExecute?.Invoke (parameter) ?? true;
        
        public override void Execute(object parameter)=>execute(parameter);
        
    }
}
