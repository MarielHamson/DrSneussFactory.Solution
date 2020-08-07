using System.Collections.Generic;
using System.ComponentModel;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Engineers = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    [DisplayName("Machine Name")]
    public string MachineName { get; set; }
    public bool IsOperational { get; set; }
    public ICollection<EngineerMachine> Engineers { get; set; }
  }

}