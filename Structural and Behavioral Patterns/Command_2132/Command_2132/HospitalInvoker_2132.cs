using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command_2132
{
    public class HospitalInvoker_2132 // Çağırıcı Sınıfı
    {
            private Stack<ICommand_2132> _commandHistory = new Stack<ICommand_2132>();

            public void ExecuteCommand(ICommand_2132 command)
            {
                command.Execute();
                _commandHistory.Push(command);
            }

            public void RevokeCommand()
            {
                if (_commandHistory.Count > 0)
                {
                    var command = _commandHistory.Pop();
                    command.Revoke();
                }
            }
        }

    }

