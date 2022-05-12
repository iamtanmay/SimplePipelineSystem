using System;
using System.Collections.Generic;

namespace Pipelines {
  
  public interface IPipeline{
    
    //Repository Pipeline ID
    string ID;
    
    //Task IDs
    List<string> tasks;
    
    //Determine next Task. Triggered on finishing of current Task
    void Evaluate(int parameter);
  }
}
