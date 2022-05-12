using System;
using System.Collections.Generic;

namespace Pipelines {
  
  public interface IPipeline{
    
    //Repository Pipeline ID
    string ID;
    
    //Task IDs
    List<string> tasks;
    
    //Determine state: 0 unfinished, -1 failed, 1 passed. Triggered on finishing of current Task
    int Evaluate(int parameter);
  }
}
