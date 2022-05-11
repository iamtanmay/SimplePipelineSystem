using System;
using System.Collections.Generic;

namespace Pipelines {
  //Smallest unit of pipelines
  public interface ITask{
    //Unique Identifier for each Task type
    int ID;
    //Evaluate the outcome of the task. 0 unfinished, [-1, -2, -3,....-n] failed with parameter, [1, 2, 3...n] pass with parameter
    int Evaluate();
    //Set up environment for task
    void Initialise();
  }
}
